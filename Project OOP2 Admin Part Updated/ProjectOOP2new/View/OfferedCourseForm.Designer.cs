namespace ProjectOOP2new.View
{
    partial class OfferedCourseForm
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
            this.addcoursesBtn = new System.Windows.Forms.Button();
            this.viewallcrsBtn = new System.Windows.Forms.Button();
            this.capacity = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(55, 35);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(167, 50);
            this.topLabel.TabIndex = 9;
            this.topLabel.Text = "Courses";
            // 
            // addcoursesBtn
            // 
            this.addcoursesBtn.Location = new System.Drawing.Point(269, 422);
            this.addcoursesBtn.Name = "addcoursesBtn";
            this.addcoursesBtn.Size = new System.Drawing.Size(292, 39);
            this.addcoursesBtn.TabIndex = 10;
            this.addcoursesBtn.Text = "Add OfferedCourse";
            this.addcoursesBtn.UseVisualStyleBackColor = true;
            this.addcoursesBtn.Click += new System.EventHandler(this.addofrdcourseclk);
            // 
            // viewallcrsBtn
            // 
            this.viewallcrsBtn.Location = new System.Drawing.Point(748, 439);
            this.viewallcrsBtn.Name = "viewallcrsBtn";
            this.viewallcrsBtn.Size = new System.Drawing.Size(139, 39);
            this.viewallcrsBtn.TabIndex = 12;
            this.viewallcrsBtn.Text = "View All Courses";
            this.viewallcrsBtn.UseVisualStyleBackColor = true;
            this.viewallcrsBtn.Click += new System.EventHandler(this.viewallcrsBtn_Click);
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(269, 308);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(292, 22);
            this.capacity.TabIndex = 26;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(269, 152);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(292, 22);
            this.name.TabIndex = 27;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(269, 211);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(292, 22);
            this.code.TabIndex = 28;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(269, 263);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(292, 22);
            this.type.TabIndex = 29;
            this.type.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(269, 355);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(292, 22);
            this.count.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Course Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Course Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Course Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("NSimSun", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Count";
            // 
            // OfferedCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 548);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.count);
            this.Controls.Add(this.type);
            this.Controls.Add(this.code);
            this.Controls.Add(this.name);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.viewallcrsBtn);
            this.Controls.Add(this.addcoursesBtn);
            this.Controls.Add(this.topLabel);
            this.Name = "OfferedCourseForm";
            this.Text = "OfferedCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button addcoursesBtn;
        private System.Windows.Forms.Button viewallcrsBtn;
        private System.Windows.Forms.TextBox capacity;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}