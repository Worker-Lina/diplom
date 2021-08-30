using PharmacyDiplomProject.Data;
using PharmacyDiplomProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyDiplomProject.Forms
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            LoadForm();
        }

        private void LoadForm()
        {
            var products = new List<Product>();
            using(var productDataAccess = new ProductDataAccess())
            {
                products = productDataAccess.Select().ToList();
            }

            foreach(var p in products)
            {
                ProductFromDBDGV.Rows.Add(p.Info());
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var text = SearchTextBox.Text;

            var products = new List<Product>();

            if (text != "")
            {
                using (var productDataAccess = new ProductDataAccess())
                {
                    products = productDataAccess.SelectProductsByName(text).ToList<Product>();
                }

                ProductFromDBDGV.Rows.Clear();
                ProductFromDBDGV.Refresh();

                foreach (var p in products)
                {
                    ProductFromDBDGV.Rows.Add(p.Info());
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                ProductFromDBDGV.Rows.Clear();
                LoadForm();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (int.Parse(ProductFromDBDGV[3, ProductFromDBDGV.CurrentRow.Index].Value.ToString()) > 0)
            {
                string text = ProductFromDBDGV[1, e.RowIndex].Value.ToString();
                double price = double.Parse(ProductFromDBDGV[2, e.RowIndex].Value.ToString());
                string id = ProductFromDBDGV[0, e.RowIndex].Value.ToString();
                ProductFromDBDGV[3, e.RowIndex].Value = int.Parse(ProductFromDBDGV[3, e.RowIndex].Value.ToString()) - 1;

                bool res = true;

                for (int i = 0; i < ProductListDGV.Rows.Count; i++)
                {
                    if (ProductListDGV[0, i].Value.ToString() == id)
                    {
                        ProductListDGV[3, i].Value = int.Parse(ProductListDGV[3, i].Value.ToString()) + 1;
                        res = false;
                    }
                }
                if (res)
                {
                    ProductListDGV.Rows.Add(id, text, price, 1);
                }
            }
            else
            {
                MessageBox.Show("Ошибка", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double summa = 0;

        private string Sum(double price)
        {
            summa += price;
            return summa.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var product = new Product();
            using(var productdataBase = new ProductDataAccess())
            {
                product = productdataBase.SelectProductById(Guid.Parse(ProductFromDBDGV[0, e.RowIndex].Value.ToString()));
            }
            IdLabel.Text = product.Id.ToString();
            ProductName.Text = product.Name;
            string path = Environment.CurrentDirectory + $"{product.PhotoURL}";
            ProductImage.Image = Image.FromFile(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ProductImage.Image == null)
            {
                MessageBox.Show("Выберите товар", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int kol = int.Parse(CountTextBox.Text);

            if (kol <= int.Parse(ProductFromDBDGV[3, ProductFromDBDGV.CurrentRow.Index].Value.ToString()) && kol > 0)
            {
                bool res = true;

                ProductFromDBDGV[3, ProductFromDBDGV.CurrentRow.Index].Value = int.Parse(ProductFromDBDGV[3, ProductFromDBDGV.CurrentRow.Index].Value.ToString()) - kol;

                var product = new Product();
                using (var productdataBase = new ProductDataAccess())
                {
                    product = productdataBase.SelectProductById(Guid.Parse(IdLabel.Text));
                }

                for (int i = 0; i < ProductListDGV.Rows.Count; i++)
                {
                    if (ProductListDGV[0, i].Value.ToString() == product.Id.ToString())
                    {
                        ProductListDGV[3, i].Value = int.Parse(ProductListDGV[3, i].Value.ToString()) + kol;
                        res = false;
                    }
                }
                if (res)
                {
                    ProductListDGV.Rows.Add(product.Id, product.Name, product.SellingPrice, kol);
                }
            }
            else
            {
                MessageBox.Show("Ошибка", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(ProductListDGV.RowCount == 0)
            {
                MessageBox.Show("Добавьте товары", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int delet = ProductListDGV.CurrentCell.RowIndex;            

            for(int i = 0; i < ProductFromDBDGV.RowCount; i++)
            {
                if(ProductFromDBDGV[0,i].Value.ToString() == ProductListDGV[0, delet].Value.ToString())
                {
                    ProductFromDBDGV[3, i].Value = int.Parse(ProductFromDBDGV[3, i].Value.ToString()) + int.Parse(ProductListDGV[3, delet].Value.ToString());
                }
            }
            ProductListDGV.Rows.RemoveAt(delet);
        }



        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            if (ProductListDGV.RowCount == 0)
            {
                MessageBox.Show("Добавьте товары", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            decimal clientSum = decimal.Parse(SumTextBox.Text);

            decimal sum = 0;
            for(int i = 0; i < ProductListDGV.Rows.Count; i++)
            {
                ProductList.Text += $"{ProductListDGV[1,i].Value} {ProductListDGV[2, i].Value} x {ProductListDGV[3, i].Value} = {decimal.Parse(ProductListDGV[2, i].Value.ToString())*int.Parse(ProductListDGV[3, i].Value.ToString())}\n";
                sum += decimal.Parse(ProductListDGV[2, i].Value.ToString()) * int.Parse(ProductListDGV[3, i].Value.ToString());
            }

            if (clientSum >= sum)
            {
                ProductList.Text += $"\n\nИтого = {sum}";
                ProductList.Text += $"\n\rВнесенная сумма  = {clientSum}";
                ProductList.Text += $"\nСдача  = {clientSum - sum}";

                PrintOut.Visible = true;
                ReceiptPanel.Visible = true;

                Purchase purchase = new Purchase();
                purchase.DateTime = DateTime.Now;
                purchase.producttes = new Dictionary<Product, int>();
                purchase.sum = sum;
                Product product;
                for (int i = 0; i < ProductListDGV.Rows.Count; i++)
                {
                    using (var productDataAccess = new ProductDataAccess())
                    {
                        productDataAccess.ChangeCount(Guid.Parse(ProductListDGV[0, i].Value.ToString()), int.Parse(ProductListDGV[3, i].Value.ToString()));
                        product = productDataAccess.SelectProductById(Guid.Parse(ProductListDGV[0, i].Value.ToString()));
                        purchase.producttes.Add(product, int.Parse(ProductListDGV[3, i].Value.ToString()));
                    }
                }


                using (var purchaseDataAccess = new PurchaseDataAccess())
                {
                    purchaseDataAccess.InsertReceipt(purchase);
                    foreach (var prod in purchase.producttes)
                    {
                        purchaseDataAccess.InsertPurchase(prod.Key, purchase, prod.Value);
                    }
                }

                ProductListDGV.Rows.Clear();
                SumTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Недостаточно средств", "уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void PrintOut_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.printDocument1_PrintPage;
            PrintDialog dlg = new PrintDialog();
            dlg.Document = doc;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
            ProductList.Text = "";
            ReceiptPanel.Visible = false;
            PrintOut.Visible = false;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(ReceiptPanel.Width, ReceiptPanel.Height);
            ReceiptPanel.DrawToBitmap(bmp, new Rectangle(0, 0, ReceiptPanel.Width, ReceiptPanel.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }

        private void RecepeFind_Click(object sender, EventArgs e)
        {
            RecipeForm recipeForm = new RecipeForm();
            recipeForm.ShowDialog();
        }

        private void ShowInfoButton_Click(object sender, EventArgs e)
        {
            if(ProductImage.Image == null)
            {
                MessageBox.Show("Выберите товар", "Уведомление", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            var product = new Product();
            using(var productDataAccess = new ProductDataAccess())
            {
                product = productDataAccess.SelectProductById(Guid.Parse(IdLabel.Text));
            }
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.Init(product);
            productInfoForm.ShowDialog();
        }
    }
}
