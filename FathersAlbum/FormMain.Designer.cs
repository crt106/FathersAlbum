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
            this.保存分组设置ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.保存分组设置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.读取分组设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.清理缓存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView_group = new System.Windows.Forms.TreeView();
            this.TreeViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加人物ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.删除该分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除该人物ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.修改该人物ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_choosedFace = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_folder = new System.Windows.Forms.ListView();
            this.ListviewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除选定项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList_folder = new System.Windows.Forms.ImageList(this.components);
            this.btn_folder_clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOutpath = new System.Windows.Forms.TextBox();
            this.btn_outpath = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TreeViewMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ListviewMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MainMenu.Size = new System.Drawing.Size(1124, 34);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加待分类文件夹ToolStripMenuItem,
            this.设置输出目录ToolStripMenuItem,
            this.保存分组设置ToolStripMenuItem,
            this.保存分组设置ToolStripMenuItem1,
            this.读取分组设置ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.清理缓存ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 添加待分类文件夹ToolStripMenuItem
            // 
            this.添加待分类文件夹ToolStripMenuItem.Name = "添加待分类文件夹ToolStripMenuItem";
            this.添加待分类文件夹ToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.添加待分类文件夹ToolStripMenuItem.Text = "添加待分类文件夹...";
            this.添加待分类文件夹ToolStripMenuItem.Click += new System.EventHandler(this.添加待分类文件夹ToolStripMenuItem_Click);
            // 
            // 设置输出目录ToolStripMenuItem
            // 
            this.设置输出目录ToolStripMenuItem.Name = "设置输出目录ToolStripMenuItem";
            this.设置输出目录ToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.设置输出目录ToolStripMenuItem.Text = "设置输出目录...";
            this.设置输出目录ToolStripMenuItem.Click += new System.EventHandler(this.设置输出目录ToolStripMenuItem_Click);
            // 
            // 保存分组设置ToolStripMenuItem
            // 
            this.保存分组设置ToolStripMenuItem.Name = "保存分组设置ToolStripMenuItem";
            this.保存分组设置ToolStripMenuItem.Size = new System.Drawing.Size(245, 6);
            // 
            // 保存分组设置ToolStripMenuItem1
            // 
            this.保存分组设置ToolStripMenuItem1.Name = "保存分组设置ToolStripMenuItem1";
            this.保存分组设置ToolStripMenuItem1.Size = new System.Drawing.Size(248, 30);
            this.保存分组设置ToolStripMenuItem1.Text = "保存分组设置...";
            this.保存分组设置ToolStripMenuItem1.Click += new System.EventHandler(this.保存分组设置ToolStripMenuItem1_Click);
            // 
            // 读取分组设置ToolStripMenuItem
            // 
            this.读取分组设置ToolStripMenuItem.Name = "读取分组设置ToolStripMenuItem";
            this.读取分组设置ToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.读取分组设置ToolStripMenuItem.Text = "读取分组设置...";
            this.读取分组设置ToolStripMenuItem.Click += new System.EventHandler(this.读取分组设置ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(245, 6);
            // 
            // 清理缓存ToolStripMenuItem
            // 
            this.清理缓存ToolStripMenuItem.Name = "清理缓存ToolStripMenuItem";
            this.清理缓存ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.清理缓存ToolStripMenuItem.Text = "清理缓存...";
            this.清理缓存ToolStripMenuItem.Click += new System.EventHandler(this.清理缓存ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(18, 100);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer1.Size = new System.Drawing.Size(546, 568);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.SplitterWidth = 15;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView_group
            // 
            this.treeView_group.ContextMenuStrip = this.TreeViewMenu;
            this.treeView_group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_group.Font = new System.Drawing.Font("华文中宋", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView_group.Location = new System.Drawing.Point(0, 0);
            this.treeView_group.Margin = new System.Windows.Forms.Padding(4);
            this.treeView_group.Name = "treeView_group";
            this.treeView_group.Size = new System.Drawing.Size(205, 568);
            this.treeView_group.TabIndex = 0;
            this.treeView_group.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_group_NodeMouseClick);
            this.treeView_group.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView_group_MouseDown);
            // 
            // TreeViewMenu
            // 
            this.TreeViewMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TreeViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加分组ToolStripMenuItem,
            this.添加人物ToolStripMenuItem,
            this.toolStripSeparator1,
            this.删除该分组ToolStripMenuItem,
            this.删除该人物ToolStripMenuItem,
            this.toolStripSeparator2,
            this.修改该人物ToolStripMenuItem});
            this.TreeViewMenu.Name = "TreeViewMenu";
            this.TreeViewMenu.Size = new System.Drawing.Size(183, 156);
            this.TreeViewMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.TreeViewMenu_Paint);
            // 
            // 添加分组ToolStripMenuItem
            // 
            this.添加分组ToolStripMenuItem.Name = "添加分组ToolStripMenuItem";
            this.添加分组ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.添加分组ToolStripMenuItem.Text = "添加分组...";
            this.添加分组ToolStripMenuItem.Visible = false;
            this.添加分组ToolStripMenuItem.Click += new System.EventHandler(this.添加分组ToolStripMenuItem_Click);
            // 
            // 添加人物ToolStripMenuItem
            // 
            this.添加人物ToolStripMenuItem.Name = "添加人物ToolStripMenuItem";
            this.添加人物ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.添加人物ToolStripMenuItem.Text = "添加人物...";
            this.添加人物ToolStripMenuItem.Visible = false;
            this.添加人物ToolStripMenuItem.Click += new System.EventHandler(this.添加人物ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // 删除该分组ToolStripMenuItem
            // 
            this.删除该分组ToolStripMenuItem.Name = "删除该分组ToolStripMenuItem";
            this.删除该分组ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.删除该分组ToolStripMenuItem.Text = "删除该分组...";
            this.删除该分组ToolStripMenuItem.Visible = false;
            this.删除该分组ToolStripMenuItem.Click += new System.EventHandler(this.删除该分组ToolStripMenuItem_Click);
            // 
            // 删除该人物ToolStripMenuItem
            // 
            this.删除该人物ToolStripMenuItem.Name = "删除该人物ToolStripMenuItem";
            this.删除该人物ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.删除该人物ToolStripMenuItem.Text = "删除该人物...";
            this.删除该人物ToolStripMenuItem.Visible = false;
            this.删除该人物ToolStripMenuItem.Click += new System.EventHandler(this.删除该人物ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(237, 6);
            // 
            // 修改该人物ToolStripMenuItem
            // 
            this.修改该人物ToolStripMenuItem.Name = "修改该人物ToolStripMenuItem";
            this.修改该人物ToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.修改该人物ToolStripMenuItem.Text = "修改该人物...";
            this.修改该人物ToolStripMenuItem.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label_choosedFace
            // 
            this.label_choosedFace.AutoSize = true;
            this.label_choosedFace.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_choosedFace.Location = new System.Drawing.Point(21, 28);
            this.label_choosedFace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_choosedFace.Name = "label_choosedFace";
            this.label_choosedFace.Size = new System.Drawing.Size(154, 24);
            this.label_choosedFace.TabIndex = 10;
            this.label_choosedFace.Text = "当前选择人物";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "当前分组设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(632, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "待分类文件夹";
            // 
            // listView_folder
            // 
            this.listView_folder.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView_folder.ContextMenuStrip = this.ListviewMenu;
            this.listView_folder.LargeImageList = this.imageList_folder;
            this.listView_folder.Location = new System.Drawing.Point(636, 111);
            this.listView_folder.Margin = new System.Windows.Forms.Padding(4);
            this.listView_folder.MultiSelect = false;
            this.listView_folder.Name = "listView_folder";
            this.listView_folder.Size = new System.Drawing.Size(468, 280);
            this.listView_folder.SmallImageList = this.imageList_folder;
            this.listView_folder.StateImageList = this.imageList_folder;
            this.listView_folder.TabIndex = 4;
            this.listView_folder.UseCompatibleStateImageBehavior = false;
            // 
            // ListviewMenu
            // 
            this.ListviewMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ListviewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除选定项目ToolStripMenuItem});
            this.ListviewMenu.Name = "ListviewMenu";
            this.ListviewMenu.Size = new System.Drawing.Size(189, 32);
            // 
            // 删除选定项目ToolStripMenuItem
            // 
            this.删除选定项目ToolStripMenuItem.Name = "删除选定项目ToolStripMenuItem";
            this.删除选定项目ToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.删除选定项目ToolStripMenuItem.Text = "删除选定项目";
            this.删除选定项目ToolStripMenuItem.Click += new System.EventHandler(this.删除选定项目ToolStripMenuItem_Click);
            // 
            // imageList_folder
            // 
            this.imageList_folder.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_folder.ImageStream")));
            this.imageList_folder.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_folder.Images.SetKeyName(0, "folder");
            // 
            // btn_folder_clear
            // 
            this.btn_folder_clear.Location = new System.Drawing.Point(966, 69);
            this.btn_folder_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_folder_clear.Name = "btn_folder_clear";
            this.btn_folder_clear.Size = new System.Drawing.Size(112, 34);
            this.btn_folder_clear.TabIndex = 5;
            this.btn_folder_clear.Text = "清空";
            this.btn_folder_clear.UseVisualStyleBackColor = true;
            this.btn_folder_clear.Click += new System.EventHandler(this.btn_folder_clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(633, 420);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "输出目录";
            // 
            // textBoxOutpath
            // 
            this.textBoxOutpath.Location = new System.Drawing.Point(636, 459);
            this.textBoxOutpath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOutpath.Name = "textBoxOutpath";
            this.textBoxOutpath.ReadOnly = true;
            this.textBoxOutpath.Size = new System.Drawing.Size(468, 28);
            this.textBoxOutpath.TabIndex = 7;
            // 
            // btn_outpath
            // 
            this.btn_outpath.Location = new System.Drawing.Point(946, 500);
            this.btn_outpath.Margin = new System.Windows.Forms.Padding(4);
            this.btn_outpath.Name = "btn_outpath";
            this.btn_outpath.Size = new System.Drawing.Size(159, 34);
            this.btn_outpath.TabIndex = 8;
            this.btn_outpath.Text = "设置输出目录...";
            this.btn_outpath.UseVisualStyleBackColor = true;
            this.btn_outpath.Click += new System.EventHandler(this.设置输出目录ToolStripMenuItem_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start.Location = new System.Drawing.Point(920, 648);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(159, 50);
            this.btn_start.TabIndex = 9;
            this.btn_start.Text = "开始分类";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "选择待分类文件夹";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1124, 29);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslabel1
            // 
            this.statuslabel1.Name = "statuslabel1";
            this.statuslabel1.Size = new System.Drawing.Size(195, 24);
            this.statuslabel1.Text = "toolStripStatusLabel1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1124, 737);
            this.Controls.Add(this.statusStrip1);
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
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "主界面";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TreeViewMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ListviewMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip ListviewMenu;
        private System.Windows.Forms.ToolStripMenuItem 删除选定项目ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip TreeViewMenu;
        private System.Windows.Forms.ToolStripMenuItem 添加分组ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加人物ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 删除该分组ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除该人物ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 修改该人物ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel1;
        private System.Windows.Forms.ToolStripSeparator 保存分组设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存分组设置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 读取分组设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 清理缓存ToolStripMenuItem;
    }
}

