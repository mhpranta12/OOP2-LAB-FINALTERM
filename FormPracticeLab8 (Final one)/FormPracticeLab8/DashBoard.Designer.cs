namespace FormPracticeLab8
{
    partial class DashBoard
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
            this.EditUser = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditUser
            // 
            this.EditUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EditUser.Location = new System.Drawing.Point(596, 230);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(193, 60);
            this.EditUser.TabIndex = 9;
            this.EditUser.Text = "Edit  User";
            this.EditUser.UseVisualStyleBackColor = false;
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddUser.Location = new System.Drawing.Point(253, 230);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(204, 60);
            this.AddUser.TabIndex = 8;
            this.AddUser.Text = "Add  User";
            this.AddUser.UseVisualStyleBackColor = false;
            this.AddUser.Click += new System.EventHandler(this.adduser);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 78);
            this.label1.TabIndex = 10;
            this.label1.Text = "DashBoard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditUser);
            this.Controls.Add(this.AddUser);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Label label1;
    }
}