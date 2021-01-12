namespace ProjectOOP2new.View
{
    partial class AddStudent
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
            this.addteacherBtn = new System.Windows.Forms.Button();
            this.pwdtextBox = new System.Windows.Forms.TextBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.sidtextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addteacherBtn
            // 
            this.addteacherBtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addteacherBtn.Location = new System.Drawing.Point(511, 280);
            this.addteacherBtn.Name = "addteacherBtn";
            this.addteacherBtn.Size = new System.Drawing.Size(292, 39);
            this.addteacherBtn.TabIndex = 15;
            this.addteacherBtn.Text = " Add     Student";
            this.addteacherBtn.UseVisualStyleBackColor = true;
            this.addteacherBtn.Click += new System.EventHandler(this.addstdnBtn_Click);
            // 
            // pwdtextBox
            // 
            this.pwdtextBox.Location = new System.Drawing.Point(511, 218);
            this.pwdtextBox.Name = "pwdtextBox";
            this.pwdtextBox.Size = new System.Drawing.Size(292, 22);
            this.pwdtextBox.TabIndex = 16;
            this.pwdtextBox.TextChanged += new System.EventHandler(this.nametextBox_TextChanged);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(43, 26);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(281, 50);
            this.topLabel.TabIndex = 19;
            this.topLabel.Text = "Add Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Student ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(511, 120);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(292, 22);
            this.nametextBox.TabIndex = 23;
            this.nametextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // sidtextBox
            // 
            this.sidtextBox.Location = new System.Drawing.Point(511, 169);
            this.sidtextBox.Name = "sidtextBox";
            this.sidtextBox.Size = new System.Drawing.Size(292, 22);
            this.sidtextBox.TabIndex = 24;
            this.sidtextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(942, 190);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(148, 50);
            this.countTextBox.TabIndex = 25;
            this.countTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(942, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 39);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add a Enrollment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.baddenrlclk);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.sidtextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.pwdtextBox);
            this.Controls.Add(this.addteacherBtn);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addteacherBtn;
        private System.Windows.Forms.TextBox pwdtextBox;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox sidtextBox;
        private System.Windows.Forms.RichTextBox countTextBox;
        private System.Windows.Forms.Button button1;
    }
}