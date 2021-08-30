
namespace PharmacyDiplomProject.Forms
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.pb_Product = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtb_description = new System.Windows.Forms.RichTextBox();
            this.dgv_analog = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_ShowAnalog = new System.Windows.Forms.Button();
            this.lb_ProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Product)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_analog)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Product
            // 
            this.pb_Product.Location = new System.Drawing.Point(13, 30);
            this.pb_Product.Name = "pb_Product";
            this.pb_Product.Size = new System.Drawing.Size(198, 208);
            this.pb_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Product.TabIndex = 0;
            this.pb_Product.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.rtb_description);
            this.panel1.Controls.Add(this.dgv_analog);
            this.panel1.Controls.Add(this.bt_ShowAnalog);
            this.panel1.Controls.Add(this.lb_ProductName);
            this.panel1.Controls.Add(this.pb_Product);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 634);
            this.panel1.TabIndex = 1;
            // 
            // rtb_description
            // 
            this.rtb_description.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtb_description.Location = new System.Drawing.Point(0, 262);
            this.rtb_description.Name = "rtb_description";
            this.rtb_description.Size = new System.Drawing.Size(843, 372);
            this.rtb_description.TabIndex = 5;
            this.rtb_description.Text = "";
            // 
            // dgv_analog
            // 
            this.dgv_analog.AllowUserToAddRows = false;
            this.dgv_analog.AllowUserToDeleteRows = false;
            this.dgv_analog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_analog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_analog.Location = new System.Drawing.Point(363, 30);
            this.dgv_analog.Name = "dgv_analog";
            this.dgv_analog.ReadOnly = true;
            this.dgv_analog.RowHeadersVisible = false;
            this.dgv_analog.RowHeadersWidth = 51;
            this.dgv_analog.RowTemplate.Height = 24;
            this.dgv_analog.Size = new System.Drawing.Size(477, 226);
            this.dgv_analog.TabIndex = 4;
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
            // Column3
            // 
            this.Column3.HeaderText = "Количество";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // bt_ShowAnalog
            // 
            this.bt_ShowAnalog.Location = new System.Drawing.Point(217, 203);
            this.bt_ShowAnalog.Name = "bt_ShowAnalog";
            this.bt_ShowAnalog.Size = new System.Drawing.Size(84, 35);
            this.bt_ShowAnalog.TabIndex = 2;
            this.bt_ShowAnalog.Text = "Аналоги";
            this.bt_ShowAnalog.UseVisualStyleBackColor = true;
            this.bt_ShowAnalog.Click += new System.EventHandler(this.bt_ShowAnalog_Click);
            // 
            // lb_ProductName
            // 
            this.lb_ProductName.AutoSize = true;
            this.lb_ProductName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_ProductName.Location = new System.Drawing.Point(217, 30);
            this.lb_ProductName.Name = "lb_ProductName";
            this.lb_ProductName.Size = new System.Drawing.Size(60, 22);
            this.lb_ProductName.TabIndex = 1;
            this.lb_ProductName.Text = "label1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(867, 658);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductInfoForm";
            this.Text = "Информация о продукте";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Product)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_analog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Product;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_analog;
        private System.Windows.Forms.Button bt_ShowAnalog;
        private System.Windows.Forms.Label lb_ProductName;
        private System.Windows.Forms.RichTextBox rtb_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}