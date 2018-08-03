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
    public partial class FormAddFace : Form
    {
        public string BelongGroupname;
        public string UserFaceSource;                              //用户人脸源路径

        public FormAddFace(string groupname)
        {
            InitializeComponent();
            BelongGroupname = groupname;
        }

        private void FormAddFace_Load(object sender, EventArgs e)
        {
            textBoxBelongGroup.Text = BelongGroupname;
        }

        
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (CheckIfIlleagal())
            {
                //处理图片转换为base64
                string targetpath = FormMain.PicCachePath + "/" + textBoxUid.Text + ".jpg";
                LocalImageHelp.CompressImage(UserFaceSource,targetpath );
                string base64image = LocalImageHelp.Image2Base64str(targetpath);
                FormMain.GetInstance().AddUser(textBoxBelongGroup.Text,textBoxName.Text,textBoxUid.Text,base64image,textBoxuserinfo.Text);
                Dispose();
            }
            else
            {
                MessageBox.Show("请录入完整的数据", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        /// <summary>
        /// 限制ID用户的输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_Uid_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyascii = e.KeyChar;
            //判断是不是大小写字母和数字
            if ((keyascii >= 47 && keyascii <= 57) || (keyascii >= 65 && keyascii <= 90) ||
                (keyascii >= 97 && keyascii <= 122))
            {
                //接受输入 返回
                e.Handled = false;
                return;
            }
            //否则不是下划线和退格键
            else if (keyascii != 127 && keyascii != 95 && keyascii != 8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 选择图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            UserFaceSource = string.Empty;
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Filter = "一般图形文件|*.jpg;*.png;*.jpeg";
                op.Title = "选择裁剪好的人脸文件";
                op.RestoreDirectory = true;
                //确定之时执行下一步操作
                if (op.ShowDialog() == DialogResult.OK)
                {
                    UserFaceSource = op.FileName;
                    RefreshPicBox();
                }
            }
        }

        /// <summary>
        /// 检查用户的输入是否合法
        /// </summary>
        /// <returns></returns>
        private bool CheckIfIlleagal()
        {
            if (!textBoxName.Text.IsNullorEmpty() && !textBoxUid.Text.IsNullorEmpty() &&
                !UserFaceSource.IsNullorEmpty())
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 刷新图片显示格子
        /// </summary>
        private void RefreshPicBox()
        {
            if (!UserFaceSource.IsNullorEmpty())
            {
                pictureBox1.Load(UserFaceSource);
                pictureBox1.Invalidate();
            }
        }

        
    }
}
