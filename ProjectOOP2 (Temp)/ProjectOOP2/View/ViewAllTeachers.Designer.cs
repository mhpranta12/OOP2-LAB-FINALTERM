namespace ProjectOOP2.View
{
    partial class ViewAllTeachers
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
            this.dataGridViewTeacherList = new System.Windows.Forms.DataGridView();
            this.viewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherList)).BeginInit();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(32, 19);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(259, 50);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Teachers List";
            // 
            // dataGridViewTeacherList
            // 
            this.dataGridViewTeacherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacherList.Location = new System.Drawing.Point(364, 49);
            this.dataGridViewTeacherList.Name = "dataGridViewTeacherList";
            this.dataGridViewTeacherList.RowHeadersWidth = 51;
            this.dataGridViewTeacherList.RowTemplate.Height = 24;
            this.dataGridViewTeacherList.Size = new System.Drawing.Size(981, 473);
            this.dataGridViewTeacherList.TabIndex = 1;
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(58, 139);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(213, 52);
            this.viewBtn.TabIndex = 2;
            this.viewBtn.Text = "View All  Teachers";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtnClk);
            // 
            // ViewAllTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 555);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.dataGridViewTeacherList);
            this.Controls.Add(this.topLabel);
            this.Name = "ViewAllTeachers";
            this.Text = "ViewAllTeachers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.DataGridView dataGridViewTeacherList;
        private System.Windows.Forms.Button viewBtn;
    }
}