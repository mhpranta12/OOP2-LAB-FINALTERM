namespace ProjectOOP2.View
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
            this.topLabel = new System.Windows.Forms.Label();
            this.seeAllTeacherBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(52, 52);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(171, 50);
            this.topLabel.TabIndex = 1;
            this.topLabel.Text = "Teachers";
            // 
            // seeAllTeacherBtn
            // 
            this.seeAllTeacherBtn.Location = new System.Drawing.Point(761, 207);
            this.seeAllTeacherBtn.Name = "seeAllTeacherBtn";
            this.seeAllTeacherBtn.Size = new System.Drawing.Size(275, 62);
            this.seeAllTeacherBtn.TabIndex = 4;
            this.seeAllTeacherBtn.Text = "View All Students";
            this.seeAllTeacherBtn.UseVisualStyleBackColor = true;
            this.seeAllTeacherBtn.Click += new System.EventHandler(this.viewstudentBtnClk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "View All Teachers";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 62);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 578);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seeAllTeacherBtn);
            this.Controls.Add(this.topLabel);
            this.Name = "Student";
            this.Text = "Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button seeAllTeacherBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}