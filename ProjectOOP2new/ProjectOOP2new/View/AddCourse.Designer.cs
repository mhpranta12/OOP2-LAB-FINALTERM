namespace ProjectOOP2new.View
{
    partial class AddCourse
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
            this.addcrsBtn = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.crsteachertextBox = new System.Windows.Forms.TextBox();
            this.crsnametextBox = new System.Windows.Forms.TextBox();
            this.crscodetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addcrsBtn
            // 
            this.addcrsBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcrsBtn.Location = new System.Drawing.Point(480, 322);
            this.addcrsBtn.Name = "addcrsBtn";
            this.addcrsBtn.Size = new System.Drawing.Size(292, 39);
            this.addcrsBtn.TabIndex = 16;
            this.addcrsBtn.Text = " Add   Course";
            this.addcrsBtn.UseVisualStyleBackColor = true;
            this.addcrsBtn.Click += new System.EventHandler(this.addteacherBtn);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(109, 21);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(281, 50);
            this.topLabel.TabIndex = 20;
            this.topLabel.Text = "Add Students";
            // 
            // crsteachertextBox
            // 
            this.crsteachertextBox.Location = new System.Drawing.Point(480, 255);
            this.crsteachertextBox.Name = "crsteachertextBox";
            this.crsteachertextBox.Size = new System.Drawing.Size(292, 22);
            this.crsteachertextBox.TabIndex = 24;
            // 
            // crsnametextBox
            // 
            this.crsnametextBox.Location = new System.Drawing.Point(480, 129);
            this.crsnametextBox.Name = "crsnametextBox";
            this.crsnametextBox.Size = new System.Drawing.Size(292, 22);
            this.crsnametextBox.TabIndex = 25;
            this.crsnametextBox.TextChanged += new System.EventHandler(this.crsnametextBox_TextChanged);
            // 
            // crscodetextBox
            // 
            this.crscodetextBox.Location = new System.Drawing.Point(480, 192);
            this.crscodetextBox.Name = "crscodetextBox";
            this.crscodetextBox.Size = new System.Drawing.Size(292, 22);
            this.crscodetextBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Course Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Course Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Course Teacher";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.crscodetextBox);
            this.Controls.Add(this.crsnametextBox);
            this.Controls.Add(this.crsteachertextBox);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.addcrsBtn);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addcrsBtn;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.TextBox crsteachertextBox;
        private System.Windows.Forms.TextBox crsnametextBox;
        private System.Windows.Forms.TextBox crscodetextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}