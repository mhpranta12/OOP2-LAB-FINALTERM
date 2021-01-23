namespace ProjectOOP2new.View
{
    partial class StudentDashboard
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
            this.topLabel = new System.Windows.Forms.Label();
            this.noticeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.Label();
            this.unametextBox = new System.Windows.Forms.RichTextBox();
            this.offeredcourseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(58, 25);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(455, 50);
            this.topLabel.TabIndex = 8;
            this.topLabel.Text = "🎓 Student Dashboard";
            // 
            // noticeBtn
            // 
            this.noticeBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.noticeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeBtn.Location = new System.Drawing.Point(435, 424);
            this.noticeBtn.Name = "noticeBtn";
            this.noticeBtn.Size = new System.Drawing.Size(315, 53);
            this.noticeBtn.TabIndex = 41;
            this.noticeBtn.Text = "Notices  ✉";
            this.noticeBtn.UseVisualStyleBackColor = false;
            this.noticeBtn.Click += new System.EventHandler(this.noticeBtnClk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 34);
            this.label1.TabIndex = 42;
            this.label1.Text = "Welcome 👋 ,";
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(803, 116);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(192, 34);
            this.uname.TabIndex = 43;
            this.uname.Text = "StudentName";
            this.uname.Visible = false;
            this.uname.Click += new System.EventHandler(this.uname_Click);
            // 
            // unametextBox
            // 
            this.unametextBox.BackColor = System.Drawing.SystemColors.Control;
            this.unametextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.unametextBox.Location = new System.Drawing.Point(311, 208);
            this.unametextBox.Name = "unametextBox";
            this.unametextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.unametextBox.Size = new System.Drawing.Size(253, 34);
            this.unametextBox.TabIndex = 44;
            this.unametextBox.Text = "";
            this.unametextBox.Visible = false;
            this.unametextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // offeredcourseBtn
            // 
            this.offeredcourseBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.offeredcourseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offeredcourseBtn.Location = new System.Drawing.Point(862, 424);
            this.offeredcourseBtn.Name = "offeredcourseBtn";
            this.offeredcourseBtn.Size = new System.Drawing.Size(315, 53);
            this.offeredcourseBtn.TabIndex = 45;
            this.offeredcourseBtn.Text = "Offered Courses  💼";
            this.offeredcourseBtn.UseVisualStyleBackColor = false;
            this.offeredcourseBtn.Click += new System.EventHandler(this.offeredcourseBtnClk);
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1679, 797);
            this.Controls.Add(this.offeredcourseBtn);
            this.Controls.Add(this.unametextBox);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noticeBtn);
            this.Controls.Add(this.topLabel);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.canvaspaint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button noticeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.RichTextBox unametextBox;
        private System.Windows.Forms.Button offeredcourseBtn;
    }
}