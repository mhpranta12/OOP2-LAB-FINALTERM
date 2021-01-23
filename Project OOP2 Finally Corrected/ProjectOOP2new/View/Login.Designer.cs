namespace ProjectOOP2new.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.topLabel = new System.Windows.Forms.Label();
            this.stdnloginBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.trsloginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(15, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(703, 50);
            this.topLabel.TabIndex = 7;
            this.topLabel.Text = "🎓 University Management System ";
            this.topLabel.Click += new System.EventHandler(this.topLabel_Click);
            // 
            // stdnloginBtn
            // 
            this.stdnloginBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.stdnloginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdnloginBtn.Location = new System.Drawing.Point(786, 595);
            this.stdnloginBtn.Name = "stdnloginBtn";
            this.stdnloginBtn.Size = new System.Drawing.Size(393, 55);
            this.stdnloginBtn.TabIndex = 40;
            this.stdnloginBtn.Text = "👔 Login As Student";
            this.stdnloginBtn.UseVisualStyleBackColor = false;
            this.stdnloginBtn.Click += new System.EventHandler(this.stdnloginBtnClk);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(297, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(393, 55);
            this.button1.TabIndex = 41;
            this.button1.Text = "📝 Login As Admin ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.adminloginBtnClk);
            // 
            // trsloginBtn
            // 
            this.trsloginBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.trsloginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trsloginBtn.Location = new System.Drawing.Point(1312, 595);
            this.trsloginBtn.Name = "trsloginBtn";
            this.trsloginBtn.Size = new System.Drawing.Size(393, 55);
            this.trsloginBtn.TabIndex = 42;
            this.trsloginBtn.Text = "💼 Login As Teacher";
            this.trsloginBtn.UseVisualStyleBackColor = false;
            this.trsloginBtn.Click += new System.EventHandler(this.trsloginBtnClk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Welcome To University Management System ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1057, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 36);
            this.label2.TabIndex = 44;
            this.label2.Text = "© Mehedi Hasan Pranta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(867, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 28);
            this.label3.TabIndex = 45;
            this.label3.Text = "Created By ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 699);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trsloginBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stdnloginBtn);
            this.Controls.Add(this.topLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button stdnloginBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button trsloginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}