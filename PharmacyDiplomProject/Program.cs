using PharmacyDiplomProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyDiplomProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new MainForm());
            //Application.Run(new AdministrationForm());
            //Application.Run(new RecipeForm());
            //Application.Run(new FinanceForm());
            //Application.Run(new ProductSetForm());
        }
    }
}
