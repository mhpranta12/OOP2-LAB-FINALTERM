namespace Assignment_new
{
    partial class AllBooks
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.found = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.rT1 = new System.Windows.Forms.RichTextBox();
            this.rT2 = new System.Windows.Forms.RichTextBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rT3 = new System.Windows.Forms.RichTextBox();
            this.namel = new System.Windows.Forms.Label();
            this.authorl = new System.Windows.Forms.Label();
            this.editionl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(654, 94);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(757, 471);
            this.dataGridView.TabIndex = 2;
            // 
            // found
            // 
            this.found.AutoSize = true;
            this.found.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.found.Location = new System.Drawing.Point(109, 226);
            this.found.Name = "found";
            this.found.Size = new System.Drawing.Size(219, 53);
            this.found.TabIndex = 3;
            this.found.Text = "Book Found !!!";
            this.found.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(476, 75);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(172, 55);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search ";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButtonClick);
            // 
            // rT1
            // 
            this.rT1.Location = new System.Drawing.Point(38, 460);
            this.rT1.Name = "rT1";
            this.rT1.Size = new System.Drawing.Size(164, 38);
            this.rT1.TabIndex = 5;
            this.rT1.Text = "";
            this.rT1.Visible = false;
            // 
            // rT2
            // 
            this.rT2.Location = new System.Drawing.Point(250, 460);
            this.rT2.Name = "rT2";
            this.rT2.Size = new System.Drawing.Size(159, 38);
            this.rT2.TabIndex = 6;
            this.rT2.Text = "";
            this.rT2.Visible = false;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(118, 300);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(395, 58);
            this.detailsButton.TabIndex = 7;
            this.detailsButton.Text = "Show Details ";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.showDetails);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search A Book ";
            // 
            // rT3
            // 
            this.rT3.Location = new System.Drawing.Point(454, 460);
            this.rT3.Name = "rT3";
            this.rT3.Size = new System.Drawing.Size(154, 38);
            this.rT3.TabIndex = 9;
            this.rT3.Text = "";
            this.rT3.Visible = false;
            // 
            // namel
            // 
            this.namel.AutoSize = true;
            this.namel.Location = new System.Drawing.Point(35, 426);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(45, 17);
            this.namel.TabIndex = 10;
            this.namel.Text = "Name";
            this.namel.Visible = false;
            // 
            // authorl
            // 
            this.authorl.AutoSize = true;
            this.authorl.Location = new System.Drawing.Point(247, 426);
            this.authorl.Name = "authorl";
            this.authorl.Size = new System.Drawing.Size(50, 17);
            this.authorl.TabIndex = 11;
            this.authorl.Text = "Author";
            this.authorl.Visible = false;
            // 
            // editionl
            // 
            this.editionl.AutoSize = true;
            this.editionl.Location = new System.Drawing.Point(451, 426);
            this.editionl.Name = "editionl";
            this.editionl.Size = new System.Drawing.Size(51, 17);
            this.editionl.TabIndex = 12;
            this.editionl.Text = "Edition";
            this.editionl.Visible = false;
            // 
            // AllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 591);
            this.Controls.Add(this.editionl);
            this.Controls.Add(this.authorl);
            this.Controls.Add(this.namel);
            this.Controls.Add(this.rT3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.rT2);
            this.Controls.Add(this.rT1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.found);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBox1);
            this.Name = "AllBooks";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label found;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RichTextBox rT2;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.RichTextBox rT1;
        private System.Windows.Forms.RichTextBox rT3;
        private System.Windows.Forms.Label namel;
        private System.Windows.Forms.Label authorl;
        private System.Windows.Forms.Label editionl;
    }
}

