namespace Dollar_Computers
{
    partial class SelectForm
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
            this.SelectFormNextButton = new System.Windows.Forms.Button();
            this.SelectFormCancelButton = new System.Windows.Forms.Button();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.ListTextBox = new System.Windows.Forms.TextBox();
            this.SelectionTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectFormNextButton
            // 
            this.SelectFormNextButton.Location = new System.Drawing.Point(681, 522);
            this.SelectFormNextButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectFormNextButton.Name = "SelectFormNextButton";
            this.SelectFormNextButton.Size = new System.Drawing.Size(92, 28);
            this.SelectFormNextButton.TabIndex = 0;
            this.SelectFormNextButton.Text = "Next";
            this.SelectFormNextButton.UseVisualStyleBackColor = true;
            this.SelectFormNextButton.Click += new System.EventHandler(this.SelectFormNextButton_Click);
            // 
            // SelectFormCancelButton
            // 
            this.SelectFormCancelButton.Location = new System.Drawing.Point(575, 522);
            this.SelectFormCancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectFormCancelButton.Name = "SelectFormCancelButton";
            this.SelectFormCancelButton.Size = new System.Drawing.Size(92, 28);
            this.SelectFormCancelButton.TabIndex = 1;
            this.SelectFormCancelButton.Text = "Cancel";
            this.SelectFormCancelButton.UseVisualStyleBackColor = true;
            this.SelectFormCancelButton.Click += new System.EventHandler(this.SelectFormCancelButton_Click);
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Location = new System.Drawing.Point(8, 525);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(113, 20);
            this.SelectionLabel.TabIndex = 2;
            this.SelectionLabel.Text = "Your Selection";
            // 
            // ListTextBox
            // 
            this.ListTextBox.Location = new System.Drawing.Point(12, 12);
            this.ListTextBox.Name = "ListTextBox";
            this.ListTextBox.Size = new System.Drawing.Size(236, 26);
            this.ListTextBox.TabIndex = 3;
            this.ListTextBox.Text = "Dollar Computer Hardware List";
            // 
            // SelectionTextBox
            // 
            this.SelectionTextBox.Location = new System.Drawing.Point(127, 522);
            this.SelectionTextBox.Name = "SelectionTextBox";
            this.SelectionTextBox.Size = new System.Drawing.Size(429, 26);
            this.SelectionTextBox.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 446);
            this.dataGridView1.TabIndex = 5;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SelectionTextBox);
            this.Controls.Add(this.ListTextBox);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.SelectFormCancelButton);
            this.Controls.Add(this.SelectFormNextButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFormNextButton;
        private System.Windows.Forms.Button SelectFormCancelButton;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.TextBox ListTextBox;
        private System.Windows.Forms.TextBox SelectionTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}