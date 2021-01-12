namespace ProjectOOP2new.View
{
    partial class Student
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
            this.noticeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.uBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noticeBtn
            // 
            this.noticeBtn.Location = new System.Drawing.Point(998, 226);
            this.noticeBtn.Name = "noticeBtn";
            this.noticeBtn.Size = new System.Drawing.Size(201, 58);
            this.noticeBtn.TabIndex = 1;
            this.noticeBtn.Text = "View All Students";
            this.noticeBtn.UseVisualStyleBackColor = true;
            this.noticeBtn.Click += new System.EventHandler(this.viewallstndBtnCLk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove a Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.dltstndBtnClk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add a Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addstndBtnClk);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(130, 61);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(188, 50);
            this.topLabel.TabIndex = 8;
            this.topLabel.Text = "Students";
            // 
            // uBtn
            // 
            this.uBtn.Location = new System.Drawing.Point(713, 226);
            this.uBtn.Name = "uBtn";
            this.uBtn.Size = new System.Drawing.Size(209, 58);
            this.uBtn.TabIndex = 9;
            this.uBtn.Text = "Update a Student";
            this.uBtn.UseVisualStyleBackColor = true;
            this.uBtn.Click += new System.EventHandler(this.uBtnClk);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 559);
            this.Controls.Add(this.uBtn);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.noticeBtn);
            this.Name = "Student";
            this.Text = "Students";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button noticeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button uBtn;
    }
}