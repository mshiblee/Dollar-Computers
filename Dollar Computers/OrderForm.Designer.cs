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
            this.BackButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.OrderFormCancelButton = new System.Windows.Forms.Button();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.YourPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderFormConditionLabel = new System.Windows.Forms.Label();
            this.OrderFormManufacturerLabel = new System.Windows.Forms.Label();
            this.OrderFormModelLabel = new System.Windows.Forms.Label();
            this.OrderFormPlatformLabel = new System.Windows.Forms.Label();
            this.OrderFormConditionTextBox = new System.Windows.Forms.TextBox();
            this.OrderFormModelTextBox = new System.Windows.Forms.TextBox();
            this.OrderFormPlatformTextBox = new System.Windows.Forms.TextBox();
            this.OrderFormManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.OrderFormOSLabel = new System.Windows.Forms.Label();
            this.OrderFormWebCamLabel = new System.Windows.Forms.Label();
            this.OrderFormGPUTypeLabel = new System.Windows.Forms.Label();
            this.OrderFormHDDLabel = new System.Windows.Forms.Label();
            this.OrderFormCPUSpeedLabel = new System.Windows.Forms.Label();
            this.OrderFormCPUNumberLabel = new System.Windows.Forms.Label();
            this.OrderFormCPUTypeLabel = new System.Windows.Forms.Label();
            this.OrderFormCPUBrandLabel = new System.Windows.Forms.Label();
            this.OrderFormMemoryLabel = new System.Windows.Forms.Label();
            this.OrderFormLCDSizeLabel = new System.Windows.Forms.Label();
            this.OrderFormMultilineTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.OrderFormPictureBox = new System.Windows.Forms.PictureBox();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.YourPriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(524, 522);
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
            this.FinishButton.Location = new System.Drawing.Point(701, 522);
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
            this.OrderFormCancelButton.Location = new System.Drawing.Point(612, 522);
            this.OrderFormCancelButton.Name = "OrderFormCancelButton";
            this.OrderFormCancelButton.Size = new System.Drawing.Size(75, 28);
            this.OrderFormCancelButton.TabIndex = 6;
            this.OrderFormCancelButton.Text = "Cancel";
            this.OrderFormCancelButton.UseVisualStyleBackColor = true;
            this.OrderFormCancelButton.Click += new System.EventHandler(this.OrderFormCancelButton_Click);
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormMultilineTextBox);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormLCDSizeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormMemoryLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormCPUBrandLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormCPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormCPUNumberLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormCPUSpeedLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormHDDLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormGPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormWebCamLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderFormOSLabel);
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
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(455, 515);
            this.SystemComponentsGroupBox.TabIndex = 7;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            // 
            // YourPriceGroupBox
            // 
            this.YourPriceGroupBox.Controls.Add(this.TotalTextBox);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxTextBox);
            this.YourPriceGroupBox.Controls.Add(this.PriceTextBox);
            this.YourPriceGroupBox.Controls.Add(this.TotalLabel);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourPriceGroupBox.Controls.Add(this.PriceLabel);
            this.YourPriceGroupBox.Location = new System.Drawing.Point(473, 296);
            this.YourPriceGroupBox.Name = "YourPriceGroupBox";
            this.YourPriceGroupBox.Size = new System.Drawing.Size(300, 194);
            this.YourPriceGroupBox.TabIndex = 8;
            this.YourPriceGroupBox.TabStop = false;
            this.YourPriceGroupBox.Text = "Your Price";
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
            // OrderFormManufacturerLabel
            // 
            this.OrderFormManufacturerLabel.AutoSize = true;
            this.OrderFormManufacturerLabel.Location = new System.Drawing.Point(9, 74);
            this.OrderFormManufacturerLabel.Name = "OrderFormManufacturerLabel";
            this.OrderFormManufacturerLabel.Size = new System.Drawing.Size(104, 20);
            this.OrderFormManufacturerLabel.TabIndex = 1;
            this.OrderFormManufacturerLabel.Text = "Manufacturer";
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
            // OrderFormPlatformLabel
            // 
            this.OrderFormPlatformLabel.AutoSize = true;
            this.OrderFormPlatformLabel.Location = new System.Drawing.Point(242, 42);
            this.OrderFormPlatformLabel.Name = "OrderFormPlatformLabel";
            this.OrderFormPlatformLabel.Size = new System.Drawing.Size(68, 20);
            this.OrderFormPlatformLabel.TabIndex = 3;
            this.OrderFormPlatformLabel.Text = "Platform";
            // 
            // OrderFormConditionTextBox
            // 
            this.OrderFormConditionTextBox.Location = new System.Drawing.Point(119, 39);
            this.OrderFormConditionTextBox.Name = "OrderFormConditionTextBox";
            this.OrderFormConditionTextBox.Size = new System.Drawing.Size(117, 26);
            this.OrderFormConditionTextBox.TabIndex = 4;
            // 
            // OrderFormModelTextBox
            // 
            this.OrderFormModelTextBox.Location = new System.Drawing.Point(316, 77);
            this.OrderFormModelTextBox.Name = "OrderFormModelTextBox";
            this.OrderFormModelTextBox.Size = new System.Drawing.Size(117, 26);
            this.OrderFormModelTextBox.TabIndex = 5;
            // 
            // OrderFormPlatformTextBox
            // 
            this.OrderFormPlatformTextBox.Location = new System.Drawing.Point(316, 39);
            this.OrderFormPlatformTextBox.Name = "OrderFormPlatformTextBox";
            this.OrderFormPlatformTextBox.Size = new System.Drawing.Size(117, 26);
            this.OrderFormPlatformTextBox.TabIndex = 6;
            // 
            // OrderFormManufacturerTextBox
            // 
            this.OrderFormManufacturerTextBox.Location = new System.Drawing.Point(119, 74);
            this.OrderFormManufacturerTextBox.Name = "OrderFormManufacturerTextBox";
            this.OrderFormManufacturerTextBox.Size = new System.Drawing.Size(117, 26);
            this.OrderFormManufacturerTextBox.TabIndex = 7;
            // 
            // OrderFormOSLabel
            // 
            this.OrderFormOSLabel.AutoSize = true;
            this.OrderFormOSLabel.Location = new System.Drawing.Point(80, 469);
            this.OrderFormOSLabel.Name = "OrderFormOSLabel";
            this.OrderFormOSLabel.Size = new System.Drawing.Size(32, 20);
            this.OrderFormOSLabel.TabIndex = 8;
            this.OrderFormOSLabel.Text = "OS";
            // 
            // OrderFormWebCamLabel
            // 
            this.OrderFormWebCamLabel.AutoSize = true;
            this.OrderFormWebCamLabel.Location = new System.Drawing.Point(38, 435);
            this.OrderFormWebCamLabel.Name = "OrderFormWebCamLabel";
            this.OrderFormWebCamLabel.Size = new System.Drawing.Size(75, 20);
            this.OrderFormWebCamLabel.TabIndex = 9;
            this.OrderFormWebCamLabel.Text = "WebCam";
            // 
            // OrderFormGPUTypeLabel
            // 
            this.OrderFormGPUTypeLabel.AutoSize = true;
            this.OrderFormGPUTypeLabel.Location = new System.Drawing.Point(31, 394);
            this.OrderFormGPUTypeLabel.Name = "OrderFormGPUTypeLabel";
            this.OrderFormGPUTypeLabel.Size = new System.Drawing.Size(82, 20);
            this.OrderFormGPUTypeLabel.TabIndex = 10;
            this.OrderFormGPUTypeLabel.Text = "GPU Type";
            // 
            // OrderFormHDDLabel
            // 
            this.OrderFormHDDLabel.AutoSize = true;
            this.OrderFormHDDLabel.Location = new System.Drawing.Point(67, 360);
            this.OrderFormHDDLabel.Name = "OrderFormHDDLabel";
            this.OrderFormHDDLabel.Size = new System.Drawing.Size(45, 20);
            this.OrderFormHDDLabel.TabIndex = 11;
            this.OrderFormHDDLabel.Text = "HDD";
            // 
            // OrderFormCPUSpeedLabel
            // 
            this.OrderFormCPUSpeedLabel.AutoSize = true;
            this.OrderFormCPUSpeedLabel.Location = new System.Drawing.Point(20, 326);
            this.OrderFormCPUSpeedLabel.Name = "OrderFormCPUSpeedLabel";
            this.OrderFormCPUSpeedLabel.Size = new System.Drawing.Size(93, 20);
            this.OrderFormCPUSpeedLabel.TabIndex = 12;
            this.OrderFormCPUSpeedLabel.Text = "CPU Speed";
            // 
            // OrderFormCPUNumberLabel
            // 
            this.OrderFormCPUNumberLabel.AutoSize = true;
            this.OrderFormCPUNumberLabel.Location = new System.Drawing.Point(11, 280);
            this.OrderFormCPUNumberLabel.Name = "OrderFormCPUNumberLabel";
            this.OrderFormCPUNumberLabel.Size = new System.Drawing.Size(102, 20);
            this.OrderFormCPUNumberLabel.TabIndex = 13;
            this.OrderFormCPUNumberLabel.Text = "CPU Number";
            // 
            // OrderFormCPUTypeLabel
            // 
            this.OrderFormCPUTypeLabel.AutoSize = true;
            this.OrderFormCPUTypeLabel.Location = new System.Drawing.Point(33, 247);
            this.OrderFormCPUTypeLabel.Name = "OrderFormCPUTypeLabel";
            this.OrderFormCPUTypeLabel.Size = new System.Drawing.Size(80, 20);
            this.OrderFormCPUTypeLabel.TabIndex = 14;
            this.OrderFormCPUTypeLabel.Text = "CPU Type";
            // 
            // OrderFormCPUBrandLabel
            // 
            this.OrderFormCPUBrandLabel.AutoSize = true;
            this.OrderFormCPUBrandLabel.Location = new System.Drawing.Point(24, 212);
            this.OrderFormCPUBrandLabel.Name = "OrderFormCPUBrandLabel";
            this.OrderFormCPUBrandLabel.Size = new System.Drawing.Size(89, 20);
            this.OrderFormCPUBrandLabel.TabIndex = 15;
            this.OrderFormCPUBrandLabel.Text = "CPU Brand";
            // 
            // OrderFormMemoryLabel
            // 
            this.OrderFormMemoryLabel.AutoSize = true;
            this.OrderFormMemoryLabel.Location = new System.Drawing.Point(47, 174);
            this.OrderFormMemoryLabel.Name = "OrderFormMemoryLabel";
            this.OrderFormMemoryLabel.Size = new System.Drawing.Size(65, 20);
            this.OrderFormMemoryLabel.TabIndex = 16;
            this.OrderFormMemoryLabel.Text = "Memory";
            // 
            // OrderFormLCDSizeLabel
            // 
            this.OrderFormLCDSizeLabel.AutoSize = true;
            this.OrderFormLCDSizeLabel.Location = new System.Drawing.Point(37, 138);
            this.OrderFormLCDSizeLabel.Name = "OrderFormLCDSizeLabel";
            this.OrderFormLCDSizeLabel.Size = new System.Drawing.Size(76, 20);
            this.OrderFormLCDSizeLabel.TabIndex = 17;
            this.OrderFormLCDSizeLabel.Text = "LCD Size";
            // 
            // OrderFormMultilineTextBox
            // 
            this.OrderFormMultilineTextBox.Location = new System.Drawing.Point(119, 138);
            this.OrderFormMultilineTextBox.Multiline = true;
            this.OrderFormMultilineTextBox.Name = "OrderFormMultilineTextBox";
            this.OrderFormMultilineTextBox.Size = new System.Drawing.Size(314, 351);
            this.OrderFormMultilineTextBox.TabIndex = 18;
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
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(27, 75);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(124, 20);
            this.SalesTaxLabel.TabIndex = 1;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
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
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(161, 34);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(133, 26);
            this.PriceTextBox.TabIndex = 3;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(161, 72);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.Size = new System.Drawing.Size(133, 26);
            this.SalesTaxTextBox.TabIndex = 4;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(161, 140);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(133, 26);
            this.TotalTextBox.TabIndex = 5;
            // 
            // OrderFormPictureBox
            // 
            this.OrderFormPictureBox.Location = new System.Drawing.Point(504, 74);
            this.OrderFormPictureBox.Name = "OrderFormPictureBox";
            this.OrderFormPictureBox.Size = new System.Drawing.Size(183, 119);
            this.OrderFormPictureBox.TabIndex = 9;
            this.OrderFormPictureBox.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.OrderFormPictureBox);
            this.Controls.Add(this.YourPriceGroupBox);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.OrderFormCancelButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Order Form";
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.SystemComponentsGroupBox.PerformLayout();
            this.YourPriceGroupBox.ResumeLayout(false);
            this.YourPriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderFormPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button OrderFormCancelButton;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.Label OrderFormLCDSizeLabel;
        private System.Windows.Forms.Label OrderFormMemoryLabel;
        private System.Windows.Forms.Label OrderFormCPUBrandLabel;
        private System.Windows.Forms.Label OrderFormCPUTypeLabel;
        private System.Windows.Forms.Label OrderFormCPUNumberLabel;
        private System.Windows.Forms.Label OrderFormCPUSpeedLabel;
        private System.Windows.Forms.Label OrderFormHDDLabel;
        private System.Windows.Forms.Label OrderFormGPUTypeLabel;
        private System.Windows.Forms.Label OrderFormWebCamLabel;
        private System.Windows.Forms.Label OrderFormOSLabel;
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
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.PictureBox OrderFormPictureBox;
    }
}