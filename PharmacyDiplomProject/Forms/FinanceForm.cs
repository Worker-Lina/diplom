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
    public partial class FinanceForm : Form
    {
        public FinanceForm()
        {
            InitializeComponent();
        }

        private void FinanceWeekButton_Click(object sender, EventArgs e)
        {
            var finances = new List<Finance>();
            using(var purchaseDataAccess = new PurchaseDataAccess())
            {
                finances = purchaseDataAccess.SelectFinance();
            }

            decimal summa = 0;
            foreach (var f in finances)
            {
                FinanceDataGridView.Rows.Add(f.Info());
                summa += f.Summa;
            }


            AllSumLabel.Text = summa.ToString();
        }

        private void FinanceMonthButton_Click(object sender, EventArgs e)
        {
            decimal summa = 0;
            var finances = new List<Finance>();
            using (var purchaseDataAccess = new PurchaseDataAccess())
            {
                finances = purchaseDataAccess.SelectFinanceAll();
            }

            foreach (var f in finances)
            {
                FinanceDataGridView.Rows.Add(f.Info());
                summa += f.Summa;
            }

            AllSumLabel.Text = summa.ToString();
        }
    }
}
