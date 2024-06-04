
namespace Azure_Project_Task_1
{
    partial class CreateProductPage
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
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.MaskedTextBox();
            this.WeightTextbox = new System.Windows.Forms.MaskedTextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ProductNumberLabel = new System.Windows.Forms.Label();
            this.ProductNumberTextbox = new System.Windows.Forms.MaskedTextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(74, 241);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(322, 241);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(75, 23);
            this.CancelButton1.TabIndex = 1;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(219, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(142, 142);
            this.PriceTextBox.Mask = "000000";
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ResetOnSpace = false;
            this.PriceTextBox.Size = new System.Drawing.Size(189, 20);
            this.PriceTextBox.TabIndex = 8;
            // 
            // WeightTextbox
            // 
            this.WeightTextbox.Location = new System.Drawing.Point(142, 181);
            this.WeightTextbox.Mask = "000000";
            this.WeightTextbox.Name = "WeightTextbox";
            this.WeightTextbox.ResetOnSpace = false;
            this.WeightTextbox.Size = new System.Drawing.Size(189, 20);
            this.WeightTextbox.TabIndex = 9;
            this.WeightTextbox.ValidatingType = typeof(int);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(213, 165);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(41, 13);
            this.WeightLabel.TabIndex = 10;
            this.WeightLabel.Text = "Weight";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(219, 126);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 11;
            this.PriceLabel.Text = "Price";
            // 
            // ProductNumberLabel
            // 
            this.ProductNumberLabel.AutoSize = true;
            this.ProductNumberLabel.Location = new System.Drawing.Point(191, 87);
            this.ProductNumberLabel.Name = "ProductNumberLabel";
            this.ProductNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.ProductNumberLabel.TabIndex = 12;
            this.ProductNumberLabel.Text = "Product Number";
            // 
            // ProductNumberTextbox
            // 
            this.ProductNumberTextbox.Location = new System.Drawing.Point(142, 103);
            this.ProductNumberTextbox.Mask = "000000";
            this.ProductNumberTextbox.Name = "ProductNumberTextbox";
            this.ProductNumberTextbox.ResetOnSpace = false;
            this.ProductNumberTextbox.Size = new System.Drawing.Size(189, 20);
            this.ProductNumberTextbox.TabIndex = 13;
            this.ProductNumberTextbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.ProductNumberTextbox_MaskInputRejected_1);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(142, 25);
            this.NameTextBox.MaxLength = 50;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(189, 20);
            this.NameTextBox.TabIndex = 14;
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(142, 64);
            this.ColorTextBox.MaxLength = 15;
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(189, 20);
            this.ColorTextBox.TabIndex = 15;
            // 
            // CreateProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 278);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ProductNumberTextbox);
            this.Controls.Add(this.ProductNumberLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.WeightTextbox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.OkButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProductPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Create Product";
            this.Load += new System.EventHandler(this.CreateProductPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox PriceTextBox;
        private System.Windows.Forms.MaskedTextBox WeightTextbox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ProductNumberLabel;
        private System.Windows.Forms.MaskedTextBox ProductNumberTextbox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox ColorTextBox;
    }
}