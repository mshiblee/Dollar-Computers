namespace Dollar_Computers
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.OrderFormCancelButton = new System.Windows.Forms.Button();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderFormMultilineTextBox = new System.Windows.Forms.TextBox();
            this.OrderFormManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.OrderFormPlatformTextBox = new System.Windows.Forms.TextBox();
            this.OrderFormModelTextBox = new System.Windows.Forms.TextBox();
            this.OrderFormConditionTextBox = new System.Windows.Forms.TextBox();
            this.OrderFormPlatformLabel = new System.Windows.Forms.Label();
            this.OrderFormModelLabel = new System.Windows.Forms.Label();
            this.OrderFormManufacturerLabel = new System.Windows.Forms.Label();
            this.OrderFormConditionLabel = new System.Windows.Forms.Label();
            this.YourPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.TotalLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.OrderFormPictureBox = new System.Windows.Forms.PictureBox();
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.OrderFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LCDLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.YourPriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFormPictureBox)).BeginInit();
            this.OrderFormMenuStrip.SuspendLayout();
            this.OrderFormTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(504, 476);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(72, 28);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(681, 476);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(2);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(72, 28);
            this.FinishButton.TabIndex = 5;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // OrderFormCancelButton
            // 
            this.OrderFormCancelButton.Location = new System.Drawing.Point(592, 476);
            this.OrderFormCancelButton.Name = "OrderFormCancelButton";
            this.OrderFormCancelButton.Size = new System.Drawing.Size(75, 28);
            this.OrderFormCancelButton.TabIndex = 6;
            this.OrderFormCancelButton.Text = "Cancel";
            this.OrderFormCancelButton.UseVisualStyleBackColor = true;
            this.OrderFormCancelButton.Click += new System.EventHandler(this.OrderFormCancelButton_Click);
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormTableLayoutPanel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormMultilineTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormManufacturerTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormPlatformTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormModelTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormConditionTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormPlatformLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormModelLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormManufacturerLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormConditionLabel);
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(12, 35);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(455, 469);
            this.SystemComponentsGroupBox.TabIndex = 7;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            // 
            // OrderFormMultilineTextBox
            // 
            this.OrderFormMultilineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFormMultilineTextBox.Location = new System.Drawing.Point(181, 138);
            this.OrderFormMultilineTextBox.Multiline = true;
            this.OrderFormMultilineTextBox.Name = "OrderFormMultilineTextBox";
            this.OrderFormMultilineTextBox.Size = new System.Drawing.Size(234, 325);
            this.OrderFormMultilineTextBox.TabIndex = 18;
            // 
            // OrderFormManufacturerTextBox
            // 
            this.OrderFormManufacturerTextBox.Location = new System.Drawing.Point(119, 74);
            this.OrderFormManufacturerTextBox.Name = "OrderFormManufacturerTextBox";
            this.OrderFormManufacturerTextBox.Size = new System.Drawing.Size(117, 26);
            this.OrderFormManufacturerTextBox.TabIndex = 7;
            // 
            // OrderFormPlatformTextBox
            // 
            this.OrderFormPlatformTextBox.Location = new System.Drawing.Point(316, 39);
            this.OrderFormPlatformTextBox.Name = "OrderFormPlatformTextBox";
            this.OrderFormPlatformTextBox.Size = new System.Drawing.Size(117, 26);
            this.OrderFormPlatformTextBox.TabIndex = 6;
            // 
            // OrderFormModelTextBox
            // 
            this.OrderFormModelTextBox.Location = new System.Drawing.Point(316, 77);
            this.OrderFormModelTextBox.Name = "OrderFormModelTextBox";
            this.OrderFormModelTextBox.Size = new System.Drawing.Size(117, 26);
            this.OrderFormModelTextBox.TabIndex = 5;
            // 
            // OrderFormConditionTextBox
            // 
            this.OrderFormConditionTextBox.Location = new System.Drawing.Point(119, 39);
            this.OrderFormConditionTextBox.Name = "OrderFormConditionTextBox";
            this.OrderFormConditionTextBox.Size = new System.Drawing.Size(117, 26);
            this.OrderFormConditionTextBox.TabIndex = 4;
            // 
            // OrderFormPlatformLabel
            // 
            this.OrderFormPlatformLabel.AutoSize = true;
            this.OrderFormPlatformLabel.Location = new System.Drawing.Point(242, 42);
            this.OrderFormPlatformLabel.Name = "OrderFormPlatformLabel";
            this.OrderFormPlatformLabel.Size = new System.Drawing.Size(68, 20);
            this.OrderFormPlatformLabel.TabIndex = 3;
            this.OrderFormPlatformLabel.Text = "Platform";
            // 
            // OrderFormModelLabel
            // 
            this.OrderFormModelLabel.AutoSize = true;
            this.OrderFormModelLabel.Location = new System.Drawing.Point(258, 77);
            this.OrderFormModelLabel.Name = "OrderFormModelLabel";
            this.OrderFormModelLabel.Size = new System.Drawing.Size(52, 20);
            this.OrderFormModelLabel.TabIndex = 2;
            this.OrderFormModelLabel.Text = "Model";
            // 
            // OrderFormManufacturerLabel
            // 
            this.OrderFormManufacturerLabel.AutoSize = true;
            this.OrderFormManufacturerLabel.Location = new System.Drawing.Point(9, 74);
            this.OrderFormManufacturerLabel.Name = "OrderFormManufacturerLabel";
            this.OrderFormManufacturerLabel.Size = new System.Drawing.Size(104, 20);
            this.OrderFormManufacturerLabel.TabIndex = 1;
            this.OrderFormManufacturerLabel.Text = "Manufacturer";
            // 
            // OrderFormConditionLabel
            // 
            this.OrderFormConditionLabel.AutoSize = true;
            this.OrderFormConditionLabel.Location = new System.Drawing.Point(37, 42);
            this.OrderFormConditionLabel.Name = "OrderFormConditionLabel";
            this.OrderFormConditionLabel.Size = new System.Drawing.Size(76, 20);
            this.OrderFormConditionLabel.TabIndex = 0;
            this.OrderFormConditionLabel.Text = "Condition";
            // 
            // YourPriceGroupBox
            // 
            this.YourPriceGroupBox.Controls.Add(this.TotalPriceTextBox);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.YourPriceGroupBox.Controls.Add(this.PriceTextBox);
            this.YourPriceGroupBox.Controls.Add(this.TotalLabel);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourPriceGroupBox.Controls.Add(this.PriceLabel);
            this.YourPriceGroupBox.Controls.Add(this.shapeContainer1);
            this.YourPriceGroupBox.Location = new System.Drawing.Point(472, 213);
            this.YourPriceGroupBox.Name = "YourPriceGroupBox";
            this.YourPriceGroupBox.Size = new System.Drawing.Size(300, 194);
            this.YourPriceGroupBox.TabIndex = 8;
            this.YourPriceGroupBox.TabStop = false;
            this.YourPriceGroupBox.Text = "Your Price";
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.Location = new System.Drawing.Point(161, 140);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.Size = new System.Drawing.Size(133, 26);
            this.TotalPriceTextBox.TabIndex = 5;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(161, 72);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.Size = new System.Drawing.Size(133, 26);
            this.SalesTaxTextBox.TabIndex = 4;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(161, 34);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(133, 26);
            this.PriceTextBox.TabIndex = 3;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(27, 143);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(44, 20);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(27, 75);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(124, 20);
            this.SalesTaxLabel.TabIndex = 1;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(27, 37);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(44, 20);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 22);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.TotalLine});
            this.shapeContainer1.Size = new System.Drawing.Size(294, 169);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // TotalLine
            // 
            this.TotalLine.BorderWidth = 2;
            this.TotalLine.Name = "TotalLine";
            this.TotalLine.X1 = 16;
            this.TotalLine.X2 = 292;
            this.TotalLine.Y1 = 99;
            this.TotalLine.Y2 = 99;
            // 
            // OrderFormPictureBox
            // 
            this.OrderFormPictureBox.Location = new System.Drawing.Point(504, 74);
            this.OrderFormPictureBox.Name = "OrderFormPictureBox";
            this.OrderFormPictureBox.Size = new System.Drawing.Size(183, 119);
            this.OrderFormPictureBox.TabIndex = 9;
            this.OrderFormPictureBox.TabStop = false;
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.OrderFormMenuStrip.TabIndex = 10;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OrderFormCancelButton_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.backToolStripMenuItem.Text = "&Back";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // OrderFormTableLayoutPanel
            // 
            this.OrderFormTableLayoutPanel.ColumnCount = 1;
            this.OrderFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OrderFormTableLayoutPanel.Controls.Add(this.LCDLabel, 0, 0);
            this.OrderFormTableLayoutPanel.Controls.Add(this.MemoryLabel, 0, 1);
            this.OrderFormTableLayoutPanel.Controls.Add(this.OSLabel, 0, 9);
            this.OrderFormTableLayoutPanel.Controls.Add(this.CPUBrandLabel, 0, 2);
            this.OrderFormTableLayoutPanel.Controls.Add(this.WebCamLabel, 0, 8);
            this.OrderFormTableLayoutPanel.Controls.Add(this.CPUTypeLabel, 0, 3);
            this.OrderFormTableLayoutPanel.Controls.Add(this.GPUTypeLabel, 0, 7);
            this.OrderFormTableLayoutPanel.Controls.Add(this.CPUNumberLabel, 0, 4);
            this.OrderFormTableLayoutPanel.Controls.Add(this.HDDLabel, 0, 6);
            this.OrderFormTableLayoutPanel.Controls.Add(this.CPUSpeedLabel, 0, 5);
            this.OrderFormTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFormTableLayoutPanel.Location = new System.Drawing.Point(24, 138);
            this.OrderFormTableLayoutPanel.Name = "OrderFormTableLayoutPanel";
            this.OrderFormTableLayoutPanel.RowCount = 10;
            this.OrderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderFormTableLayoutPanel.Size = new System.Drawing.Size(139, 325);
            this.OrderFormTableLayoutPanel.TabIndex = 21;
            // 
            // LCDLabel
            // 
            this.LCDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDLabel.Location = new System.Drawing.Point(3, 0);
            this.LCDLabel.Name = "LCDLabel";
            this.LCDLabel.Size = new System.Drawing.Size(133, 24);
            this.LCDLabel.TabIndex = 9;
            this.LCDLabel.Text = "LCD Size:";
            this.LCDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.Location = new System.Drawing.Point(3, 32);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(133, 24);
            this.MemoryLabel.TabIndex = 10;
            this.MemoryLabel.Text = "Memory:";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OSLabel
            // 
            this.OSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.Location = new System.Drawing.Point(3, 288);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(133, 30);
            this.OSLabel.TabIndex = 18;
            this.OSLabel.Text = "OS:";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandLabel.Location = new System.Drawing.Point(3, 64);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(133, 24);
            this.CPUBrandLabel.TabIndex = 11;
            this.CPUBrandLabel.Text = "CPU Brand:";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebCamLabel.Location = new System.Drawing.Point(3, 256);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(133, 26);
            this.WebCamLabel.TabIndex = 17;
            this.WebCamLabel.Text = "Web Cam:";
            this.WebCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeLabel.Location = new System.Drawing.Point(3, 96);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(133, 24);
            this.CPUTypeLabel.TabIndex = 12;
            this.CPUTypeLabel.Text = "CPU Type:";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeLabel.Location = new System.Drawing.Point(3, 224);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(133, 24);
            this.GPUTypeLabel.TabIndex = 16;
            this.GPUTypeLabel.Text = "GPU Type:";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberLabel.Location = new System.Drawing.Point(3, 128);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(133, 24);
            this.CPUNumberLabel.TabIndex = 13;
            this.CPUNumberLabel.Text = "CPU Number:";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDLabel.Location = new System.Drawing.Point(3, 192);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(133, 24);
            this.HDDLabel.TabIndex = 15;
            this.HDDLabel.Text = "HDD:";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedLabel.Location = new System.Drawing.Point(3, 160);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(133, 25);
            this.CPUSpeedLabel.TabIndex = 14;
            this.CPUSpeedLabel.Text = "CPU Speed:";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 516);
            this.ControlBox = false;
            this.Controls.Add(this.OrderFormPictureBox);
            this.Controls.Add(this.YourPriceGroupBox);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.OrderFormCancelButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Order Form";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.SystemComponentsGroupBox.PerformLayout();
            this.YourPriceGroupBox.ResumeLayout(false);
            this.YourPriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFormPictureBox)).EndInit();
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.OrderFormTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button OrderFormCancelButton;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.TextBox OrderFormManufacturerTextBox;
        private System.Windows.Forms.TextBox OrderFormPlatformTextBox;
        private System.Windows.Forms.TextBox OrderFormModelTextBox;
        private System.Windows.Forms.TextBox OrderFormConditionTextBox;
        private System.Windows.Forms.Label OrderFormPlatformLabel;
        private System.Windows.Forms.Label OrderFormModelLabel;
        private System.Windows.Forms.Label OrderFormManufacturerLabel;
        private System.Windows.Forms.Label OrderFormConditionLabel;
        private System.Windows.Forms.GroupBox YourPriceGroupBox;
        private System.Windows.Forms.TextBox OrderFormMultilineTextBox;
        private System.Windows.Forms.TextBox TotalPriceTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.PictureBox OrderFormPictureBox;
        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape TotalLine;
        private System.Windows.Forms.TableLayoutPanel OrderFormTableLayoutPanel;
        private System.Windows.Forms.Label LCDLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
    }
}