namespace ProjectOOP2new.View
{
    partial class UpdateStudent
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
            this.sidtextBox = new System.Windows.Forms.TextBox();
            this.unametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.upstuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(95, 64);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(337, 50);
            this.topLabel.TabIndex = 22;
            this.topLabel.Text = "Update Students";
            this.topLabel.Click += new System.EventHandler(this.topLabel_Click);
            // 
            // sidtextBox
            // 
            this.sidtextBox.Location = new System.Drawing.Point(582, 260);
            this.sidtextBox.Name = "sidtextBox";
            this.sidtextBox.Size = new System.Drawing.Size(292, 22);
            this.sidtextBox.TabIndex = 27;
            this.sidtextBox.TextChanged += new System.EventHandler(this.sidtextBox_TextChanged);
            // 
            // unametextBox
            // 
            this.unametextBox.Location = new System.Drawing.Point(582, 365);
            this.unametextBox.Name = "unametextBox";
            this.unametextBox.Size = new System.Drawing.Size(292, 22);
            this.unametextBox.TabIndex = 28;
            this.unametextBox.TextChanged += new System.EventHandler(this.unametextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Student SID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Update Name";
            // 
            // upstuBtn
            // 
            this.upstuBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upstuBtn.Location = new System.Drawing.Point(582, 459);
            this.upstuBtn.Name = "upstuBtn";
            this.upstuBtn.Size = new System.Drawing.Size(292, 39);
            this.upstuBtn.TabIndex = 35;
            this.upstuBtn.Text = "Update Student\'s Info";
            this.upstuBtn.UseVisualStyleBackColor = true;
            this.upstuBtn.Click += new System.EventHandler(this.upstuBtnClk);
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 580);
            this.Controls.Add(this.upstuBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unametextBox);
            this.Controls.Add(this.sidtextBox);
            this.Controls.Add(this.topLabel);
            this.Name = "UpdateStudent";
            this.Text = "UpdateStudent";
            this.Load += new System.EventHandler(this.UpdateStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.TextBox sidtextBox;
        private System.Windows.Forms.TextBox unametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button upstuBtn;
    }
}