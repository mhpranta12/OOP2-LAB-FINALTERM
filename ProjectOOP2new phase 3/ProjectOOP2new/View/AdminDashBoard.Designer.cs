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
            this.topLabel = new System.Windows.Forms.Label();
            this.serchtextBox = new System.Windows.Forms.TextBox();
            this.serchBtn = new System.Windows.Forms.Button();
            this.searchoptioncombobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noticeBtn
            // 
            this.noticeBtn.Location = new System.Drawing.Point(98, 319);
            this.noticeBtn.Name = "noticeBtn";
            this.noticeBtn.Size = new System.Drawing.Size(182, 59);
            this.noticeBtn.TabIndex = 0;
            this.noticeBtn.Text = "Notices";
            this.noticeBtn.UseVisualStyleBackColor = true;
            this.noticeBtn.Click += new System.EventHandler(this.noticeBtnClk);
            // 
            // courseBtn
            // 
            this.courseBtn.Location = new System.Drawing.Point(847, 318);
            this.courseBtn.Name = "courseBtn";
            this.courseBtn.Size = new System.Drawing.Size(176, 59);
            this.courseBtn.TabIndex = 1;
            this.courseBtn.Text = "Courses";
            this.courseBtn.UseVisualStyleBackColor = true;
            this.courseBtn.Click += new System.EventHandler(this.coursesBtnClk);
            // 
            // studentsBtn
            // 
            this.studentsBtn.Location = new System.Drawing.Point(600, 318);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(162, 59);
            this.studentsBtn.TabIndex = 2;
            this.studentsBtn.Text = "Students";
            this.studentsBtn.UseVisualStyleBackColor = true;
            this.studentsBtn.Click += new System.EventHandler(this.stnBtnCLk);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(1142, 52);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(126, 43);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // teachersBtn
            // 
            this.teachersBtn.Location = new System.Drawing.Point(352, 318);
            this.teachersBtn.Name = "teachersBtn";
            this.teachersBtn.Size = new System.Drawing.Size(166, 59);
            this.teachersBtn.TabIndex = 4;
            this.teachersBtn.Text = "Teachers";
            this.teachersBtn.UseVisualStyleBackColor = true;
            this.teachersBtn.Click += new System.EventHandler(this.teachersBtn_Click);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(89, 45);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(379, 50);
            this.topLabel.TabIndex = 7;
            this.topLabel.Text = "Admin Dashboard";
            // 
            // serchtextBox
            // 
            this.serchtextBox.Location = new System.Drawing.Point(396, 195);
            this.serchtextBox.Name = "serchtextBox";
            this.serchtextBox.Size = new System.Drawing.Size(404, 22);
            this.serchtextBox.TabIndex = 8;
            // 
            // serchBtn
            // 
            this.serchBtn.Location = new System.Drawing.Point(1012, 193);
            this.serchBtn.Name = "serchBtn";
            this.serchBtn.Size = new System.Drawing.Size(171, 53);
            this.serchBtn.TabIndex = 9;
            this.serchBtn.Text = "Search";
            this.serchBtn.UseVisualStyleBackColor = true;
            this.serchBtn.Click += new System.EventHandler(this.serchBtnClk);
            // 
            // searchoptioncombobox
            // 
            this.searchoptioncombobox.FormattingEnabled = true;
            this.searchoptioncombobox.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Course"});
            this.searchoptioncombobox.Location = new System.Drawing.Point(828, 193);
            this.searchoptioncombobox.Name = "searchoptioncombobox";
            this.searchoptioncombobox.Size = new System.Drawing.Size(145, 24);
            this.searchoptioncombobox.TabIndex = 10;
            this.searchoptioncombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "Show Enrollments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showenrlclk);
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchoptioncombobox);
            this.Controls.Add(this.serchBtn);
            this.Controls.Add(this.serchtextBox);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.teachersBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.studentsBtn);
            this.Controls.Add(this.courseBtn);
            this.Controls.Add(this.noticeBtn);
            this.Name = "AdminDashBoard";
            this.Text = "AdminDashBoard";
            this.Click += new System.EventHandler(this.searchBtnClk);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button noticeBtn;
        private System.Windows.Forms.Button courseBtn;
        private System.Windows.Forms.Button studentsBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button teachersBtn;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.TextBox serchtextBox;
        private System.Windows.Forms.Button serchBtn;
        private System.Windows.Forms.ComboBox searchoptioncombobox;
        private System.Windows.Forms.Button button1;
    }
}