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
            this.serchBtn = new System.Windows.Forms.Button();
            this.searchoptioncombobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serchtextBox = new System.Windows.Forms.RichTextBox();
            this.category = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noticeBtn
            // 
            this.noticeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.noticeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeBtn.Location = new System.Drawing.Point(280, 444);
            this.noticeBtn.Name = "noticeBtn";
            this.noticeBtn.Size = new System.Drawing.Size(300, 60);
            this.noticeBtn.TabIndex = 0;
            this.noticeBtn.Text = "📅 Notices";
            this.noticeBtn.UseVisualStyleBackColor = false;
            this.noticeBtn.Click += new System.EventHandler(this.noticeBtnClk);
            // 
            // courseBtn
            // 
            this.courseBtn.BackColor = System.Drawing.SystemColors.Info;
            this.courseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBtn.Location = new System.Drawing.Point(1390, 444);
            this.courseBtn.Name = "courseBtn";
            this.courseBtn.Size = new System.Drawing.Size(300, 60);
            this.courseBtn.TabIndex = 1;
            this.courseBtn.Text = "🖋⌨ Courses";
            this.courseBtn.UseVisualStyleBackColor = false;
            this.courseBtn.Click += new System.EventHandler(this.coursesBtnClk);
            // 
            // studentsBtn
            // 
            this.studentsBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.studentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsBtn.Location = new System.Drawing.Point(650, 444);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(300, 60);
            this.studentsBtn.TabIndex = 2;
            this.studentsBtn.Text = "👔 Students";
            this.studentsBtn.UseVisualStyleBackColor = false;
            this.studentsBtn.Click += new System.EventHandler(this.stnBtnCLk);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(1477, 71);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(126, 43);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Log Out 👉";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // teachersBtn
            // 
            this.teachersBtn.BackColor = System.Drawing.Color.Aquamarine;
            this.teachersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachersBtn.Location = new System.Drawing.Point(1020, 444);
            this.teachersBtn.Name = "teachersBtn";
            this.teachersBtn.Size = new System.Drawing.Size(300, 60);
            this.teachersBtn.TabIndex = 4;
            this.teachersBtn.Text = "👔 Teachers";
            this.teachersBtn.UseVisualStyleBackColor = false;
            this.teachersBtn.Click += new System.EventHandler(this.teachersBtn_Click);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(107, 64);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(439, 50);
            this.topLabel.TabIndex = 7;
            this.topLabel.Text = "🖋 Admin Dashboard";
            // 
            // serchBtn
            // 
            this.serchBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.serchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serchBtn.Location = new System.Drawing.Point(1076, 287);
            this.serchBtn.Name = "serchBtn";
            this.serchBtn.Size = new System.Drawing.Size(171, 53);
            this.serchBtn.TabIndex = 9;
            this.serchBtn.Text = "🔍 Search";
            this.serchBtn.UseVisualStyleBackColor = false;
            this.serchBtn.Click += new System.EventHandler(this.serchBtnClk);
            // 
            // searchoptioncombobox
            // 
            this.searchoptioncombobox.FormattingEnabled = true;
            this.searchoptioncombobox.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Course"});
            this.searchoptioncombobox.Location = new System.Drawing.Point(848, 287);
            this.searchoptioncombobox.Name = "searchoptioncombobox";
            this.searchoptioncombobox.Size = new System.Drawing.Size(159, 24);
            this.searchoptioncombobox.TabIndex = 10;
            this.searchoptioncombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(280, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 60);
            this.button1.TabIndex = 11;
            this.button1.Text = "💼 Show Enrollments";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.showenrlclk);
            // 
            // serchtextBox
            // 
            this.serchtextBox.Location = new System.Drawing.Point(360, 287);
            this.serchtextBox.Name = "serchtextBox";
            this.serchtextBox.Size = new System.Drawing.Size(439, 38);
            this.serchtextBox.TabIndex = 12;
            this.serchtextBox.Text = "";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(842, 236);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(112, 31);
            this.category.TabIndex = 13;
            this.category.Text = "Category";
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1804, 948);
            this.Controls.Add(this.category);
            this.Controls.Add(this.serchtextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchoptioncombobox);
            this.Controls.Add(this.serchBtn);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.teachersBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.studentsBtn);
            this.Controls.Add(this.courseBtn);
            this.Controls.Add(this.noticeBtn);
            this.Name = "AdminDashBoard";
            this.Text = "AdminDashBoard";
            this.Click += new System.EventHandler(this.searchBtnClk);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.canvaspaint);
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
        private System.Windows.Forms.Button serchBtn;
        private System.Windows.Forms.ComboBox searchoptioncombobox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox serchtextBox;
        private System.Windows.Forms.Label category;
    }
}