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
            this.ucrsBtn = new System.Windows.Forms.Button();
            this.viewallcrsBtn = new System.Windows.Forms.Button();
            this.assncrstrsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addcoursesBtn
            // 
            this.addcoursesBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addcoursesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcoursesBtn.Location = new System.Drawing.Point(109, 268);
            this.addcoursesBtn.Name = "addcoursesBtn";
            this.addcoursesBtn.Size = new System.Drawing.Size(230, 47);
            this.addcoursesBtn.TabIndex = 1;
            this.addcoursesBtn.Text = "Add Course";
            this.addcoursesBtn.UseVisualStyleBackColor = false;
            this.addcoursesBtn.Click += new System.EventHandler(this.addcoursesBtnClk);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.topLabel.Location = new System.Drawing.Point(100, 81);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(228, 50);
            this.topLabel.TabIndex = 8;
            this.topLabel.Text = "🔖 Courses";
            this.topLabel.Click += new System.EventHandler(this.topLabel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(400, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete Course";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.dltcrsBtnClk);
            // 
            // ucrsBtn
            // 
            this.ucrsBtn.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ucrsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucrsBtn.Location = new System.Drawing.Point(700, 268);
            this.ucrsBtn.Name = "ucrsBtn";
            this.ucrsBtn.Size = new System.Drawing.Size(230, 47);
            this.ucrsBtn.TabIndex = 10;
            this.ucrsBtn.Text = "Update Course";
            this.ucrsBtn.UseVisualStyleBackColor = false;
            this.ucrsBtn.Click += new System.EventHandler(this.ucrsBtnClk);
            // 
            // viewallcrsBtn
            // 
            this.viewallcrsBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.viewallcrsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewallcrsBtn.Location = new System.Drawing.Point(1000, 268);
            this.viewallcrsBtn.Name = "viewallcrsBtn";
            this.viewallcrsBtn.Size = new System.Drawing.Size(230, 47);
            this.viewallcrsBtn.TabIndex = 11;
            this.viewallcrsBtn.Text = "View All Courses";
            this.viewallcrsBtn.UseVisualStyleBackColor = false;
            this.viewallcrsBtn.Click += new System.EventHandler(this.viewallcrsBtnCLk);
            // 
            // assncrstrsBtn
            // 
            this.assncrstrsBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.assncrstrsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assncrstrsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.assncrstrsBtn.Location = new System.Drawing.Point(109, 375);
            this.assncrstrsBtn.Name = "assncrstrsBtn";
            this.assncrstrsBtn.Size = new System.Drawing.Size(230, 47);
            this.assncrstrsBtn.TabIndex = 12;
            this.assncrstrsBtn.Text = "Add Offered Course";
            this.assncrstrsBtn.UseVisualStyleBackColor = false;
            this.assncrstrsBtn.Click += new System.EventHandler(this.assnofrscrstrsBtnClk);
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1392, 603);
            this.Controls.Add(this.assncrstrsBtn);
            this.Controls.Add(this.viewallcrsBtn);
            this.Controls.Add(this.ucrsBtn);
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
        private System.Windows.Forms.Button ucrsBtn;
        private System.Windows.Forms.Button viewallcrsBtn;
        private System.Windows.Forms.Button assncrstrsBtn;
    }
}