
namespace PharmacyDiplomProject.Forms
{
    partial class FinanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceForm));
            this.FinanceDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinanceMonthButton = new System.Windows.Forms.Button();
            this.FinanceWeekButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AllSumLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.FinanceDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FinanceDataGridView
            // 
            this.FinanceDataGridView.AllowUserToAddRows = false;
            this.FinanceDataGridView.AllowUserToDeleteRows = false;
            this.FinanceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.FinanceDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FinanceDataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.FinanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FinanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.FinanceDataGridView.Location = new System.Drawing.Point(13, 13);
            this.FinanceDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.FinanceDataGridView.Name = "FinanceDataGridView";
            this.FinanceDataGridView.ReadOnly = true;
            this.FinanceDataGridView.RowHeadersVisible = false;
            this.FinanceDataGridView.RowHeadersWidth = 51;
            this.FinanceDataGridView.RowTemplate.Height = 24;
            this.FinanceDataGridView.Size = new System.Drawing.Size(662, 610);
            this.FinanceDataGridView.TabIndex = 0;
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
            this.Column3.HeaderText = "Количество";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 122;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Цена";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 73;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Сумма";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 86;
            // 
            // FinanceMonthButton
            // 
            this.FinanceMonthButton.BackColor = System.Drawing.Color.DarkCyan;
            this.FinanceMonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinanceMonthButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinanceMonthButton.Location = new System.Drawing.Point(386, 661);
            this.FinanceMonthButton.Margin = new System.Windows.Forms.Padding(4);
            this.FinanceMonthButton.Name = "FinanceMonthButton";
            this.FinanceMonthButton.Size = new System.Drawing.Size(130, 53);
            this.FinanceMonthButton.TabIndex = 1;
            this.FinanceMonthButton.Text = "За месяц";
            this.FinanceMonthButton.UseVisualStyleBackColor = false;
            this.FinanceMonthButton.Click += new System.EventHandler(this.FinanceMonthButton_Click);
            // 
            // FinanceWeekButton
            // 
            this.FinanceWeekButton.BackColor = System.Drawing.Color.DarkCyan;
            this.FinanceWeekButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinanceWeekButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinanceWeekButton.Location = new System.Drawing.Point(555, 661);
            this.FinanceWeekButton.Margin = new System.Windows.Forms.Padding(4);
            this.FinanceWeekButton.Name = "FinanceWeekButton";
            this.FinanceWeekButton.Size = new System.Drawing.Size(120, 53);
            this.FinanceWeekButton.TabIndex = 2;
            this.FinanceWeekButton.Text = "За неделю";
            this.FinanceWeekButton.UseVisualStyleBackColor = false;
            this.FinanceWeekButton.Click += new System.EventHandler(this.FinanceWeekButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Общая сумма: ";
            // 
            // AllSumLabel
            // 
            this.AllSumLabel.AutoSize = true;
            this.AllSumLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllSumLabel.Location = new System.Drawing.Point(205, 22);
            this.AllSumLabel.Name = "AllSumLabel";
            this.AllSumLabel.Size = new System.Drawing.Size(24, 27);
            this.AllSumLabel.TabIndex = 6;
            this.AllSumLabel.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AllSumLabel);
            this.panel1.Location = new System.Drawing.Point(682, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 126);
            this.panel1.TabIndex = 7;
            // 
            // FinanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FinanceWeekButton);
            this.Controls.Add(this.FinanceMonthButton);
            this.Controls.Add(this.FinanceDataGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.Name = "FinanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Доходы";
            ((System.ComponentModel.ISupportInitialize)(this.FinanceDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FinanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button FinanceMonthButton;
        private System.Windows.Forms.Button FinanceWeekButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AllSumLabel;
        private System.Windows.Forms.Panel panel1;
    }
}