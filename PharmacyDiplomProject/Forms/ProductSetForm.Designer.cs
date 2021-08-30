
namespace PharmacyDiplomProject.Forms
{
    partial class ProductSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSetForm));
            this.ProductCountDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddCountTB = new System.Windows.Forms.TextBox();
            this.AddCountButton = new System.Windows.Forms.Button();
            this.CountPictureBox = new System.Windows.Forms.PictureBox();
            this.AddCountLabel = new System.Windows.Forms.Label();
            this.IdCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCountDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCountDGV
            // 
            this.ProductCountDGV.AllowUserToAddRows = false;
            this.ProductCountDGV.AllowUserToDeleteRows = false;
            this.ProductCountDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProductCountDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductCountDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductCountDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.ProductCountDGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProductCountDGV.Location = new System.Drawing.Point(0, 0);
            this.ProductCountDGV.Name = "ProductCountDGV";
            this.ProductCountDGV.ReadOnly = true;
            this.ProductCountDGV.RowHeadersVisible = false;
            this.ProductCountDGV.RowHeadersWidth = 51;
            this.ProductCountDGV.RowTemplate.Height = 24;
            this.ProductCountDGV.Size = new System.Drawing.Size(337, 424);
            this.ProductCountDGV.TabIndex = 0;
            this.ProductCountDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductCountDGV_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 103;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 73;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 122;
            // 
            // AddCountTB
            // 
            this.AddCountTB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCountTB.Location = new System.Drawing.Point(481, 328);
            this.AddCountTB.Name = "AddCountTB";
            this.AddCountTB.Size = new System.Drawing.Size(64, 34);
            this.AddCountTB.TabIndex = 1;
            this.AddCountTB.Text = "1";
            this.AddCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddCountButton
            // 
            this.AddCountButton.BackColor = System.Drawing.Color.DarkCyan;
            this.AddCountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCountButton.Location = new System.Drawing.Point(551, 325);
            this.AddCountButton.Name = "AddCountButton";
            this.AddCountButton.Size = new System.Drawing.Size(90, 40);
            this.AddCountButton.TabIndex = 2;
            this.AddCountButton.Text = "Добавить";
            this.AddCountButton.UseVisualStyleBackColor = false;
            this.AddCountButton.Click += new System.EventHandler(this.AddCountButton_Click);
            // 
            // CountPictureBox
            // 
            this.CountPictureBox.Location = new System.Drawing.Point(353, 12);
            this.CountPictureBox.Name = "CountPictureBox";
            this.CountPictureBox.Size = new System.Drawing.Size(293, 270);
            this.CountPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CountPictureBox.TabIndex = 3;
            this.CountPictureBox.TabStop = false;
            // 
            // AddCountLabel
            // 
            this.AddCountLabel.AutoSize = true;
            this.AddCountLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCountLabel.Location = new System.Drawing.Point(348, 294);
            this.AddCountLabel.Name = "AddCountLabel";
            this.AddCountLabel.Size = new System.Drawing.Size(18, 27);
            this.AddCountLabel.TabIndex = 4;
            this.AddCountLabel.Text = " ";
            // 
            // IdCountLabel
            // 
            this.IdCountLabel.AutoSize = true;
            this.IdCountLabel.Location = new System.Drawing.Point(387, 38);
            this.IdCountLabel.Name = "IdCountLabel";
            this.IdCountLabel.Size = new System.Drawing.Size(51, 19);
            this.IdCountLabel.TabIndex = 5;
            this.IdCountLabel.Text = "label1";
            this.IdCountLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(348, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество";
            // 
            // ProductSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(709, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdCountLabel);
            this.Controls.Add(this.AddCountLabel);
            this.Controls.Add(this.CountPictureBox);
            this.Controls.Add(this.AddCountButton);
            this.Controls.Add(this.AddCountTB);
            this.Controls.Add(this.ProductCountDGV);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Приход товаров";
            ((System.ComponentModel.ISupportInitialize)(this.ProductCountDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductCountDGV;
        private System.Windows.Forms.TextBox AddCountTB;
        private System.Windows.Forms.Button AddCountButton;
        private System.Windows.Forms.PictureBox CountPictureBox;
        private System.Windows.Forms.Label AddCountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label IdCountLabel;
        private System.Windows.Forms.Label label2;
    }
}