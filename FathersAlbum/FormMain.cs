using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FathersAlbum
{
    public partial class FormMain : Form
    {

        #region 字段们

        public List<string> ChoosedFolderList=new List<string>();      //选择的待分类文件夹
        public static string OutputPath;                               //输出路径
        

        #endregion

        public FormMain()
        {
            InitializeComponent();
        }

        #region 菜单处理事件

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
        #endregion

        /// <summary>
        /// 刷新FolderListView的显示
        /// </summary>
        private void RefreshFolderListview()
        {
            //挂起Listview刷新
            listView_folder.BeginUpdate();
            listView_folder.Clear();
            if(ChoosedFolderList.Count>0)
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

        
    }
}
