
namespace PharmacyDiplomProject.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProductFromDBDGV = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ComboPanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecepeFind = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductPanel = new System.Windows.Forms.Panel();
            this.ShowInfoButton = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.Countlabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.Label();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.ProductListDGV = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ReceiptButton = new System.Windows.Forms.Button();
            this.PrintOut = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.Label();
            this.ReceiptNameLabel = new System.Windows.Forms.Label();
            this.ReceiptPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ProductFromDBDGV)).BeginInit();
            this.ComboPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDGV)).BeginInit();
            this.ReceiptPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductFromDBDGV
            // 
            this.ProductFromDBDGV.AllowUserToAddRows = false;
            this.ProductFromDBDGV.AllowUserToDeleteRows = false;
            this.ProductFromDBDGV.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.ProductFromDBDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductFromDBDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column6});
            this.ProductFromDBDGV.Location = new System.Drawing.Point(3, 33);
            this.ProductFromDBDGV.Name = "ProductFromDBDGV";
            this.ProductFromDBDGV.ReadOnly = true;
            this.ProductFromDBDGV.RowHeadersVisible = false;
            this.ProductFromDBDGV.RowHeadersWidth = 51;
            this.ProductFromDBDGV.RowTemplate.Height = 24;
            this.ProductFromDBDGV.Size = new System.Drawing.Size(462, 728);
            this.ProductFromDBDGV.TabIndex = 0;
            this.ProductFromDBDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.ProductFromDBDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Id";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            this.Column7.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цена";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Количество";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(3, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(217, 30);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ComboPanel
            // 
            this.ComboPanel.BackColor = System.Drawing.Color.Teal;
            this.ComboPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComboPanel.Controls.Add(this.ProductFromDBDGV);
            this.ComboPanel.Controls.Add(this.SearchButton);
            this.ComboPanel.Controls.Add(this.SearchTextBox);
            this.ComboPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ComboPanel.Location = new System.Drawing.Point(0, 32);
            this.ComboPanel.Name = "ComboPanel";
            this.ComboPanel.Size = new System.Drawing.Size(486, 801);
            this.ComboPanel.TabIndex = 6;
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.Location = new System.Drawing.Point(223, 3);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(30, 30);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1574, 32);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RecepeFind});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // RecepeFind
            // 
            this.RecepeFind.Name = "RecepeFind";
            this.RecepeFind.Size = new System.Drawing.Size(260, 26);
            this.RecepeFind.Text = "Посмотреть рецепт";
            this.RecepeFind.Click += new System.EventHandler(this.RecepeFind_Click);
            // 
            // ProductPanel
            // 
            this.ProductPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.ProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPanel.Controls.Add(this.ShowInfoButton);
            this.ProductPanel.Controls.Add(this.IdLabel);
            this.ProductPanel.Controls.Add(this.Countlabel);
            this.ProductPanel.Controls.Add(this.AddButton);
            this.ProductPanel.Controls.Add(this.CountTextBox);
            this.ProductPanel.Controls.Add(this.ProductName);
            this.ProductPanel.Controls.Add(this.ProductImage);
            this.ProductPanel.Location = new System.Drawing.Point(545, 52);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(396, 337);
            this.ProductPanel.TabIndex = 8;
            // 
            // ShowInfoButton
            // 
            this.ShowInfoButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ShowInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ShowInfoButton.FlatAppearance.BorderSize = 2;
            this.ShowInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowInfoButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowInfoButton.Location = new System.Drawing.Point(247, 249);
            this.ShowInfoButton.Name = "ShowInfoButton";
            this.ShowInfoButton.Size = new System.Drawing.Size(109, 38);
            this.ShowInfoButton.TabIndex = 6;
            this.ShowInfoButton.Text = "Просмотр";
            this.ShowInfoButton.UseVisualStyleBackColor = false;
            this.ShowInfoButton.Click += new System.EventHandler(this.ShowInfoButton_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(316, 10);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(0, 19);
            this.IdLabel.TabIndex = 5;
            this.IdLabel.Visible = false;
            // 
            // Countlabel
            // 
            this.Countlabel.AutoSize = true;
            this.Countlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Countlabel.Location = new System.Drawing.Point(52, 291);
            this.Countlabel.Name = "Countlabel";
            this.Countlabel.Size = new System.Drawing.Size(109, 22);
            this.Countlabel.TabIndex = 4;
            this.Countlabel.Text = "Количество";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DarkCyan;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(247, 293);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(109, 38);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CountTextBox
            // 
            this.CountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountTextBox.Location = new System.Drawing.Point(167, 279);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(56, 38);
            this.CountTextBox.TabIndex = 2;
            this.CountTextBox.Text = "1";
            this.CountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductName.Location = new System.Drawing.Point(144, 10);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(0, 29);
            this.ProductName.TabIndex = 1;
            // 
            // ProductImage
            // 
            this.ProductImage.BackColor = System.Drawing.Color.Azure;
            this.ProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductImage.Location = new System.Drawing.Point(56, 32);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(300, 211);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImage.TabIndex = 0;
            this.ProductImage.TabStop = false;
            // 
            // ProductListDGV
            // 
            this.ProductListDGV.AllowUserToAddRows = false;
            this.ProductListDGV.AllowUserToDeleteRows = false;
            this.ProductListDGV.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.ProductListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column5});
            this.ProductListDGV.Location = new System.Drawing.Point(545, 426);
            this.ProductListDGV.Name = "ProductListDGV";
            this.ProductListDGV.ReadOnly = true;
            this.ProductListDGV.RowHeadersVisible = false;
            this.ProductListDGV.RowHeadersWidth = 51;
            this.ProductListDGV.RowTemplate.Height = 24;
            this.ProductListDGV.Size = new System.Drawing.Size(396, 274);
            this.ProductListDGV.TabIndex = 11;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Id";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            this.Column8.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "название";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "цена";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Количество";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DarkCyan;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.DeleteButton.FlatAppearance.BorderSize = 2;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(841, 757);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 37);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ReceiptButton
            // 
            this.ReceiptButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ReceiptButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ReceiptButton.FlatAppearance.BorderSize = 2;
            this.ReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReceiptButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReceiptButton.Location = new System.Drawing.Point(672, 757);
            this.ReceiptButton.Name = "ReceiptButton";
            this.ReceiptButton.Size = new System.Drawing.Size(130, 37);
            this.ReceiptButton.TabIndex = 13;
            this.ReceiptButton.Text = "Оформить";
            this.ReceiptButton.UseVisualStyleBackColor = false;
            this.ReceiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // PrintOut
            // 
            this.PrintOut.AutoSize = true;
            this.PrintOut.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PrintOut.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PrintOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintOut.Location = new System.Drawing.Point(354, 682);
            this.PrintOut.Name = "PrintOut";
            this.PrintOut.Size = new System.Drawing.Size(178, 56);
            this.PrintOut.TabIndex = 14;
            this.PrintOut.Text = "Распечатать чек";
            this.PrintOut.UseVisualStyleBackColor = false;
            this.PrintOut.Visible = false;
            this.PrintOut.Click += new System.EventHandler(this.PrintOut_Click);
            // 
            // ProductList
            // 
            this.ProductList.AutoSize = true;
            this.ProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductList.Location = new System.Drawing.Point(75, 94);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(0, 25);
            this.ProductList.TabIndex = 1;
            // 
            // ReceiptNameLabel
            // 
            this.ReceiptNameLabel.AutoSize = true;
            this.ReceiptNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReceiptNameLabel.Location = new System.Drawing.Point(228, 39);
            this.ReceiptNameLabel.Name = "ReceiptNameLabel";
            this.ReceiptNameLabel.Size = new System.Drawing.Size(46, 25);
            this.ReceiptNameLabel.TabIndex = 0;
            this.ReceiptNameLabel.Text = "Чек";
            // 
            // ReceiptPanel
            // 
            this.ReceiptPanel.BackColor = System.Drawing.Color.LightCyan;
            this.ReceiptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReceiptPanel.Controls.Add(this.ProductList);
            this.ReceiptPanel.Controls.Add(this.ReceiptNameLabel);
            this.ReceiptPanel.Location = new System.Drawing.Point(64, 45);
            this.ReceiptPanel.Name = "ReceiptPanel";
            this.ReceiptPanel.Size = new System.Drawing.Size(468, 594);
            this.ReceiptPanel.TabIndex = 16;
            this.ReceiptPanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PrintOut);
            this.panel1.Controls.Add(this.ReceiptPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1022, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 801);
            this.panel1.TabIndex = 17;
            // 
            // SumTextBox
            // 
            this.SumTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumTextBox.Location = new System.Drawing.Point(774, 715);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(167, 34);
            this.SumTextBox.TabIndex = 18;
            this.SumTextBox.Text = "0";
            this.SumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(540, 722);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Внесенная сумма";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1574, 833);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReceiptButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ProductListDGV);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.ComboPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(898, 703);
            this.Name = "MainForm";
            this.Text = "Главная страница";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ProductFromDBDGV)).EndInit();
            this.ComboPanel.ResumeLayout(false);
            this.ComboPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ProductPanel.ResumeLayout(false);
            this.ProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDGV)).EndInit();
            this.ReceiptPanel.ResumeLayout(false);
            this.ReceiptPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductFromDBDGV;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.Panel ComboPanel;
        private System.Windows.Forms.Panel ProductPanel;
        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.Label Countlabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.DataGridView ProductListDGV;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ReceiptButton;
        private System.Windows.Forms.Button PrintOut;
        private System.Windows.Forms.Label ProductList;
        private System.Windows.Forms.Label ReceiptNameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripMenuItem RecepeFind;
        private System.Windows.Forms.Panel ReceiptPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowInfoButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}