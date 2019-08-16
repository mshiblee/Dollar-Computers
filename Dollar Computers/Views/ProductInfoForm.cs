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

namespace Dollar_Computers.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductFormNextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderForm.Show();          
        }

        private void ProductFormCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();           
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialogue.FileName = "Product.txt";
            SaveFileDialogue.InitialDirectory = Directory.GetCurrentDirectory();
            SaveFileDialogue.Filter = "Text Files(*.txt)|*.txt| All Files (*.*)|*.*";
            //open the file dialog
            var result = SaveFileDialogue.ShowDialog();
            if (result != DialogResult.Cancel)
                //open a stream to write
                using (StreamWriter outputStream = new StreamWriter(
                File.Open(SaveFileDialogue.FileName, FileMode.Create)))
                {
                    //write content - string type - to the file
                    outputStream.WriteLine(Program.productDetails.ProductionId.ToString());
                    outputStream.WriteLine(Program.productDetails.Cost.ToString());
                    outputStream.WriteLine(Program.productDetails.Manufacturer);
                    outputStream.WriteLine(Program.productDetails.Model);
                    outputStream.WriteLine(Program.productDetails.RamType);
                    outputStream.WriteLine(Program.productDetails.RamSize);
                    outputStream.WriteLine(Program.productDetails.DisplayType);
                    outputStream.WriteLine(Program.productDetails.LCDSize);
                    outputStream.WriteLine(Program.productDetails.CPUClass);
                    outputStream.WriteLine(Program.productDetails.CPUBrand);
                    outputStream.WriteLine(Program.productDetails.CPUType);
                    outputStream.WriteLine(Program.productDetails.CPUSpeed);
                    outputStream.WriteLine(Program.productDetails.CPUNumber);
                    outputStream.WriteLine(Program.productDetails.Condition);
                    outputStream.WriteLine(Program.productDetails.OS);
                    outputStream.WriteLine(Program.productDetails.Platform);
                    outputStream.WriteLine(Program.productDetails.HDDSize);
                    outputStream.WriteLine(Program.productDetails.HDDSpeed);
                    outputStream.WriteLine(Program.productDetails.GPUType);
                    outputStream.WriteLine(Program.productDetails.OpticalDrive);
                    outputStream.WriteLine(Program.productDetails.LAN);
                    outputStream.WriteLine(Program.productDetails.WIFI);
                    outputStream.WriteLine(Program.productDetails.AudioType);
                    outputStream.WriteLine(Program.productDetails.Width);
                    outputStream.WriteLine(Program.productDetails.Height);
                    outputStream.WriteLine(Program.productDetails.Depth);
                    outputStream.WriteLine(Program.productDetails.Weight);
                    outputStream.WriteLine(Program.productDetails.MouseType);
                    outputStream.WriteLine(Program.productDetails.Power);
                    outputStream.WriteLine(Program.productDetails.WebCam);
                    //cleanup
                    outputStream.Close();
                    outputStream.Dispose();
                    MessageBox.Show("File saved...", "Saving file...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialogue.FileName = "Product.txt";
            OpenFileDialogue.InitialDirectory = Directory.GetCurrentDirectory();
            OpenFileDialogue.Filter = "Text Files(*.txt)|*.txt| All Files (*.*)|*.*";
            var result = OpenFileDialogue.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    using (StreamReader inputStream = new StreamReader(
                    File.Open(OpenFileDialogue.FileName, FileMode.Open)))
                    {
                        //read the file
                        Program.productDetails.ProductionId = int.Parse(inputStream.ReadLine());
                        Program.productDetails.Cost = double.Parse(inputStream.ReadLine());
                        Program.productDetails.Manufacturer = inputStream.ReadLine();
                        Program.productDetails.Model = inputStream.ReadLine();
                        Program.productDetails.RamType = inputStream.ReadLine();
                        Program.productDetails.RamSize = inputStream.ReadLine();
                        Program.productDetails.DisplayType = inputStream.ReadLine();
                        Program.productDetails.LCDSize = inputStream.ReadLine();
                        Program.productDetails.CPUClass = inputStream.ReadLine();
                        Program.productDetails.CPUBrand = inputStream.ReadLine();
                        Program.productDetails.CPUType = inputStream.ReadLine();
                        Program.productDetails.CPUSpeed = inputStream.ReadLine();
                        Program.productDetails.CPUNumber = inputStream.ReadLine();
                        Program.productDetails.Condition = inputStream.ReadLine();
                        Program.productDetails.OS = inputStream.ReadLine();
                        Program.productDetails.Platform = inputStream.ReadLine();
                        Program.productDetails.HDDSize = inputStream.ReadLine();
                        Program.productDetails.HDDSpeed = inputStream.ReadLine();
                        Program.productDetails.GPUType = inputStream.ReadLine();
                        Program.productDetails.OpticalDrive = inputStream.ReadLine();
                        Program.productDetails.AudioType = inputStream.ReadLine();
                        Program.productDetails.LAN = inputStream.ReadLine();
                        Program.productDetails.WIFI = inputStream.ReadLine();
                        Program.productDetails.Width = inputStream.ReadLine();
                        Program.productDetails.Height = inputStream.ReadLine();
                        Program.productDetails.Depth = inputStream.ReadLine();
                        Program.productDetails.Weight = inputStream.ReadLine();
                        Program.productDetails.MouseType = inputStream.ReadLine();
                        Program.productDetails.Power = inputStream.ReadLine();
                        Program.productDetails.WebCam = inputStream.ReadLine();

                        inputStream.Close();
                        inputStream.Dispose();
                    }
                    this.Hide();
                    Program.orderForm.Show();
                }
                catch (IOException exception)
                {
                    MessageBox.Show("ERROR" + exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException exception)
                {
                    MessageBox.Show("ERROR " + exception.Message + "\n\nPlease select the appropriate file type", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
