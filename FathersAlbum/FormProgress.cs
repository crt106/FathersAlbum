using System;
using System.Windows.Forms;

namespace FathersAlbum
{
    public partial class FormProgress : Form
    {
        public static FormProgress Instance;
        public FormProgress()
        {
            InitializeComponent();
            Instance = this;
        }

        /// <summary>
        /// 设置进度条
        /// </summary>
        public static void setProgress(int now,int total)
        {
            if (Instance != null)
            {
                if (now < 0)
                    now = 0;
                if (now > total)
                    total = 100;
                double per = now * 1.0 / total;
                int pro = (int) (Math.Round(per, 2) * 100);
                Action setpro = () => { Instance.progressBar.Value = pro ; };
                Instance.Invoke(setpro);
            }

        }

        /// <summary>
        /// 设置状态文字
        /// </summary>
        /// <param name="text"></param>
        public static void setLabel(string text)
        {
            if (Instance!=null)
            {
                Action setlabelaction = () => { Instance.labelstatus.Text = text; };
                Instance.Invoke(setlabelaction);
            }
        }

        /// <summary>
        /// 给取消按钮添加事件
        /// </summary>
        public void AddCancelEvent(EventHandler method)
        {
            buttonCancel.Click += method;
        }
    }
}
