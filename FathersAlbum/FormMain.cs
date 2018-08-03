using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FathersAlbum
{
    /// <summary>
    /// FormMain设计为单例模式
    /// </summary>
    public partial class FormMain : Form
    {
        private static FormMain Ins;

        #region 字段们

        public List<string> ChoosedFolderList=new List<string>();      //选择的待分类文件夹
        public static string OutputPath;                               //输出路径
        public Dictionary<string, string> OutPutPathDic = new Dictionary<string, string>();
                                                                       //输出路径子文件夹字典

        public BaiduAI BaiduAI;                                        //百度AI控制类
        private static ToolStripLabel statusLabel;                     //主窗体下侧状态栏文字

        public List<string> PathList=new List<string>();               //程序各个文件夹路径链表 
        

        public static string PicCachePath                              //图片缓存路径
        {
            get { return Application.StartupPath + "\\piccache"; }   
        }

        private CancellationTokenSource ClassifyCancelTokenSource=new CancellationTokenSource();           //控制分类人物的主tokenSource
        #endregion

        /// <summary>
        /// 获取唯一实例
        /// </summary>
        /// <returns></returns>
        public static FormMain GetInstance()
        {
            if(Ins==null)
                Ins=new FormMain();
            return Ins;
        }

        private FormMain()
        {
            //初始化
            InitializeComponent();
            BaiduAI=new BaiduAI();
            statusLabel = statuslabel1;
            #region 文件路径添加
            PathList.Add(PicCachePath);
            #endregion
            FolderCheck();
            FaceGroup.GroupList.Clear();
        }

        #region 菜单处理事件

        /// <summary>
        /// ***********************开始分类按钮按下********************
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_start_Click(object sender, EventArgs e)
        {
            //合理性检查
            if (StartCheck())
            {
                
                Func<bool> missions = () => {
                    SyncFaceWithBaidu();
                    GroupFolderCreat();
                    ClassifyPhotos();
                    return true;
                };
                //创建主任务
                var mainTask=new Task<bool>(missions,ClassifyCancelTokenSource.Token);
                //开一个计时器咯
                Stopwatch stopwatch =new Stopwatch();
                stopwatch.Reset();

                //展示进度对话框
                FormProgress pr=new FormProgress();
                pr.AddCancelEvent(((o, args) =>
                {
                    ClassifyCancelTokenSource.Cancel();
                    this.Dispose();
                } ));
                pr.Show();

                stopwatch.Start();

                //等待任务返回
                mainTask.Start();
                await mainTask;

                //关闭进度条
                pr.Dispose();
                stopwatch.Stop();

                string elaptimestr= stopwatch.Elapsed.Hours+":"+stopwatch.Elapsed.Minutes+":"+stopwatch.Elapsed.Seconds;
                MessageBox.Show($"任务结束,用时{elaptimestr}...", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("请设置完整!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        /// <summary>
        /// 添加待分类文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加待分类文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开文件夹选择
            DialogResult dr = folderBrowserDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ChoosedFolderList.Add(folderBrowserDialog.SelectedPath);
                RefreshFolderListview();
            }
        }

        /// <summary>
        /// 清空ChoosedFolderList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_folder_clear_Click(object sender, EventArgs e)
        {
            ChoosedFolderList.Clear();
            RefreshFolderListview();
        }

        /// <summary>
        /// 选择文件夹Listview右键删除文件夹时的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除选定项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView_folder.SelectedIndices.Count != 0)
            {
                foreach (var index in listView_folder.SelectedIndices)
                {
                    ChoosedFolderList.RemoveAt((int)index);    
                }
                RefreshFolderListview();
            }
        }

        /// <summary>
        /// 设置输出目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 设置输出目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                OutputPath = folderBrowserDialog.SelectedPath;
                textBoxOutpath.Text = OutputPath;
            }
        }

       
        /// <summary>
        /// TreeViewMenu展开的时候根据不同状况修改菜单内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeViewMenu_Paint(object sender, PaintEventArgs e)
        {
            //如果没有选到结点则只有添加分组

            if (treeView_group.SelectedNode == null)
            {
                添加分组ToolStripMenuItem.Visible = true;
            }
            else if (treeView_group.SelectedNode.Level == 0)
            {
                添加分组ToolStripMenuItem.Visible = true;
                添加人物ToolStripMenuItem.Visible = true;
                删除该分组ToolStripMenuItem.Visible = true;
            }
            else if (treeView_group.SelectedNode.Level == 1) 
            {
                添加分组ToolStripMenuItem.Visible = true;
                添加人物ToolStripMenuItem.Visible = true;
                删除该分组ToolStripMenuItem.Visible = true;
                删除该人物ToolStripMenuItem.Visible = true;
                修改该人物ToolStripMenuItem.Visible = true;
            }
        }

        
        
        /// <summary>
        /// 切换为子节点的时候显示图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_group_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //判断是子节点
            TreeNode thisNode = treeView_group.SelectedNode;
            if (thisNode != null && thisNode.Level == 1)
            {
                FaceGroup belongGroup = FaceGroup.GroupList.GetGroupByname(thisNode.Parent.Text);
                FaceUser user=belongGroup.UserList.GetUserByName(thisNode.Text);
                Bitmap tmp = LocalImageHelp.Base64str2Image(user.imagebase64);
                pictureBox1.Image = tmp;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        /// <summary>
        /// 保存当前分组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存分组设置ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (FaceGroup.GroupList.Count != 0)
            {
                string jsondata = JsonConvert.SerializeObject(FaceGroup.GroupList);
                using (SaveFileDialog op=new SaveFileDialog())
                {
                    op.DefaultExt = "gsvd";
                    op.Filter = "分组保存文件|*.gsvd";
                    DialogResult dr = op.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        //保存分组文件
                        StreamWriter st=File.CreateText(op.FileName);
                        st.Write(jsondata);
                        st.Close();
                    }
                }
            }
            else
            {
                statusLabelchange("当前用户分组为空");
            }
        }
        
        /// <summary>
        /// 读取分组设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 读取分组设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Filter = "分组保存文件|*.gsvd";
                DialogResult dr = op.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string str=File.ReadAllText(op.FileName, Encoding.UTF8);
                    List<FaceGroup> tmpList = JsonConvert.DeserializeObject<List<FaceGroup>>(str);
                    tmpList.FixU_Grelation();
                    FaceGroup.GroupList = tmpList;
                    RefreshTreeView();
                }
            }
                


        }

        /// <summary>
        /// 清理缓存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 清理缓存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] files=Directory.GetFiles(PicCachePath);
            long totallength = 0;
            foreach (var f in files)
            {
                FileInfo ff=new FileInfo(f);
                totallength += ff.Length;
            }

            string lengthstr="";

            //将字节数转换为各项MB GB等
            if (totallength.ToString().Length <= 10)
                for (int i = 0; i < 2; i++)
                {
                    totallength /= 1024;
                    lengthstr = totallength + " MB";
                }
            if (totallength.ToString().Length >= 11)
                for (int i = 0; i < 3; i++)
                {
                    totallength /= 1024;
                    lengthstr = totallength + " GB";
                }

           DialogResult dr=MessageBox.Show($"当前缓存大小{lengthstr},是否清除?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            //如果确定 则删除缓存
            if (dr == DialogResult.OK)
            {
                foreach (var f in files)
                {
                    File.Delete(f);
                }
            }



        }

        #region TreeViewMenu各个小项的按钮事件

        /// <summary>
        /// 添加分组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加分组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddGroup tmp=new FormAddGroup();
            tmp.StartPosition = FormStartPosition.CenterParent;
            tmp.ShowDialog();
        }

        /// <summary>
        /// 添加人物
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加人物ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddFace tmp=new FormAddFace(treeView_group.SelectedNode.Text);
            tmp.ShowDialog();
        }
        /// <summary>
        /// 取消选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_group_MouseDown(object sender, MouseEventArgs e)
        {
            TreeNode selectnode = treeView_group.GetNodeAt(e.Location);
            if (selectnode == null)
            {
                treeView_group.SelectedNode = null;
            }
        }

        /// <summary>
        /// 删除根节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除该分组ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 删除子节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除该人物ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        #endregion


        #endregion


        #region 其他处理方法

        /// <summary>
        /// 检查文件夹是否存在
        /// </summary>
        private void FolderCheck()
        {
            foreach (var p in PathList)
            {
                if (!Directory.Exists(p))
                {
                    Directory.CreateDirectory(p);
                    Debug.WriteLine(p+"文件夹创建成功");
                }
            }
        }

        /// <summary>
        /// 开始分类的合法性检查
        /// </summary>
        /// <returns></returns>
        private bool StartCheck()
        {
            if (FaceGroup.GroupList.Count == 0)
            {
                return false;
            }

            if (PathList.Count == 0)
            {
                return false;
            }

            if (OutputPath.IsNullorEmpty())
            {
                return false;
            }

            return true;

        }

        /// <summary>
        /// 在输出文件夹里面进行分组
        /// </summary>
        private void GroupFolderCreat()
        {
            //依次创建文件夹
            foreach (var group in FaceGroup.GroupList)
            {
                string grouppath = OutputPath + "/" + group.name;
                if (!Directory.Exists(grouppath))
                {
                    Directory.CreateDirectory(grouppath);
                }

                try
                {
                    OutPutPathDic.Add(group.id,grouppath);
                }
                catch (ArgumentException e)
                {
                    Debug.WriteLine(group.id+" 键重复,无需添加");
                }
            }

            //创建空文件夹
            string emptypath = OutputPath + "/未分类";
            try
            {
                OutPutPathDic.Add("none",emptypath);
            }
            catch (ArgumentException e)
            {
                Debug.WriteLine(" none 键重复,无需添加");
            }

            if (!Directory.Exists(emptypath))
            {
                Directory.CreateDirectory(emptypath);
            }
        }

        /// <summary>
        /// 刷新FolderListView的显示
        /// </summary>
        private void RefreshFolderListview()
        {
            //挂起Listview刷新
            listView_folder.BeginUpdate();
            listView_folder.Clear();
            if (ChoosedFolderList.Count > 0)
            {
                foreach (var folder in ChoosedFolderList)
                {
                    ListViewItem item = new ListViewItem();

                    item.ImageKey = "folder";
                    //此处将文件路径处理为最后一个文件名
                    string[] tempstr = folder.Split('\\');
                    item.Text = tempstr[tempstr.Length - 1];
                    listView_folder.Items.Add(item);
                }
            }



            //结束刷新
            listView_folder.EndUpdate();
        }

        /// <summary>
        /// 主界面状态栏文字切换
        /// </summary>
        /// <param name="text"></param>
        public static void statusLabelchange(string text)
        {
            Action changetext = () => { statusLabel.Text = text;};
            FormMain.GetInstance().Invoke(changetext);
        }

        /// <summary>
        /// 刷新树列表
        /// </summary>
        public void RefreshTreeView()
        {
            treeView_group.BeginUpdate();
            treeView_group.Nodes.Clear();
            foreach (var g in FaceGroup.GroupList)
            {
                TreeNode Root=treeView_group.Nodes.Add(g.name);
                foreach (var u in g.UserList)
                {
                    Root.Nodes.Add(u.name);
                }
            }
            treeView_group.ExpandAll();

            treeView_group.EndUpdate();
        }
        #endregion


        #region 人脸及分组管理方法

        /// <summary>
        /// 添加分组
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public void AddGroup(string name,string id)
        {
            FaceGroup.GroupList.Add(new FaceGroup(name,id));
            RefreshTreeView();
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        public void AddUser(string groupname,string username,string uid,string image64,string userinfo="")
        {
            FaceGroup.GroupList.GetGroupByname(groupname).AddUser(new FaceUser(username,uid,image64,userInfo:userinfo));
            RefreshTreeView();
        }

        /// <summary>
        /// 调用百度的API，将当前人脸数据同步到控制台
        /// </summary>
        public void SyncFaceWithBaidu()
        {
            try
            {
                FormProgress.setLabel("开始进行人脸同步...");
                //先同步分组
                foreach (var group in FaceGroup.GroupList)
                {
                    var resultJObject = BaiduAI.BaiduClient.GroupAdd(group.id);
                    int resulterrorcode = (int)resultJObject.GetValue("error_code");
                    //0代表用户组创建成功 223101代表用户组重复 无需创建
                    if (resulterrorcode == 0 || resulterrorcode == 223101)
                    {
                        //开始创建用户
                        foreach (var user in group.UserList)
                        {
                            var option = new Dictionary<string, object>
                            {
                                {"user_info", user.UserInfo}
                            };

                            JObject returnJ;
                            while (true)
                            {
                                returnJ = BaiduAI.BaiduClient.UserAdd(user.imagebase64, "BASE64", group.id, user.uid, option);
                                //0代表成功 223101代表用户重复
                                if ((int)returnJ.GetValue("error_code") != 0 && (int)returnJ.GetValue("error_code") != 223105)
                                {
                                    if(returnJ.GetValue("error_code").ToObject<int>()==18)
                                        continue;                                  
                                    throw new Exception(returnJ.ToString());
                                }
                                FormProgress.setLabel("人脸同步到Baidu成功");
                                    break;
                            } 
                        }
                    }
                    else
                    {
                        Debug.WriteLine("------------发生错误------------");
                        Debug.WriteLine(resultJObject.ToString());
                        continue;
                    }               
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// *****************************核心方法 分类照片************************
        /// </summary>
        public void ClassifyPhotos()
        {
            string classifyGroups = string.Empty;
            //构建分组字符串
            for (int i = 0; i < FaceGroup.GroupList.Count; i++)
            {
                if (i != FaceGroup.GroupList.Count && i <= 10)
                {
                    classifyGroups += FaceGroup.GroupList[i].id + ",";
                }
                else
                {
                    classifyGroups += FaceGroup.GroupList[i].id;
                }
            }

            //人脸查找参数
            var searchoptions = new Dictionary<string, object>{
                {"max_user_num", 5}
            };

            //人脸检测参数
            var detectoptions = new Dictionary<string, object>{
                {"face_field", "age"},
                {"max_face_num", 10},
                {"face_type", "LIVE"}
            };

            foreach (var folder in ChoosedFolderList)
            {
                if (!ClassifyCancelTokenSource.IsCancellationRequested)
                {
                    //只寻找常见三种类型图片文件
                    FormProgress.setLabel("开始统计文件数量...");
                    string[] photos = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories).Where(t =>
                            (t.ToLower().EndsWith("jpg") || t.ToLower().EndsWith("png") || t.ToLower().EndsWith("bmp")))
                        .ToArray();
                    int nowphotocount = 0;
                    int totalphotocount = photos.Length;
                    foreach (var ppath in photos)
                    {
                        if (ClassifyCancelTokenSource.IsCancellationRequested)
                        {
                            statusLabelchange("任务取消!");
                            return;
                        }
                            
                        FormProgress.setLabel($"开始进行照片分组,第{nowphotocount++}张,共{totalphotocount}张");
                        FormProgress.setProgress(nowphotocount, totalphotocount);
                        //构建缓存文件路径
                        string tmpphoto = PicCachePath + "\\" + ppath.Split('\\').Last();
                        //压缩图片
                        LocalImageHelp.CompressImage(ppath, tmpphoto);
                        //新建分类输出组名列表
                        List<string> classifyResultList = new List<string>();
                        string img64 = LocalImageHelp.Image2Base64str(tmpphoto);

                        //循环调用人脸检测接口 避免QPS超限
                        JObject detectresult;
                        while (true)
                        {
                            detectresult = BaiduAI.BaiduClient.Detect(img64, "BASE64", detectoptions);
                            if (!detectresult.CheckErrorCodeZero())
                            {
                                //code 222202 pic not has face
                                if (detectresult.GetErrorCode() == 222202)
                                    //跳出当前照片的处理
                                    goto outthisphoto;

                                Thread.Sleep(100);
                            }
                            else
                            {
                                break;
                            }
                        }

                        //人脸检测返回人脸信息列表
                        var detectFaceList = (JArray)((JObject)detectresult.GetValue("result")).GetValue("face_list");

                        foreach (var face in detectFaceList)
                        {
                            var faceJObject = (JObject)face; //转换为Json对象
                            double faceprobability = (double)faceJObject.GetValue("face_probability");
                            if (faceprobability > 0.7)
                            {
                                //如果人脸可能性大于0.6再进行人脸库查找
                                string facetoken = (string)faceJObject.GetValue("face_token");
                                //循环调用人脸查找接口 避免QPS超限
                                JObject searchresult;
                                while (true)
                                {
                                    searchresult = BaiduAI.BaiduClient.Search(facetoken, "FACE_TOKEN", classifyGroups, searchoptions);
                                    if (!searchresult.CheckErrorCodeZero())
                                    {
                                        Thread.Sleep(100);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                //进行人脸结果判断
                                JArray userlist =
                                    (JArray)((JObject)searchresult.GetValue("result")).GetValue("user_list");


                                foreach (var user in userlist)
                                {
                                    JObject userobj = user.ToObject<JObject>();
                                    //获取得分
                                    double score = userobj.GetValue("score").ToObject<double>();
                                    //开始文件分类
                                    if (score > 80)
                                    {
                                        string group_id = userobj.GetValue("group_id").ToString();
                                        //如果该组不存在 则添加该组的名字
                                        if (!classifyResultList.Contains(group_id))
                                            classifyResultList.Add(group_id);
                                    }
                                }


                            }
                        }

                        outthisphoto:
                        //如果没有一个得分在80以上
                        if (classifyResultList.Count == 0)
                        {
                            classifyResultList.Add("none");
                        }
                        //复制文件
                        CopyFile(ppath, classifyResultList);
                    }
                }
                else             
                    return;       
            }
            
        }

        /// <summary>
        /// 复制文件
        /// </summary>
        /// <param name="file">源文件</param>
        /// <param name="targetGroups">目标分组的name 包括none </param>
        public void CopyFile(string file,List<string> targetGroups)
        {
            foreach (var g in targetGroups)
            {
                FileInfo img=new FileInfo(file);
                string filename = file.Split('\\').Last();
                img.CopyTo(OutPutPathDic[g]+"\\"+filename, true);
                statusLabelchange($"{filename}已经分类到分组{g}中");
            }
        }









        #endregion

        
    }
}
