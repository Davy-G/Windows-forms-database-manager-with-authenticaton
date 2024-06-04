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
    public partial class UpdateProduct : Form
    {

        ProductEntities _products = new ProductEntities();
      
        int Id { get; set; }
        public UpdateProduct(string id)
        {
            InitializeComponent();
            Id = Convert.ToInt32( id);
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            IdLabel.Text = Id.ToString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            
                string InputName = NameTextBox.Text;
                string InputColor = ColorTextBox.Text;
                string InputProductNumber = ProductNumberTextbox.Text.Trim();
                string InputWeight = WeightTextbox.Text.Trim();
                string InputPrice = PriceTextBox.Text.Trim();

                if (InputName == "" || InputColor == ""
                || InputProductNumber == "" || InputWeight == ""
                || InputPrice == "")
                {
                    MessageBox.Show("Fields Can't Be Empty!");
                    return;
                }

                var Item = _products.Products.Find(Id);


                Item.Name = InputName;
                Item.Color = InputColor;
                Item.ProductNumber = Convert.ToInt32(InputProductNumber);
                Item.Price = Convert.ToDecimal(InputPrice);
                Item.Weight = Convert.ToInt32(InputWeight);
                Item.ModifiedDate = DateTime.Now;     
                _products.SaveChanges();
                Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
