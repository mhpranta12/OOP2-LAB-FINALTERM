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
            this.trsnametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dlttrsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(69, 56);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(338, 50);
            this.topLabel.TabIndex = 21;
            this.topLabel.Text = "Remove Teacher";
            // 
            // trsnametextBox
            // 
            this.trsnametextBox.Location = new System.Drawing.Point(530, 189);
            this.trsnametextBox.Name = "trsnametextBox";
            this.trsnametextBox.Size = new System.Drawing.Size(292, 22);
            this.trsnametextBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Teacher\'s Name";
            // 
            // dlttrsBtn
            // 
            this.dlttrsBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlttrsBtn.Location = new System.Drawing.Point(530, 272);
            this.dlttrsBtn.Name = "dlttrsBtn";
            this.dlttrsBtn.Size = new System.Drawing.Size(292, 39);
            this.dlttrsBtn.TabIndex = 29;
            this.dlttrsBtn.Text = "Delete Teacher";
            this.dlttrsBtn.UseVisualStyleBackColor = true;
            this.dlttrsBtn.Click += new System.EventHandler(this.dlttrsBtnClk);
            // 
            // Delete_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 548);
            this.Controls.Add(this.dlttrsBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trsnametextBox);
            this.Controls.Add(this.topLabel);
            this.Name = "Delete_Teacher";
            this.Text = "Delete_Teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.TextBox trsnametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dlttrsBtn;
    }
}