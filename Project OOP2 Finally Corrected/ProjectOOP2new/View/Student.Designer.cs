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
            this.noticeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.noticeBtn.Location = new System.Drawing.Point(810, 350);
            this.noticeBtn.Name = "noticeBtn";
            this.noticeBtn.Size = new System.Drawing.Size(282, 58);
            this.noticeBtn.TabIndex = 1;
            this.noticeBtn.Text = "🖥 View All Students";
            this.noticeBtn.UseVisualStyleBackColor = false;
            this.noticeBtn.Click += new System.EventHandler(this.viewallstndBtnCLk);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Location = new System.Drawing.Point(460, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "✂ Remove a Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.dltstndBtnClk);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(110, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "✏ Add a Student";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.addstndBtnClk);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(100, 147);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(247, 50);
            this.topLabel.TabIndex = 8;
            this.topLabel.Text = "👔 Students";
            // 
            // uBtn
            // 
            this.uBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.uBtn.Location = new System.Drawing.Point(1160, 350);
            this.uBtn.Name = "uBtn";
            this.uBtn.Size = new System.Drawing.Size(282, 58);
            this.uBtn.TabIndex = 9;
            this.uBtn.Text = "📼 Update a Student";
            this.uBtn.UseVisualStyleBackColor = false;
            this.uBtn.Click += new System.EventHandler(this.uBtnClk);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1533, 605);
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