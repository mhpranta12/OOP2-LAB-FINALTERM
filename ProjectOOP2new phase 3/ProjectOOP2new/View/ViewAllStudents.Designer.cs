namespace ProjectOOP2new.View
{
    partial class ViewAllStudents
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
            this.dataGridViewstudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudents)).BeginInit();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(56, 39);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(280, 50);
            this.topLabel.TabIndex = 20;
            this.topLabel.Text = "Students List";
            // 
            // dataGridViewstudents
            // 
            this.dataGridViewstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewstudents.Location = new System.Drawing.Point(386, 100);
            this.dataGridViewstudents.Name = "dataGridViewstudents";
            this.dataGridViewstudents.RowHeadersWidth = 51;
            this.dataGridViewstudents.RowTemplate.Height = 24;
            this.dataGridViewstudents.Size = new System.Drawing.Size(768, 438);
            this.dataGridViewstudents.TabIndex = 21;
            this.dataGridViewstudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewstudents_CellContentClick);
            // 
            // ShowAllStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 550);
            this.Controls.Add(this.dataGridViewstudents);
            this.Controls.Add(this.topLabel);
            this.Name = "ShowAllStudent";
            this.Text = "ShowAllStudent";
            this.Load += new System.EventHandler(this.ShowAllStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.DataGridView dataGridViewstudents;
    }
}