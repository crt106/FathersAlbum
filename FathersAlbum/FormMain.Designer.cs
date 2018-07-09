namespace FathersAlbum
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加待分类文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置输出目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_folder = new System.Windows.Forms.ListView();
            this.btn_folder_clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOutpath = new System.Windows.Forms.TextBox();
            this.btn_outpath = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.imageList_folder = new System.Windows.Forms.ImageList(this.components);
            this.treeView_group = new System.Windows.Forms.TreeView();
            this.label_choosedFace = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(749, 25);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加待分类文件夹ToolStripMenuItem,
            this.设置输出目录ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 添加待分类文件夹ToolStripMenuItem
            // 
            this.添加待分类文件夹ToolStripMenuItem.Name = "添加待分类文件夹ToolStripMenuItem";
            this.添加待分类文件夹ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.添加待分类文件夹ToolStripMenuItem.Text = "添加待分类文件夹...";
            this.添加待分类文件夹ToolStripMenuItem.Click += new System.EventHandler(this.添加待分类文件夹ToolStripMenuItem_Click);
            // 
            // 设置输出目录ToolStripMenuItem
            // 
            this.设置输出目录ToolStripMenuItem.Name = "设置输出目录ToolStripMenuItem";
            this.设置输出目录ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.设置输出目录ToolStripMenuItem.Text = "设置输出目录...";
            this.设置输出目录ToolStripMenuItem.Click += new System.EventHandler(this.设置输出目录ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 67);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView_group);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label_choosedFace);
            this.splitContainer1.Size = new System.Drawing.Size(364, 379);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "当前分组设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(421, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "待分类文件夹";
            // 
            // listView_folder
            // 
            this.listView_folder.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView_folder.LargeImageList = this.imageList_folder;
            this.listView_folder.Location = new System.Drawing.Point(424, 74);
            this.listView_folder.Name = "listView_folder";
            this.listView_folder.Size = new System.Drawing.Size(313, 188);
            this.listView_folder.SmallImageList = this.imageList_folder;
            this.listView_folder.StateImageList = this.imageList_folder;
            this.listView_folder.TabIndex = 4;
            this.listView_folder.UseCompatibleStateImageBehavior = false;
            // 
            // btn_folder_clear
            // 
            this.btn_folder_clear.Location = new System.Drawing.Point(644, 46);
            this.btn_folder_clear.Name = "btn_folder_clear";
            this.btn_folder_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_folder_clear.TabIndex = 5;
            this.btn_folder_clear.Text = "清空";
            this.btn_folder_clear.UseVisualStyleBackColor = true;
            this.btn_folder_clear.Click += new System.EventHandler(this.btn_folder_clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(422, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "输出目录";
            // 
            // textBoxOutpath
            // 
            this.textBoxOutpath.Location = new System.Drawing.Point(424, 306);
            this.textBoxOutpath.Name = "textBoxOutpath";
            this.textBoxOutpath.ReadOnly = true;
            this.textBoxOutpath.Size = new System.Drawing.Size(313, 21);
            this.textBoxOutpath.TabIndex = 7;
            // 
            // btn_outpath
            // 
            this.btn_outpath.Location = new System.Drawing.Point(631, 333);
            this.btn_outpath.Name = "btn_outpath";
            this.btn_outpath.Size = new System.Drawing.Size(106, 23);
            this.btn_outpath.TabIndex = 8;
            this.btn_outpath.Text = "设置输出目录...";
            this.btn_outpath.UseVisualStyleBackColor = true;
            this.btn_outpath.Click += new System.EventHandler(this.设置输出目录ToolStripMenuItem_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start.Location = new System.Drawing.Point(613, 432);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(106, 33);
            this.btn_start.TabIndex = 9;
            this.btn_start.Text = "开始分类";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // imageList_folder
            // 
            this.imageList_folder.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_folder.ImageStream")));
            this.imageList_folder.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_folder.Images.SetKeyName(0, "folder");
            // 
            // treeView_group
            // 
            this.treeView_group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_group.Location = new System.Drawing.Point(0, 0);
            this.treeView_group.Name = "treeView_group";
            this.treeView_group.Size = new System.Drawing.Size(137, 379);
            this.treeView_group.TabIndex = 0;
            // 
            // label_choosedFace
            // 
            this.label_choosedFace.AutoSize = true;
            this.label_choosedFace.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_choosedFace.Location = new System.Drawing.Point(14, 19);
            this.label_choosedFace.Name = "label_choosedFace";
            this.label_choosedFace.Size = new System.Drawing.Size(104, 16);
            this.label_choosedFace.TabIndex = 10;
            this.label_choosedFace.Text = "当前选择人物";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 216);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "选择待分类文件夹";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 477);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_outpath);
            this.Controls.Add(this.textBoxOutpath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_folder_clear);
            this.Controls.Add(this.listView_folder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "主界面";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加待分类文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置输出目录ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_folder;
        private System.Windows.Forms.Button btn_folder_clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOutpath;
        private System.Windows.Forms.Button btn_outpath;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ImageList imageList_folder;
        private System.Windows.Forms.TreeView treeView_group;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_choosedFace;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

