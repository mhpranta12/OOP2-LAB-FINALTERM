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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addnoticeBtn
            // 
            this.addnoticeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addnoticeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnoticeBtn.Location = new System.Drawing.Point(297, 281);
            this.addnoticeBtn.Name = "addnoticeBtn";
            this.addnoticeBtn.Size = new System.Drawing.Size(301, 59);
            this.addnoticeBtn.TabIndex = 1;
            this.addnoticeBtn.Text = "📝 Add Notice";
            this.addnoticeBtn.UseVisualStyleBackColor = false;
            this.addnoticeBtn.Click += new System.EventHandler(this.addnoticeBtnClk);
            // 
            // viewntcBtn
            // 
            this.viewntcBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.viewntcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewntcBtn.Location = new System.Drawing.Point(751, 281);
            this.viewntcBtn.Name = "viewntcBtn";
            this.viewntcBtn.Size = new System.Drawing.Size(279, 59);
            this.viewntcBtn.TabIndex = 2;
            this.viewntcBtn.Text = "📅 View All Notices";
            this.viewntcBtn.UseVisualStyleBackColor = false;
            this.viewntcBtn.Click += new System.EventHandler(this.viewntcBtnClk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(91, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "📅 Notices";
            // 
            // Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1375, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewntcBtn);
            this.Controls.Add(this.addnoticeBtn);
            this.Name = "Notice";
            this.Text = "Notice";
            this.Load += new System.EventHandler(this.Notice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addnoticeBtn;
        private System.Windows.Forms.Button viewntcBtn;
        private System.Windows.Forms.Label label1;
    }
}