using Dollar_Computers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollar_Computers
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectFormNextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void SelectFormCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using(var db = new DollarComputersContext())
            {
                //db.products.Load();
                //productBindingSource.DataSource = db.products.Local.ToBindingList();
                {
                    db.products.Load();
                    productBindingSource.DataSource = db.products.Local.ToBindingList();
                    SelectFormNextButton.Enabled = false;
                }
            }
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            SelectFormNextButton.Enabled = true;
            //local scope aliases
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var rows = ProductDataGridView.Rows;
            var columnCount = ProductDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;

            //rows[rowIndex].Selected = true;


            Program.productDetails.Cost = double.Parse(cells[1].Value.ToString());
            Program.productDetails.Manufacturer = (cells[3].Value.ToString());
            Program.productDetails.Model = cells[4].Value.ToString();

            //string outputString = string.Empty;
            string manufacturer = Program.productDetails.Manufacturer;
            string model = Program.productDetails.Model;
            double cost = Program.productDetails.Cost;

            string outputString = manufacturer + ", " + model + ", " + " $" + cost;
            SelectionTextBox.Text = outputString;
            Program.productDetails.ProductionId = int.Parse(cells[0].Value.ToString());
            Program.productDetails.Cost = double.Parse(cells[1].Value.ToString());
            Program.productDetails.Manufacturer = (cells[2].Value.ToString());
            Program.productDetails.Model = cells[3].Value.ToString();
            Program.productDetails.RamType = cells[4].Value.ToString();
            Program.productDetails.RamSize = cells[5].Value.ToString();
            Program.productDetails.DisplayType = cells[6].Value.ToString();
            Program.productDetails.LCDSize = cells[7].Value.ToString();
            Program.productDetails.CPUClass = cells[8].Value.ToString();
            Program.productDetails.CPUBrand = cells[9].Value.ToString();
            Program.productDetails.CPUType = cells[10].Value.ToString();
            Program.productDetails.CPUSpeed = cells[11].Value.ToString();
            Program.productDetails.CPUNumber = cells[12].Value.ToString();
            Program.productDetails.Condition = cells[13].Value.ToString();
            Program.productDetails.OS = cells[14].Value.ToString();
            Program.productDetails.Platform = cells[15].Value.ToString();
            Program.productDetails.HDDSize = cells[16].Value.ToString();
            Program.productDetails.HDDSpeed = cells[17].Value.ToString();
            Program.productDetails.GPUType = cells[18].Value.ToString();
            Program.productDetails.OpticalDrive = cells[19].Value.ToString();
            Program.productDetails.AudioType = cells[20].Value.ToString();
            Program.productDetails.LAN = cells[21].Value.ToString();
            Program.productDetails.WIFI = cells[22].Value.ToString();
            Program.productDetails.Width = cells[23].Value.ToString();
            Program.productDetails.Height = cells[24].Value.ToString();
            Program.productDetails.Depth = cells[25].Value.ToString();
            Program.productDetails.Weight = cells[26].Value.ToString();
            Program.productDetails.MouseType = cells[27].Value.ToString();
            Program.productDetails.Power = cells[28].Value.ToString();
            Program.productDetails.WebCam = cells[29].Value.ToString();
        }
    }
}
