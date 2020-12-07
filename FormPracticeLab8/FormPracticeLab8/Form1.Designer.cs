namespace FormPracticeLab8
{
    partial class Form1
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
            this.loginpagelabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.AddUser = new System.Windows.Forms.Button();
            this.EditUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginpagelabel
            // 
            this.loginpagelabel.AutoSize = true;
            this.loginpagelabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginpagelabel.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginpagelabel.Location = new System.Drawing.Point(319, 25);
            this.loginpagelabel.Name = "loginpagelabel";
            this.loginpagelabel.Size = new System.Drawing.Size(213, 50);
            this.loginpagelabel.TabIndex = 0;
            this.loginpagelabel.Text = "Login Page";
            this.loginpagelabel.Click += new System.EventHandler(this.loginpagelabel_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(33, 127);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(73, 17);
            this.name.TabIndex = 1;
            this.name.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(37, 190);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(69, 17);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(128, 250);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(306, 48);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.Text = "login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(128, 122);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(306, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(128, 190);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(306, 22);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddUser.Location = new System.Drawing.Point(128, 331);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(204, 60);
            this.AddUser.TabIndex = 6;
            this.AddUser.Text = "Add  User";
            this.AddUser.UseVisualStyleBackColor = false;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // EditUser
            // 
            this.EditUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.EditUser.Location = new System.Drawing.Point(376, 331);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(193, 60);
            this.EditUser.TabIndex = 7;
            this.EditUser.Text = "Edit  User";
            this.EditUser.UseVisualStyleBackColor = false;
            this.EditUser.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.EditUser);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.loginpagelabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginpagelabel;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button EditUser;
    }
}

