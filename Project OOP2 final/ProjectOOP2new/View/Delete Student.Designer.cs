namespace ProjectOOP2new.View
{
    partial class Delete_Student
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
            this.label3 = new System.Windows.Forms.Label();
            this.dlttrsBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(47, 29);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(345, 50);
            this.topLabel.TabIndex = 22;
            this.topLabel.Text = "Remove  Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Student\'s  ID ";
            // 
            // dlttrsBtn
            // 
            this.dlttrsBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.dlttrsBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlttrsBtn.Location = new System.Drawing.Point(538, 417);
            this.dlttrsBtn.Name = "dlttrsBtn";
            this.dlttrsBtn.Size = new System.Drawing.Size(348, 46);
            this.dlttrsBtn.TabIndex = 30;
            this.dlttrsBtn.Text = "Delete Student";
            this.dlttrsBtn.UseVisualStyleBackColor = false;
            this.dlttrsBtn.Click += new System.EventHandler(this.dltstndBtnClk);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox1.Location = new System.Drawing.Point(538, 312);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 38);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "";
            // 
            // Delete_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1380, 565);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dlttrsBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.topLabel);
            this.Name = "Delete_Student";
            this.Text = "Delete_Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dlttrsBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}