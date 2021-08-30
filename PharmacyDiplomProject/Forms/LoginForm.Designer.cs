
namespace PharmacyDiplomProject.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.CloseButtom = new System.Windows.Forms.Button();
            this.TextInLoginForm = new System.Windows.Forms.Label();
            this.GBinLoginForm = new System.Windows.Forms.GroupBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.UserPB = new System.Windows.Forms.PictureBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginButtom = new System.Windows.Forms.Button();
            this.GBinLoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPB)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButtom
            // 
            this.CloseButtom.AutoSize = true;
            this.CloseButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButtom.FlatAppearance.BorderSize = 0;
            this.CloseButtom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.CloseButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButtom.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButtom.Location = new System.Drawing.Point(461, 0);
            this.CloseButtom.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButtom.Name = "CloseButtom";
            this.CloseButtom.Size = new System.Drawing.Size(39, 42);
            this.CloseButtom.TabIndex = 1;
            this.CloseButtom.Text = "x";
            this.CloseButtom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButtom.UseVisualStyleBackColor = true;
            this.CloseButtom.Click += new System.EventHandler(this.CloseButtom_Click);
            // 
            // TextInLoginForm
            // 
            this.TextInLoginForm.AutoSize = true;
            this.TextInLoginForm.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextInLoginForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(228)))));
            this.TextInLoginForm.Location = new System.Drawing.Point(12, 9);
            this.TextInLoginForm.Name = "TextInLoginForm";
            this.TextInLoginForm.Size = new System.Drawing.Size(195, 33);
            this.TextInLoginForm.TabIndex = 2;
            this.TextInLoginForm.Text = "Вход в систему";
            // 
            // GBinLoginForm
            // 
            this.GBinLoginForm.Controls.Add(this.PasswordTextBox);
            this.GBinLoginForm.Controls.Add(this.LoginTextBox);
            this.GBinLoginForm.Controls.Add(this.UserPB);
            this.GBinLoginForm.Controls.Add(this.PasswordLabel);
            this.GBinLoginForm.Controls.Add(this.LoginLabel);
            this.GBinLoginForm.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GBinLoginForm.Location = new System.Drawing.Point(41, 70);
            this.GBinLoginForm.Name = "GBinLoginForm";
            this.GBinLoginForm.Size = new System.Drawing.Size(423, 241);
            this.GBinLoginForm.TabIndex = 3;
            this.GBinLoginForm.TabStop = false;
            this.GBinLoginForm.Text = "Авторизация пользователя";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(266, 138);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(143, 27);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(266, 71);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(143, 27);
            this.LoginTextBox.TabIndex = 3;
            // 
            // UserPB
            // 
            this.UserPB.Image = ((System.Drawing.Image)(resources.GetObject("UserPB.Image")));
            this.UserPB.Location = new System.Drawing.Point(6, 56);
            this.UserPB.Name = "UserPB";
            this.UserPB.Size = new System.Drawing.Size(124, 139);
            this.UserPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPB.TabIndex = 2;
            this.UserPB.TabStop = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(163, 138);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(72, 22);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(163, 72);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(64, 22);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Логин";
            // 
            // LoginButtom
            // 
            this.LoginButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButtom.FlatAppearance.BorderSize = 0;
            this.LoginButtom.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButtom.Location = new System.Drawing.Point(347, 335);
            this.LoginButtom.Name = "LoginButtom";
            this.LoginButtom.Size = new System.Drawing.Size(117, 36);
            this.LoginButtom.TabIndex = 4;
            this.LoginButtom.Text = "Войти";
            this.LoginButtom.UseVisualStyleBackColor = true;
            this.LoginButtom.Click += new System.EventHandler(this.LoginButtom_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.LoginButtom);
            this.Controls.Add(this.GBinLoginForm);
            this.Controls.Add(this.TextInLoginForm);
            this.Controls.Add(this.CloseButtom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.GBinLoginForm.ResumeLayout(false);
            this.GBinLoginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButtom;
        private System.Windows.Forms.Label TextInLoginForm;
        private System.Windows.Forms.GroupBox GBinLoginForm;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.PictureBox UserPB;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button LoginButtom;
    }
}