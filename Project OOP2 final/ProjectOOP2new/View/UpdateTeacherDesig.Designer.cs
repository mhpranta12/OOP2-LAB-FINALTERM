namespace ProjectOOP2new.View
{
    partial class UpdateTeacherDesig
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
            this.label2 = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.desigcomboBox = new System.Windows.Forms.ComboBox();
            this.trsnametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.utrsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Update Designation";
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(43, 38);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(598, 50);
            this.topLabel.TabIndex = 34;
            this.topLabel.Text = "Update Teacher\'s Designation";
            // 
            // desigcomboBox
            // 
            this.desigcomboBox.FormattingEnabled = true;
            this.desigcomboBox.Items.AddRange(new object[] {
            "Lecturer",
            "Senior Lecturer",
            "Assistant Professor",
            "Senior Assistant Professor",
            "Associate Professor",
            "Professor",
            "Pro VC",
            "VC"});
            this.desigcomboBox.Location = new System.Drawing.Point(602, 307);
            this.desigcomboBox.Name = "desigcomboBox";
            this.desigcomboBox.Size = new System.Drawing.Size(292, 24);
            this.desigcomboBox.TabIndex = 35;
            // 
            // trsnametextBox
            // 
            this.trsnametextBox.Location = new System.Drawing.Point(602, 234);
            this.trsnametextBox.Name = "trsnametextBox";
            this.trsnametextBox.Size = new System.Drawing.Size(292, 22);
            this.trsnametextBox.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Teacher\'s Name";
            // 
            // utrsBtn
            // 
            this.utrsBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utrsBtn.Location = new System.Drawing.Point(602, 386);
            this.utrsBtn.Name = "utrsBtn";
            this.utrsBtn.Size = new System.Drawing.Size(292, 39);
            this.utrsBtn.TabIndex = 38;
            this.utrsBtn.Text = "Update Teacher\' Designation";
            this.utrsBtn.UseVisualStyleBackColor = true;
            this.utrsBtn.Click += new System.EventHandler(this.utradesigBtnClk);
            // 
            // UpdateTeacherDesig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 561);
            this.Controls.Add(this.utrsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trsnametextBox);
            this.Controls.Add(this.desigcomboBox);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.label2);
            this.Name = "UpdateTeacherDesig";
            this.Text = "UpdateTeacherDesig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.ComboBox desigcomboBox;
        private System.Windows.Forms.TextBox trsnametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button utrsBtn;
    }
}