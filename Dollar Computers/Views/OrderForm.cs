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

namespace Dollar_Computers.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderFormCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            // give feedback to the user that the file has been saved
            // this is a "modal" form
            //MessageBox.Show("Thanks for your order, Your order will be processed in 7-10 business days.");
            DialogResult dialogResult = MessageBox.Show("Thanks for your order\n\nYour order will be processed in 7-10 business days", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            OrderFormConditionTextBox.Text = Program.productDetails.Condition;
            OrderFormPlatformTextBox.Text = Program.productDetails.Platform;
            OrderFormManufacturerTextBox.Text = Program.productDetails.Manufacturer;
            OrderFormModelTextBox.Text = Program.productDetails.Model;

            OrderFormMultilineTextBox.Text += "\r\n";
            OrderFormMultilineTextBox.Text += Program.productDetails.LCDSize + "\r\n";
            OrderFormMultilineTextBox.Text += "\r\n";
            OrderFormMultilineTextBox.Text += Program.productDetails.RamSize + "\r\n";
            OrderFormMultilineTextBox.Text += "\r\n";
            OrderFormMultilineTextBox.Text += Program.productDetails.CPUBrand + "\r\n";
            OrderFormMultilineTextBox.Text += "\r\n";
            OrderFormMultilineTextBox.Text += Program.productDetails.CPUType + "\r\n";
            OrderFormMultilineTextBox.Text += "\r\n";
            OrderFormMultilineTextBox.Text += Program.productDetails.CPUNumber + "\r\n";
            OrderFormMultilineTextBox.Text += "\r\n";
            OrderFormMultilineTextBox.Text += Program.productDetails.CPUSpeed + "\r\n";
            OrderFormMultilineTextBox.Text += "\r\n";
            OrderFormMultilineTextBox.Text += Program.productDetails.HDDSize + "\r\n";
            OrderFormMultilineTextBox.Text += "\r\n";
            OrderFormMultilineTextBox.Text += Program.productDetails.GPUType + "\r\n";
            OrderFormMultilineTextBox.Text += "\r\n";
            OrderFormMultilineTextBox.Text += Program.productDetails.WebCam + "\r\n";
            OrderFormMultilineTextBox.Text += "\r\n";
            OrderFormMultilineTextBox.Text += Program.productDetails.OS + "\r\n";

            PriceTextBox.Text = $"{Program.productDetails.Cost:C2}".ToString();
            SalesTaxTextBox.Text = $"{(Program.productDetails.Cost * 0.13):C2}".ToString();
            TotalPriceTextBox.Text = $"{(Program.productDetails.Cost + (Program.productDetails.Cost * 0.13)):C2}".ToString();
        }
    }
}
