﻿namespace ProjectOOP2new.View
{
    partial class AddTeacher
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
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.desigtextBox = new System.Windows.Forms.TextBox();
            this.agetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addteacherBtn = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(436, 145);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(292, 22);
            this.nametextBox.TabIndex = 6;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(436, 200);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(292, 22);
            this.passwordtextBox.TabIndex = 7;
            // 
            // desigtextBox
            // 
            this.desigtextBox.Location = new System.Drawing.Point(436, 250);
            this.desigtextBox.Name = "desigtextBox";
            this.desigtextBox.Size = new System.Drawing.Size(292, 22);
            this.desigtextBox.TabIndex = 8;
            // 
            // agetextBox
            // 
            this.agetextBox.Location = new System.Drawing.Point(436, 306);
            this.agetextBox.Name = "agetextBox";
            this.agetextBox.Size = new System.Drawing.Size(292, 22);
            this.agetextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Designation";
            // 
            // addteacherBtn
            // 
            this.addteacherBtn.Location = new System.Drawing.Point(436, 358);
            this.addteacherBtn.Name = "addteacherBtn";
            this.addteacherBtn.Size = new System.Drawing.Size(292, 39);
            this.addteacherBtn.TabIndex = 14;
            this.addteacherBtn.Text = "Add a Teacher";
            this.addteacherBtn.UseVisualStyleBackColor = true;
            this.addteacherBtn.Click += new System.EventHandler(this.addteacherBtnClk);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(48, 27);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(286, 50);
            this.topLabel.TabIndex = 20;
            this.topLabel.Text = "Add Teachers";
            this.topLabel.Click += new System.EventHandler(this.topLabel_Click);
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 533);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.addteacherBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agetextBox);
            this.Controls.Add(this.desigtextBox);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.nametextBox);
            this.Name = "AddTeacher";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox desigtextBox;
        private System.Windows.Forms.TextBox agetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addteacherBtn;
        private System.Windows.Forms.Label topLabel;
    }
}