namespace ProjectOOP2.View
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.topLabel = new System.Windows.Forms.Label();
            this.addTeacherBtn = new System.Windows.Forms.Button();
            this.deleteTeacherBtn = new System.Windows.Forms.Button();
            this.seeAllTeacherBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(38, 28);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(171, 50);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Teachers";
            this.topLabel.Click += new System.EventHandler(this.topLabel_Click);
            // 
            // addTeacherBtn
            // 
            this.addTeacherBtn.Location = new System.Drawing.Point(180, 189);
            this.addTeacherBtn.Name = "addTeacherBtn";
            this.addTeacherBtn.Size = new System.Drawing.Size(153, 62);
            this.addTeacherBtn.TabIndex = 1;
            this.addTeacherBtn.Text = "Add a Teacher";
            this.addTeacherBtn.UseVisualStyleBackColor = true;
            this.addTeacherBtn.Click += new System.EventHandler(this.addnewteacherbtnClk);
            // 
            // deleteTeacherBtn
            // 
            this.deleteTeacherBtn.Location = new System.Drawing.Point(441, 189);
            this.deleteTeacherBtn.Name = "deleteTeacherBtn";
            this.deleteTeacherBtn.Size = new System.Drawing.Size(167, 60);
            this.deleteTeacherBtn.TabIndex = 2;
            this.deleteTeacherBtn.Text = "Delete a Teacher";
            this.deleteTeacherBtn.UseVisualStyleBackColor = true;
            // 
            // seeAllTeacherBtn
            // 
            this.seeAllTeacherBtn.Location = new System.Drawing.Point(705, 189);
            this.seeAllTeacherBtn.Name = "seeAllTeacherBtn";
            this.seeAllTeacherBtn.Size = new System.Drawing.Size(275, 62);
            this.seeAllTeacherBtn.TabIndex = 3;
            this.seeAllTeacherBtn.Text = "View All Teachers";
            this.seeAllTeacherBtn.UseVisualStyleBackColor = true;
            this.seeAllTeacherBtn.Click += new System.EventHandler(this.viewAllTeacherBtnClk);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1323, 557);
            this.Controls.Add(this.seeAllTeacherBtn);
            this.Controls.Add(this.deleteTeacherBtn);
            this.Controls.Add(this.addTeacherBtn);
            this.Controls.Add(this.topLabel);
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button addTeacherBtn;
        private System.Windows.Forms.Button deleteTeacherBtn;
        private System.Windows.Forms.Button seeAllTeacherBtn;
    }
}