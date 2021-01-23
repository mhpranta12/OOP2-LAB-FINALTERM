namespace ProjectOOP2new.View
{
    partial class Delete_Teacher
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
            this.trsnametextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.Navy;
            this.topLabel.Location = new System.Drawing.Point(69, 56);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(437, 50);
            this.topLabel.TabIndex = 21;
            this.topLabel.Text = "✄💼 Remove Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "Teacher\'s ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dlttrsBtn
            // 
            this.dlttrsBtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlttrsBtn.Location = new System.Drawing.Point(530, 370);
            this.dlttrsBtn.Name = "dlttrsBtn";
            this.dlttrsBtn.Size = new System.Drawing.Size(325, 43);
            this.dlttrsBtn.TabIndex = 29;
            this.dlttrsBtn.Text = "Delete Teacher";
            this.dlttrsBtn.UseVisualStyleBackColor = true;
            this.dlttrsBtn.Click += new System.EventHandler(this.dlttrsBtnClk);
            // 
            // trsnametextBox
            // 
            this.trsnametextBox.Location = new System.Drawing.Point(530, 276);
            this.trsnametextBox.Name = "trsnametextBox";
            this.trsnametextBox.Size = new System.Drawing.Size(325, 39);
            this.trsnametextBox.TabIndex = 30;
            this.trsnametextBox.Text = "";
            // 
            // Delete_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1366, 548);
            this.Controls.Add(this.trsnametextBox);
            this.Controls.Add(this.dlttrsBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.topLabel);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "Delete_Teacher";
            this.Text = "Delete_Teacher";
            this.Load += new System.EventHandler(this.Delete_Teacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dlttrsBtn;
        private System.Windows.Forms.RichTextBox trsnametextBox;
    }
}