
namespace Azure_Project_Task_1
{
    partial class UpdateProduct
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
            this.Updt = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.ProductNumberTextbox = new System.Windows.Forms.MaskedTextBox();
            this.ProductNumberLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextbox = new System.Windows.Forms.MaskedTextBox();
            this.PriceTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(32, 234);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(348, 234);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(75, 23);
            this.CancelButton1.TabIndex = 1;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Updt
            // 
            this.Updt.AutoSize = true;
            this.Updt.Location = new System.Drawing.Point(2, 6);
            this.Updt.Name = "Updt";
            this.Updt.Size = new System.Drawing.Size(130, 13);
            this.Updt.TabIndex = 2;
            this.Updt.Text = "Updating Product With Id:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(131, 6);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(16, 13);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "Id";
            // 
            // ProductNumberTextbox
            // 
            this.ProductNumberTextbox.Location = new System.Drawing.Point(131, 120);
            this.ProductNumberTextbox.Mask = "000000";
            this.ProductNumberTextbox.Name = "ProductNumberTextbox";
            this.ProductNumberTextbox.ResetOnSpace = false;
            this.ProductNumberTextbox.Size = new System.Drawing.Size(189, 20);
            this.ProductNumberTextbox.TabIndex = 23;
            // 
            // ProductNumberLabel
            // 
            this.ProductNumberLabel.AutoSize = true;
            this.ProductNumberLabel.Location = new System.Drawing.Point(180, 104);
            this.ProductNumberLabel.Name = "ProductNumberLabel";
            this.ProductNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.ProductNumberLabel.TabIndex = 22;
            this.ProductNumberLabel.Text = "Product Number";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(208, 143);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 21;
            this.PriceLabel.Text = "Price";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(202, 182);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(41, 13);
            this.WeightLabel.TabIndex = 20;
            this.WeightLabel.Text = "Weight";
            // 
            // WeightTextbox
            // 
            this.WeightTextbox.Location = new System.Drawing.Point(131, 198);
            this.WeightTextbox.Mask = "000000";
            this.WeightTextbox.Name = "WeightTextbox";
            this.WeightTextbox.ResetOnSpace = false;
            this.WeightTextbox.Size = new System.Drawing.Size(189, 20);
            this.WeightTextbox.TabIndex = 19;
            this.WeightTextbox.ValidatingType = typeof(int);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(131, 159);
            this.PriceTextBox.Mask = "000000";
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ResetOnSpace = false;
            this.PriceTextBox.Size = new System.Drawing.Size(189, 20);
            this.PriceTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Color";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(208, 26);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(131, 42);
            this.NameTextBox.MaxLength = 50;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(189, 20);
            this.NameTextBox.TabIndex = 24;
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(131, 81);
            this.ColorTextBox.MaxLength = 15;
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(189, 20);
            this.ColorTextBox.TabIndex = 25;
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 282);
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
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.Updt);
            this.Controls.Add(this.CancelButton1);
            this.Controls.Add(this.OkButton);
            this.Name = "UpdateProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Update Product";
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.Label Updt;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.MaskedTextBox ProductNumberTextbox;
        private System.Windows.Forms.Label ProductNumberLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.MaskedTextBox WeightTextbox;
        private System.Windows.Forms.MaskedTextBox PriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox ColorTextBox;
    }
}