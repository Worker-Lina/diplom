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
    public partial class ProductSetForm : Form
    {
        public ProductSetForm()
        {
            InitializeComponent();

            SetProduct();
        }

        void SetProduct()
        {
            var products = new List<Product>();
            using (var productDataAccess = new ProductDataAccess())
            {
                products = productDataAccess.Select().ToList();
            }

            foreach (var p in products)
            {
                ProductCountDGV.Rows.Add(p.Info());
            }
        }

        private void AddCountButton_Click(object sender, EventArgs e)
        {
            if (CountPictureBox.Image == null)
            {
                MessageBox.Show("Выберите товар", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var productDataAccess = new ProductDataAccess())
            {
                productDataAccess.ChangeCountPlus(Guid.Parse(IdCountLabel.Text), int.Parse(AddCountTB.Text));
            }
            MessageBox.Show("Данные загружены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AddCountTB.Text = "1";

            ProductCountDGV.Rows.Clear();
            SetProduct();

        }

        private void ProductCountDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var product = new Product();
            using (var productdataBase = new ProductDataAccess())
            {
                product = productdataBase.SelectProductById(Guid.Parse(ProductCountDGV[0, e.RowIndex].Value.ToString()));
            }
            IdCountLabel.Text = product.Id.ToString();
            AddCountLabel.Text = product.Name;
            CountPictureBox.Image = Image.FromFile($@"{product.PhotoURL}");
        }
    }
}
