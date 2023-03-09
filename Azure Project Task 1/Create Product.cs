using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azure_Project_Task_1
{
    public partial class CreateProductPage : Form
    {
        
        ProductEntities _products = new ProductEntities();
        public CreateProductPage()
        {
            InitializeComponent();
        }

        private void CreateProductPage_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
          
        }

        

        private void OkButton_Click(object sender, EventArgs e)
        {
            string InputName = NameTextBox.Text;
            string InputColor = ColorTextBox.Text;
            string InputProductNumber = ProductNumberTextbox.Text.Trim() ;
            string InputWeight = WeightTextbox.Text.Trim();
            string InputPrice = PriceTextBox.Text.Trim();

            if(InputName == "" || InputColor == ""
            || InputProductNumber == "" || InputWeight == "" 
            || InputPrice == "" )
            {
                MessageBox.Show("Fields Can't Be Empty!");
                return;
            }

            Product Data = new Product()
            {
                Name = InputName,
                Color = InputColor,
                ProductNumber = Convert.ToInt32(InputProductNumber),
                Price = Convert.ToDecimal(InputPrice),
                Weight = Convert.ToInt32(InputWeight),
                ModifiedDate = DateTime.Now
            };

            _products.Products.Add(Data);
            _products.SaveChanges();

            Close();
       
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductNumberTextbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void NameTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ProductNumberTextbox_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
