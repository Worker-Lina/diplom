using PharmacyDiplomProject.Data;
using PharmacyDiplomProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyDiplomProject.Forms
{
    public partial class AdministrationForm : Form
    {


        public AdministrationForm()
        {
            InitializeComponent();
            LoadConboBox();
        }

        private void EmployeeShowButton_Click(object sender, EventArgs e)
        {
            EmployeeDataGridView.Rows.Clear();

            var employees = new List<Employee>();
            using (var employeeDataAccess = new EmployeeDataAccess())
            {
                employees = employeeDataAccess.Select().ToList();
            }

            foreach (var p in employees)
            {
                EmployeeDataGridView.Rows.Add(p.Info());
            }
        }

        private void EmployeeLoadButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                FIO=FIOTextBox.Text,
                Position = PositionTextBox.Text,
                Salary = decimal.Parse(SalaryTextBox.Text),
                Phone = PhoneTextBox.Text,
                PhotoURL = PhotoURLTextBox.Text,
                Address = AddressTextBox.Text,
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                DateOfEmployment = DateTime.Parse(WorkDateTimePicker.Text),
            };

            MessageBox.Show("Загрузка прошла успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using (var employeeDataAccess = new EmployeeDataAccess())
            {
                employeeDataAccess.Insert(employee);
            }

            ClearEmployee();
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Подтвердить удаление?", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if(result == DialogResult.OK)
            {
                int delet = EmployeeDataGridView.CurrentCell.RowIndex;
                Guid id = Guid.Parse(EmployeeDataGridView[0, delet].Value.ToString());
                EmployeeDataGridView.Rows.RemoveAt(delet);

                using (var employeeDataAccess = new EmployeeDataAccess())
                {
                    employeeDataAccess.Delete(id);
                }
            }
        }

        private void EmployeeChangeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сотрудник будет удален из БД", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(result == DialogResult.OK)
            {
                int delet = EmployeeDataGridView.CurrentCell.RowIndex;
                Guid id = Guid.Parse(EmployeeDataGridView[0, delet].Value.ToString());
                Employee employee;

                using (var employeeDataAccess = new EmployeeDataAccess())
                {
                    employee = employeeDataAccess.SelectEmployee(id);
                }

                FIOTextBox.Text = employee.FIO;
                PositionTextBox.Text = employee.Position;
                SalaryTextBox.Text = employee.Salary.ToString();
                PasswordTextBox.Text = employee.Password;
                LoginTextBox.Text = employee.Login;
                PhoneTextBox.Text = employee.Phone;
                PhotoURLTextBox.Text = employee.PhotoURL;
                AddressTextBox.Text = employee.Address;
                WorkDateTimePicker.Text = employee.DateOfEmployment.ToString();

                using (var employeeDataAccess = new EmployeeDataAccess())
                {
                    employeeDataAccess.Delete(id);
                }
            }
        
        }


        private void ClearEmployee()
        {
            FIOTextBox.Clear();
            PositionTextBox.Clear();
            SalaryTextBox.Clear();
            PhoneTextBox.Clear();
            PhotoURLTextBox.Clear();
            AddressTextBox.Clear();
            LoginTextBox.Clear();
            PasswordTextBox.Clear();
        }

        private void ShowProductButton_Click(object sender, EventArgs e)
        {
            ProductsDataGridView.Rows.Clear();

            var products = new List<Product>();
            using(var productDataBase = new ProductDataAccess())
            {
                products = productDataBase.SelectNew().ToList();
            }

            foreach (var p in products)
            {
                ProductsDataGridView.Rows.Add(p.InfoNew());
            }
        }

        private void LoadProductButton_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = ProductNameTextBox.Text,
                Category = CategoryComboBox.SelectedItem.ToString(),
                Manufacturer = ManufacturerComboBox.SelectedItem.ToString(),
                PurchasePrice = decimal.Parse(PurchaseTextBox.Text),
                SellingPrice = decimal.Parse(SellingTextBox.Text),
                Recipe = RecipeComboBox.SelectedItem.ToString(),
                ReleaseDate = DateTime.Parse(ReleaseDateTimePicker.Text),
                SellBeforeDate = DateTime.Parse(SellBeforeDateTimePicker.Text),
                PhotoURL = PhotoTextBox.Text,
                Count = int.Parse(ProductCountTextBox.Text),
                Description = DescriptionRTB.Text
            };
            using (var productDataAccess = new ProductDataAccess())
            {
                productDataAccess.Insert(product);
            }

            MessageBox.Show("Загрузка прошла успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProductNameTextBox.Clear();
            CategoryComboBox.SelectedIndex = -1;
            ManufacturerComboBox.SelectedIndex = -1;
            PurchaseTextBox.Clear();
            SellingTextBox.Clear();
            RecipeComboBox.SelectedIndex = -1;
            PhotoTextBox.Clear();
            ProductCountTextBox.Clear();
            DescriptionRTB.Clear();


        }


        private void LoadConboBox()
        {
            List<string> manufacturer;
            List<string> categories;
            using (var productDataAccess = new ProductDataAccess())
            {
                manufacturer = productDataAccess.SelectManufacturer();
                categories = productDataAccess.SelectCategories();
            }

            for(int i = 0; i < manufacturer.Count; i++)
            {
                ManufacturerComboBox.Items.Add(manufacturer[i]);
            }
            for(int i = 0; i < categories.Count; i++)
            {
                CategoryComboBox.Items.Add(categories[i]);
            }           
        }



        private void ManufacturerLoadButton_Click(object sender, EventArgs e)
        {
            Manufacturer manufacturer = new Manufacturer
            {
                Name = ManufacturerNameTextBox.Text,
                Country = CountryTextBox.Text,
                City = CityTextBox.Text,
                Address = ManufacturerAddressTextBox.Text,
                Phone = ManufacturerPhoneTextBox.Text
            };

            using(var manufacturerDataAccess = new ManufacturerDataAccess())
            {
                manufacturerDataAccess.Insert(manufacturer);
            }

            MessageBox.Show("Загрузка прошла успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ManufacturerNameTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            ManufacturerAddressTextBox.Clear();
            ManufacturerPhoneTextBox.Clear();
        }


        private void ReportButton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            var products = new List<Product>();
            using(var productDataAccess = new ProductDataAccess())
            {
                products = productDataAccess.SelectNeedProduct();
            }
            var text = new List<string[]>();
            foreach(var product in products)
            {
                string[] arr = 
                {
                    product.Name,
                    product.PurchasePrice.ToString(),
                    product.Count.ToString()
                };
                text.Add(arr);
            }
            reportForm.Set(text);
            reportForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        private void ShowManufacturerButton_Click(object sender, EventArgs e)
        {
            ManufacturerDataGridView.Rows.Clear();

            var manufacturer = new List<Manufacturer>();
            using(var manufacturerDataAccess = new ManufacturerDataAccess())
            {
                manufacturer = manufacturerDataAccess.Select().ToList();
            }

            foreach (var m in manufacturer)
            {
                ManufacturerDataGridView.Rows.Add(m.Info());
            }
        }

        private void ManufacturerDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сотрудник будет удален из БД", "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                int delet = ManufacturerDataGridView.CurrentCell.RowIndex;
                Guid id = Guid.Parse(ManufacturerDataGridView[0, delet].Value.ToString());
                ManufacturerDataGridView.Rows.RemoveAt(delet);

                using (var manufacturerDataAccess = new ManufacturerDataAccess())
                {
                    manufacturerDataAccess.Delete(id);
                }
            }
        }

        private void OpenImgButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PhotoTextBox.Text = open.FileName;
            }
            
        }

        private void FinanceButton_Click(object sender, EventArgs e)
        {
            FinanceForm financeForm = new FinanceForm();
            financeForm.ShowDialog();
        }

        private void ProductSet_Click(object sender, EventArgs e)
        {
            ProductSetForm productSet = new ProductSetForm();
            productSet.ShowDialog();
        }
    }
}
