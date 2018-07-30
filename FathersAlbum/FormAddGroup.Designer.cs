namespace FathersAlbum
{
    partial class FormAddGroup
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
            this.btn_addg_ok = new System.Windows.Forms.Button();
            this.btn_addg_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Groupname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_GroupID = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_addg_ok
            // 
            this.btn_addg_ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addg_ok.Location = new System.Drawing.Point(76, 110);
            this.btn_addg_ok.Name = "btn_addg_ok";
            this.btn_addg_ok.Size = new System.Drawing.Size(74, 23);
            this.btn_addg_ok.TabIndex = 0;
            this.btn_addg_ok.Text = "添加";
            this.btn_addg_ok.UseVisualStyleBackColor = true;
            // 
            // btn_addg_cancel
            // 
            this.btn_addg_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addg_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_addg_cancel.Location = new System.Drawing.Point(238, 110);
            this.btn_addg_cancel.Name = "btn_addg_cancel";
            this.btn_addg_cancel.Size = new System.Drawing.Size(74, 23);
            this.btn_addg_cancel.TabIndex = 1;
            this.btn_addg_cancel.Text = "取消";
            this.btn_addg_cancel.UseVisualStyleBackColor = true;
            this.btn_addg_cancel.Click += new System.EventHandler(this.btn_addg_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "组名称";
            // 
            // textBox_Groupname
            // 
            this.textBox_Groupname.Location = new System.Drawing.Point(96, 22);
            this.textBox_Groupname.Name = "textBox_Groupname";
            this.textBox_Groupname.Size = new System.Drawing.Size(240, 21);
            this.textBox_Groupname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "组ID(仅ASCII)";
            // 
            // textBox_GroupID
            // 
            this.textBox_GroupID.AsciiOnly = true;
            this.textBox_GroupID.Location = new System.Drawing.Point(144, 56);
            this.textBox_GroupID.Name = "textBox_GroupID";
            this.textBox_GroupID.Size = new System.Drawing.Size(192, 21);
            this.textBox_GroupID.TabIndex = 6;
            this.textBox_GroupID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_GroupID_KeyPress);
            // 
            // FormAddGroup
            // 
            this.AcceptButton = this.btn_addg_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_addg_cancel;
            this.ClientSize = new System.Drawing.Size(395, 145);
            this.Controls.Add(this.textBox_GroupID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Groupname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addg_cancel);
            this.Controls.Add(this.btn_addg_ok);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddGroup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "添加分组...";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addg_ok;
        private System.Windows.Forms.Button btn_addg_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Groupname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox textBox_GroupID;
    }
}