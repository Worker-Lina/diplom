using PharmacyDiplomProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyDiplomProject.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.AcceptButton = LoginButtom;
        }

        private void CloseButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButtom_Click(object sender, EventArgs e)
        {
            using (var employeeDataAccess = new EmployeeDataAccess())
            {
                if (employeeDataAccess.IsLoginExist(LoginTextBox.Text))
                {
                    var user = employeeDataAccess.SelectByLogin(LoginTextBox.Text);
                    if (LoginTextBox.Text == user.Login && PasswordTextBox.Text == user.Password)
                    {
                        if(user.Position == "фармацевт")
                        {
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                        }
                        if (user.Position == "администратор")
                        {
                            AdministrationForm mainForm = new AdministrationForm();
                            mainForm.Show();
                        }                 
                    }
                }
                else
                {
                    MessageBox.Show("Вы ввели неверные данные", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoginTextBox.Clear();
                    PasswordTextBox.Clear();
                }
            }
        }
    }
}
