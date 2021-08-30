using PharmacyDiplomProject.Data;
using PharmacyDiplomProject.Models;
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
    public partial class RecipeForm : Form
    {
        public RecipeForm()
        {
            InitializeComponent();
        }

        private void IINButton_Click(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe();
            using(var recipeDataAccess = new RecipeDataAccess())
            {
                if (recipeDataAccess.IsIINExist(IINTextBox.Text))
                {
                    recipe = recipeDataAccess.Select(IINTextBox.Text);
                    IINPictureBox.Image = Image.FromFile(recipe.Photo);
                }
                else
                {
                    MessageBox.Show("Вы ввели неверные данные", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
