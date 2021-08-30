
namespace PharmacyDiplomProject.Forms
{
    partial class RecipeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeForm));
            this.IINTextBox = new System.Windows.Forms.TextBox();
            this.IINPictureBox = new System.Windows.Forms.PictureBox();
            this.IINLabel = new System.Windows.Forms.Label();
            this.IINButton = new System.Windows.Forms.Button();
            this.IINPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.IINPictureBox)).BeginInit();
            this.IINPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IINTextBox
            // 
            this.IINTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IINTextBox.Location = new System.Drawing.Point(140, 69);
            this.IINTextBox.Name = "IINTextBox";
            this.IINTextBox.Size = new System.Drawing.Size(232, 34);
            this.IINTextBox.TabIndex = 0;
            // 
            // IINPictureBox
            // 
            this.IINPictureBox.BackColor = System.Drawing.Color.LightCyan;
            this.IINPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IINPictureBox.Location = new System.Drawing.Point(446, 12);
            this.IINPictureBox.Name = "IINPictureBox";
            this.IINPictureBox.Size = new System.Drawing.Size(750, 816);
            this.IINPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IINPictureBox.TabIndex = 1;
            this.IINPictureBox.TabStop = false;
            // 
            // IINLabel
            // 
            this.IINLabel.AutoSize = true;
            this.IINLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IINLabel.Location = new System.Drawing.Point(24, 76);
            this.IINLabel.Name = "IINLabel";
            this.IINLabel.Size = new System.Drawing.Size(63, 27);
            this.IINLabel.TabIndex = 2;
            this.IINLabel.Text = "ИИН";
            // 
            // IINButton
            // 
            this.IINButton.AutoSize = true;
            this.IINButton.BackColor = System.Drawing.Color.DarkCyan;
            this.IINButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IINButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IINButton.Location = new System.Drawing.Point(276, 151);
            this.IINButton.Name = "IINButton";
            this.IINButton.Size = new System.Drawing.Size(96, 39);
            this.IINButton.TabIndex = 3;
            this.IINButton.Text = "Поиск";
            this.IINButton.UseVisualStyleBackColor = false;
            this.IINButton.Click += new System.EventHandler(this.IINButton_Click);
            // 
            // IINPanel
            // 
            this.IINPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.IINPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IINPanel.Controls.Add(this.IINTextBox);
            this.IINPanel.Controls.Add(this.IINButton);
            this.IINPanel.Controls.Add(this.IINLabel);
            this.IINPanel.Location = new System.Drawing.Point(12, 53);
            this.IINPanel.Name = "IINPanel";
            this.IINPanel.Size = new System.Drawing.Size(415, 225);
            this.IINPanel.TabIndex = 4;
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1207, 944);
            this.Controls.Add(this.IINPanel);
            this.Controls.Add(this.IINPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecipeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Рецепт";
            ((System.ComponentModel.ISupportInitialize)(this.IINPictureBox)).EndInit();
            this.IINPanel.ResumeLayout(false);
            this.IINPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox IINTextBox;
        private System.Windows.Forms.PictureBox IINPictureBox;
        private System.Windows.Forms.Label IINLabel;
        private System.Windows.Forms.Button IINButton;
        private System.Windows.Forms.Panel IINPanel;
    }
}