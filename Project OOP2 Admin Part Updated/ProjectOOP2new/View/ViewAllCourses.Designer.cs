namespace ProjectOOP2new.View
{
    partial class ViewAllCourses
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
            this.dataGridViewcourses = new System.Windows.Forms.DataGridView();
            this.topLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewcourses
            // 
            this.dataGridViewcourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcourses.Location = new System.Drawing.Point(496, 123);
            this.dataGridViewcourses.Name = "dataGridViewcourses";
            this.dataGridViewcourses.RowHeadersWidth = 51;
            this.dataGridViewcourses.RowTemplate.Height = 24;
            this.dataGridViewcourses.Size = new System.Drawing.Size(768, 438);
            this.dataGridViewcourses.TabIndex = 22;
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(59, 25);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(259, 50);
            this.topLabel.TabIndex = 23;
            this.topLabel.Text = "Courses List";
            // 
            // ViewAllCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 586);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.dataGridViewcourses);
            this.Name = "ViewAllCourses";
            this.Text = "ShowAllCourse";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewcourses;
        private System.Windows.Forms.Label topLabel;
    }
}