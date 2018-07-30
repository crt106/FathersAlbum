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
    public partial class FormAddGroup : Form
    {
        public FormAddGroup()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取消按钮按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addg_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// 限制GroupID用户的输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_GroupID_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
