
namespace Azure_Project_Task_1
{
    partial class Databaseshower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Databaseshower));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LoadProducts = new System.Windows.Forms.Button();
            this.UpdateProduct = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.CreateProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // LoadProducts
            // 
            this.LoadProducts.Location = new System.Drawing.Point(12, 283);
            this.LoadProducts.Name = "LoadProducts";
            this.LoadProducts.Size = new System.Drawing.Size(150, 23);
            this.LoadProducts.TabIndex = 1;
            this.LoadProducts.Text = "Load Products";
            this.LoadProducts.UseVisualStyleBackColor = true;
            this.LoadProducts.Click += new System.EventHandler(this.LoadProducts_Click);
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.Location = new System.Drawing.Point(230, 283);
            this.UpdateProduct.Name = "UpdateProduct";
            this.UpdateProduct.Size = new System.Drawing.Size(133, 23);
            this.UpdateProduct.TabIndex = 2;
            this.UpdateProduct.Text = "Update Product";
            this.UpdateProduct.UseVisualStyleBackColor = true;
            this.UpdateProduct.Click += new System.EventHandler(this.UpdateProduct_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Location = new System.Drawing.Point(454, 283);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(142, 23);
            this.DeleteProduct.TabIndex = 3;
            this.DeleteProduct.Text = "Delete Product";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // CreateProduct
            // 
            this.CreateProduct.Location = new System.Drawing.Point(668, 283);
            this.CreateProduct.Name = "CreateProduct";
            this.CreateProduct.Size = new System.Drawing.Size(120, 23);
            this.CreateProduct.TabIndex = 4;
            this.CreateProduct.Text = "Create New Product";
            this.CreateProduct.UseVisualStyleBackColor = true;
            this.CreateProduct.Click += new System.EventHandler(this.CreateProduct_Click);
            // 
            // Databaseshower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.CreateProduct);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.UpdateProduct);
            this.Controls.Add(this.LoadProducts);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Databaseshower";
            this.Text = "Database shower";
            this.Load += new System.EventHandler(this.Database_shower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LoadProducts;
        private System.Windows.Forms.Button UpdateProduct;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button CreateProduct;
    }
}