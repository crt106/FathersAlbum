namespace FathersAlbum
{
    partial class FormProgress
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelstatus = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 15);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(501, 27);
            this.progressBar.TabIndex = 0;
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelstatus.Location = new System.Drawing.Point(12, 61);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(116, 18);
            this.labelstatus.TabIndex = 1;
            this.labelstatus.Text = "进度说明文字";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(392, 61);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 28);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(525, 113);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.progressBar);
            this.Name = "FormProgress";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "处理中...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.Button buttonCancel;
    }
}