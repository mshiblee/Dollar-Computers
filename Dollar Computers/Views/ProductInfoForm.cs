using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollar_Computers
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductFormNextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void ProductFormCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDTextBox.Text = Program.productDetails.ProductionId.ToString();
            CostTextBox.Text = Program.productDetails.Cost.ToString();
            ConditionTextBox.Text = Program.productDetails.Condition;
            PlatformTextBox.Text = Program.productDetails.Platform;
            OSTextBox.Text = Program.productDetails.OS;
            ManufacturerTextBox.Text = Program.productDetails.Manufacturer;
            ModelTextBox.Text = Program.productDetails.Model;
            MemoryTextBox.Text = Program.productDetails.RamSize;
            LCDSizeTextBox.Text = Program.productDetails.LCDSize;
            HDDTextBox.Text = Program.productDetails.HDDSize;
            CPUBrandTextBox.Text = Program.productDetails.CPUBrand;
            CPUNumberTextBox.Text = Program.productDetails.CPUNumber;
            GPUTypeTextBox.Text = Program.productDetails.GPUType;
            CPUTypeTextBox.Text = Program.productDetails.CPUType;
            CPUSpeedTextBox.Text = Program.productDetails.CPUSpeed;
            WebCamTextBox.Text = Program.productDetails.WebCam;
        }
    }
}
