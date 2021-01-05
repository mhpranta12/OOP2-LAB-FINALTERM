namespace ProjectOOP2new.View
{
    partial class AddNotice
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
            this.dttextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.addntcBtn = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dttextBox
            // 
            this.dttextBox.Location = new System.Drawing.Point(381, 378);
            this.dttextBox.Name = "dttextBox";
            this.dttextBox.Size = new System.Drawing.Size(499, 22);
            this.dttextBox.TabIndex = 26;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(381, 125);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(499, 183);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            // 
            // addntcBtn
            // 
            this.addntcBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addntcBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addntcBtn.Location = new System.Drawing.Point(381, 436);
            this.addntcBtn.Name = "addntcBtn";
            this.addntcBtn.Size = new System.Drawing.Size(499, 39);
            this.addntcBtn.TabIndex = 28;
            this.addntcBtn.Text = "Post";
            this.addntcBtn.UseVisualStyleBackColor = false;
            this.addntcBtn.Click += new System.EventHandler(this.addntcBtnClk);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(21, 20);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(238, 50);
            this.topLabel.TabIndex = 29;
            this.topLabel.Text = "Add Notice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Write Notice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Posting Date";
            // 
            // AddNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1335, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.addntcBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dttextBox);
            this.Name = "AddNotice";
            this.Text = "AddNotice";
            this.Load += new System.EventHandler(this.AddNotice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dttextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button addntcBtn;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}