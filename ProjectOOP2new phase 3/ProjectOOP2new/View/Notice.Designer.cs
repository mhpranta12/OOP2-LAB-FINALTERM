namespace ProjectOOP2new.View
{
    partial class Notice
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
            this.addnoticeBtn = new System.Windows.Forms.Button();
            this.viewntcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addnoticeBtn
            // 
            this.addnoticeBtn.Location = new System.Drawing.Point(400, 259);
            this.addnoticeBtn.Name = "addnoticeBtn";
            this.addnoticeBtn.Size = new System.Drawing.Size(182, 59);
            this.addnoticeBtn.TabIndex = 1;
            this.addnoticeBtn.Text = "Add Notice";
            this.addnoticeBtn.UseVisualStyleBackColor = true;
            this.addnoticeBtn.Click += new System.EventHandler(this.addnoticeBtnClk);
            // 
            // viewntcBtn
            // 
            this.viewntcBtn.Location = new System.Drawing.Point(744, 259);
            this.viewntcBtn.Name = "viewntcBtn";
            this.viewntcBtn.Size = new System.Drawing.Size(182, 59);
            this.viewntcBtn.TabIndex = 2;
            this.viewntcBtn.Text = "View All Notices";
            this.viewntcBtn.UseVisualStyleBackColor = true;
            this.viewntcBtn.Click += new System.EventHandler(this.viewntcBtnClk);
            // 
            // Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 577);
            this.Controls.Add(this.viewntcBtn);
            this.Controls.Add(this.addnoticeBtn);
            this.Name = "Notice";
            this.Text = "Notice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addnoticeBtn;
        private System.Windows.Forms.Button viewntcBtn;
    }
}