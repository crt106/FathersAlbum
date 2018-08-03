namespace FathersAlbum
{
    partial class FormAddFace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxuserinfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBelongGroup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxBelongGroup);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxuserinfo);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxUid);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.buttonChoose);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainer1.Panel2.Controls.Add(this.buttonOK);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(747, 418);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(101, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(176, 28);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxUid
            // 
            this.textBoxUid.Location = new System.Drawing.Point(101, 87);
            this.textBoxUid.Name = "textBoxUid";
            this.textBoxUid.Size = new System.Drawing.Size(176, 28);
            this.textBoxUid.TabIndex = 3;
            this.textBoxUid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Uid_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "uid";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(70, 364);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(98, 28);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(257, 364);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 28);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(277, 256);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(121, 33);
            this.buttonChoose.TabIndex = 3;
            this.buttonChoose.Text = "选择照片...";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(30, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "请事先裁剪好合适的只包含该人物的人脸照片";
            // 
            // textBoxuserinfo
            // 
            this.textBoxuserinfo.Location = new System.Drawing.Point(129, 164);
            this.textBoxuserinfo.Multiline = true;
            this.textBoxuserinfo.Name = "textBoxuserinfo";
            this.textBoxuserinfo.Size = new System.Drawing.Size(170, 151);
            this.textBoxuserinfo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "人物描述";
            // 
            // textBoxBelongGroup
            // 
            this.textBoxBelongGroup.Location = new System.Drawing.Point(107, 352);
            this.textBoxBelongGroup.Name = "textBoxBelongGroup";
            this.textBoxBelongGroup.ReadOnly = true;
            this.textBoxBelongGroup.Size = new System.Drawing.Size(176, 28);
            this.textBoxBelongGroup.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "所属分组";
            // 
            // FormAddFace
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(747, 418);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddFace";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加人物";
            this.Load += new System.EventHandler(this.FormAddFace_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBelongGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxuserinfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}