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
    public partial class ProductInfoForm : Form
    {
        Product product;
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        public void Init(Product pro)
        {
            product = pro;
            string path = Environment.CurrentDirectory + $"{product.PhotoURL}";
            pb_Product.Image = Image.FromFile(path);
            lb_ProductName.Text = $"{product.Name} \n\r{product.SellingPrice}";
            rtb_description.Text = product.Description;
        }

        private void bt_ShowAnalog_Click(object sender, EventArgs e)
        {
            var products = new List<Product>();
            using (var productDataAccess = new ProductDataAccess())
            {
                products = productDataAccess.SelectProductByCategory(product.Category);
            }

            foreach (var p in products)
            {
                dgv_analog.Rows.Add(p.InfoCate());
            }
        }
    }
}
