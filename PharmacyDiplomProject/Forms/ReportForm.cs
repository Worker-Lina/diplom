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
using PagedList;

namespace PharmacyDiplomProject.Forms
{
    public partial class ReportForm : Form
    {
        
        public ReportForm()
        {
            InitializeComponent();
        }


        private void CloseButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Set(List<string[]> str)
        {
            foreach(var s in str)
            {
                NeedProductDataGridView.Rows.Add(s);
            }
        }

        Bitmap bmp;
        private void PrintButton_Click(object sender, EventArgs e)
        {
            int height = NeedProductDataGridView.Height;
            NeedProductDataGridView.Height = NeedProductDataGridView.RowCount * NeedProductDataGridView.RowTemplate.Height * 2;
            bmp = new Bitmap(NeedProductDataGridView.Size.Width, NeedProductDataGridView.Size.Height);
            NeedProductDataGridView.DrawToBitmap(bmp, NeedProductDataGridView.Bounds);
            NeedProductDataGridView.DrawToBitmap(bmp, new Rectangle(0, 0, NeedProductDataGridView.Width, NeedProductDataGridView.Height));
            NeedProductDataGridView.Height = Height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

    }
}
