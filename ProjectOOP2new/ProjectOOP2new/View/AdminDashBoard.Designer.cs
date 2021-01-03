namespace ProjectOOP2new.View
{
    partial class AdminDashBoard
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
            this.courseBtn = new System.Windows.Forms.Button();
            this.studentsBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.teachersBtn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noticeBtn
            // 
            this.noticeBtn.Location = new System.Drawing.Point(118, 198);
            this.noticeBtn.Name = "noticeBtn";
            this.noticeBtn.Size = new System.Drawing.Size(139, 39);
            this.noticeBtn.TabIndex = 0;
            this.noticeBtn.Text = "Upload A Notice";
            this.noticeBtn.UseVisualStyleBackColor = true;
            this.noticeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // courseBtn
            // 
            this.courseBtn.Location = new System.Drawing.Point(663, 199);
            this.courseBtn.Name = "courseBtn";
            this.courseBtn.Size = new System.Drawing.Size(98, 38);
            this.courseBtn.TabIndex = 1;
            this.courseBtn.Text = "Courses";
            this.courseBtn.UseVisualStyleBackColor = true;
            this.courseBtn.Click += new System.EventHandler(this.coursesBtnClk);
            // 
            // studentsBtn
            // 
            this.studentsBtn.Location = new System.Drawing.Point(502, 199);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(102, 38);
            this.studentsBtn.TabIndex = 2;
            this.studentsBtn.Text = "Students";
            this.studentsBtn.UseVisualStyleBackColor = true;
            this.studentsBtn.Click += new System.EventHandler(this.stnBtnCLk);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(1178, 53);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // teachersBtn
            // 
            this.teachersBtn.Location = new System.Drawing.Point(319, 199);
            this.teachersBtn.Name = "teachersBtn";
            this.teachersBtn.Size = new System.Drawing.Size(107, 38);
            this.teachersBtn.TabIndex = 4;
            this.teachersBtn.Text = "Teachers";
            this.teachersBtn.UseVisualStyleBackColor = true;
            this.teachersBtn.Click += new System.EventHandler(this.teachersBtn_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1006, 198);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 39);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(837, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 38);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(100, 28);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(367, 48);
            this.topLabel.TabIndex = 7;
            this.topLabel.Text = "Admin Dashboard";
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 558);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.teachersBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.studentsBtn);
            this.Controls.Add(this.courseBtn);
            this.Controls.Add(this.noticeBtn);
            this.Name = "AdminDashBoard";
            this.Text = "AdminDashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button noticeBtn;
        private System.Windows.Forms.Button courseBtn;
        private System.Windows.Forms.Button studentsBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button teachersBtn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label topLabel;
    }
}