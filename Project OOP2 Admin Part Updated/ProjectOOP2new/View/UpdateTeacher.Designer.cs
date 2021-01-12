namespace ProjectOOP2new.View
{
    partial class UpdateTeacher
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
            this.utrsBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(63, 74);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(325, 50);
            this.topLabel.TabIndex = 35;
            this.topLabel.Text = "Update Teacher";
            // 
            // utrsBtn
            // 
            this.utrsBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utrsBtn.Location = new System.Drawing.Point(339, 291);
            this.utrsBtn.Name = "utrsBtn";
            this.utrsBtn.Size = new System.Drawing.Size(292, 39);
            this.utrsBtn.TabIndex = 39;
            this.utrsBtn.Text = "Update Teacher\' Name";
            this.utrsBtn.UseVisualStyleBackColor = true;
            this.utrsBtn.Click += new System.EventHandler(this.utrsnameBtnClk);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(800, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 39);
            this.button2.TabIndex = 40;
            this.button2.Text = "Update Teacher\' Designation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.utrsdesigBtnClk);
            // 
            // UpdateTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 570);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.utrsBtn);
            this.Controls.Add(this.topLabel);
            this.Name = "UpdateTeacher";
            this.Text = "UpdateTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button utrsBtn;
        private System.Windows.Forms.Button button2;
    }
}