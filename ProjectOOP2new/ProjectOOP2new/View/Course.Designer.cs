namespace ProjectOOP2new.View
{
    partial class Course
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
            this.addcoursesBtn = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.viewallcrsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addcoursesBtn
            // 
            this.addcoursesBtn.Location = new System.Drawing.Point(197, 195);
            this.addcoursesBtn.Name = "addcoursesBtn";
            this.addcoursesBtn.Size = new System.Drawing.Size(139, 39);
            this.addcoursesBtn.TabIndex = 1;
            this.addcoursesBtn.Text = "Add Course";
            this.addcoursesBtn.UseVisualStyleBackColor = true;
            this.addcoursesBtn.Click += new System.EventHandler(this.addcoursesBtnClk);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(49, 47);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(160, 48);
            this.topLabel.TabIndex = 8;
            this.topLabel.Text = "Courses";
            this.topLabel.Click += new System.EventHandler(this.topLabel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete Course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "Update Course";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // viewallcrsBtn
            // 
            this.viewallcrsBtn.Location = new System.Drawing.Point(822, 195);
            this.viewallcrsBtn.Name = "viewallcrsBtn";
            this.viewallcrsBtn.Size = new System.Drawing.Size(139, 39);
            this.viewallcrsBtn.TabIndex = 11;
            this.viewallcrsBtn.Text = "View All Courses";
            this.viewallcrsBtn.UseVisualStyleBackColor = true;
            this.viewallcrsBtn.Click += new System.EventHandler(this.viewallcrsBtnCLk);
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 545);
            this.Controls.Add(this.viewallcrsBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.addcoursesBtn);
            this.Name = "Course";
            this.Text = "Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addcoursesBtn;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button viewallcrsBtn;
    }
}