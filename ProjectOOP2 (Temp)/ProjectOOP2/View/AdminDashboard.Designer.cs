namespace ProjectOOP2.View
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.topLabel = new System.Windows.Forms.Label();
            this.wcmsg = new System.Windows.Forms.Label();
            this.noticeBtn = new System.Windows.Forms.Button();
            this.courseBtn = new System.Windows.Forms.Button();
            this.asnBtn = new System.Windows.Forms.Button();
            this.recomndBtn = new System.Windows.Forms.Button();
            this.lgoutBtn = new System.Windows.Forms.Button();
            this.teacherBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Maiandra GD", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(32, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(387, 51);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Admin\'s Dashboard";
            // 
            // wcmsg
            // 
            this.wcmsg.AutoSize = true;
            this.wcmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wcmsg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.wcmsg.Location = new System.Drawing.Point(37, 86);
            this.wcmsg.Name = "wcmsg";
            this.wcmsg.Size = new System.Drawing.Size(206, 24);
            this.wcmsg.TabIndex = 1;
            this.wcmsg.Text = "Welcome to dashboard";
            // 
            // noticeBtn
            // 
            this.noticeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.noticeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("noticeBtn.BackgroundImage")));
            this.noticeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeBtn.Location = new System.Drawing.Point(41, 181);
            this.noticeBtn.Name = "noticeBtn";
            this.noticeBtn.Size = new System.Drawing.Size(232, 60);
            this.noticeBtn.TabIndex = 2;
            this.noticeBtn.Text = "Upload a Notice";
            this.noticeBtn.UseVisualStyleBackColor = false;
            // 
            // courseBtn
            // 
            this.courseBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.courseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("courseBtn.BackgroundImage")));
            this.courseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.courseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBtn.Location = new System.Drawing.Point(338, 181);
            this.courseBtn.Name = "courseBtn";
            this.courseBtn.Size = new System.Drawing.Size(232, 60);
            this.courseBtn.TabIndex = 3;
            this.courseBtn.Text = "Courses";
            this.courseBtn.UseVisualStyleBackColor = false;
            this.courseBtn.Click += new System.EventHandler(this.courseBtnClk);
            // 
            // asnBtn
            // 
            this.asnBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.asnBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("asnBtn.BackgroundImage")));
            this.asnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asnBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.asnBtn.Location = new System.Drawing.Point(646, 183);
            this.asnBtn.Name = "asnBtn";
            this.asnBtn.Size = new System.Drawing.Size(236, 57);
            this.asnBtn.TabIndex = 4;
            this.asnBtn.Text = "✎ Student";
            this.asnBtn.UseVisualStyleBackColor = false;
            this.asnBtn.Click += new System.EventHandler(this.stnBtnClk);
            // 
            // recomndBtn
            // 
            this.recomndBtn.BackColor = System.Drawing.Color.Ivory;
            this.recomndBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recomndBtn.BackgroundImage")));
            this.recomndBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recomndBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.recomndBtn.Location = new System.Drawing.Point(41, 294);
            this.recomndBtn.Name = "recomndBtn";
            this.recomndBtn.Size = new System.Drawing.Size(337, 57);
            this.recomndBtn.TabIndex = 5;
            this.recomndBtn.Text = "✒ Recommand for a Certificate ";
            this.recomndBtn.UseVisualStyleBackColor = false;
            this.recomndBtn.Click += new System.EventHandler(this.recomndBtn_Click);
            // 
            // lgoutBtn
            // 
            this.lgoutBtn.Location = new System.Drawing.Point(1143, 71);
            this.lgoutBtn.Name = "lgoutBtn";
            this.lgoutBtn.Size = new System.Drawing.Size(204, 39);
            this.lgoutBtn.TabIndex = 6;
            this.lgoutBtn.Text = "👉   Log Out";
            this.lgoutBtn.UseVisualStyleBackColor = true;
            this.lgoutBtn.Click += new System.EventHandler(this.lgoutBtnClk);
            // 
            // teacherBtn
            // 
            this.teacherBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teacherBtn.BackgroundImage")));
            this.teacherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.teacherBtn.Location = new System.Drawing.Point(966, 184);
            this.teacherBtn.Name = "teacherBtn";
            this.teacherBtn.Size = new System.Drawing.Size(209, 57);
            this.teacherBtn.TabIndex = 7;
            this.teacherBtn.Text = "Teacher";
            this.teacherBtn.UseVisualStyleBackColor = true;
            this.teacherBtn.Click += new System.EventHandler(this.teacherBtnClk);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1424, 573);
            this.Controls.Add(this.teacherBtn);
            this.Controls.Add(this.lgoutBtn);
            this.Controls.Add(this.recomndBtn);
            this.Controls.Add(this.asnBtn);
            this.Controls.Add(this.courseBtn);
            this.Controls.Add(this.noticeBtn);
            this.Controls.Add(this.wcmsg);
            this.Controls.Add(this.topLabel);
            this.Name = "AdminDashboard";
            this.Text = "TeacherDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label wcmsg;
        private System.Windows.Forms.Button noticeBtn;
        private System.Windows.Forms.Button courseBtn;
        private System.Windows.Forms.Button asnBtn;
        private System.Windows.Forms.Button recomndBtn;
        private System.Windows.Forms.Button lgoutBtn;
        private System.Windows.Forms.Button teacherBtn;
    }
}