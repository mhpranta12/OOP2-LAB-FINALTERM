namespace ProjectOOP2new.View
{
    partial class UpdateCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucrsBtn = new System.Windows.Forms.Button();
            this.crscdtextBox = new System.Windows.Forms.RichTextBox();
            this.ucrsnametextBox = new System.Windows.Forms.RichTextBox();
            this.ucrstrstextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(69, 83);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(360, 50);
            this.topLabel.TabIndex = 22;
            this.topLabel.Text = "📝 Update Course";
            this.topLabel.Click += new System.EventHandler(this.topLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Course\'s Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Updated Course\'s Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 640);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Updated Course Teacher";
            // 
            // ucrsBtn
            // 
            this.ucrsBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucrsBtn.Location = new System.Drawing.Point(735, 760);
            this.ucrsBtn.Name = "ucrsBtn";
            this.ucrsBtn.Size = new System.Drawing.Size(337, 44);
            this.ucrsBtn.TabIndex = 35;
            this.ucrsBtn.Text = "✏   Update Course";
            this.ucrsBtn.UseVisualStyleBackColor = true;
            this.ucrsBtn.Click += new System.EventHandler(this.ucrsBtnClk);
            // 
            // crscdtextBox
            // 
            this.crscdtextBox.Location = new System.Drawing.Point(735, 400);
            this.crscdtextBox.Name = "crscdtextBox";
            this.crscdtextBox.Size = new System.Drawing.Size(337, 48);
            this.crscdtextBox.TabIndex = 36;
            this.crscdtextBox.Text = "";
            // 
            // ucrsnametextBox
            // 
            this.ucrsnametextBox.Location = new System.Drawing.Point(735, 520);
            this.ucrsnametextBox.Name = "ucrsnametextBox";
            this.ucrsnametextBox.Size = new System.Drawing.Size(337, 44);
            this.ucrsnametextBox.TabIndex = 37;
            this.ucrsnametextBox.Text = "";
            // 
            // ucrstrstextBox
            // 
            this.ucrstrstextBox.Location = new System.Drawing.Point(735, 640);
            this.ucrstrstextBox.Name = "ucrstrstextBox";
            this.ucrstrstextBox.Size = new System.Drawing.Size(337, 46);
            this.ucrstrstextBox.TabIndex = 38;
            this.ucrstrstextBox.Text = "";
            // 
            // UpdateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1647, 1007);
            this.Controls.Add(this.ucrstrstextBox);
            this.Controls.Add(this.ucrsnametextBox);
            this.Controls.Add(this.crscdtextBox);
            this.Controls.Add(this.ucrsBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topLabel);
            this.Name = "UpdateCourse";
            this.Text = "UpdateCourse";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ucrsBtn;
        private System.Windows.Forms.RichTextBox crscdtextBox;
        private System.Windows.Forms.RichTextBox ucrsnametextBox;
        private System.Windows.Forms.RichTextBox ucrstrstextBox;
    }
}