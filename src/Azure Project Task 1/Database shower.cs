using System;
using System.Windows.Forms;
using System.Linq;
using System.Data;


namespace Azure_Project_Task_1
{


    public partial class Databaseshower : Form
    {


        public Databaseshower()
        {
            InitializeComponent();
        }

        public void UpdateDatagrid()
        {
            using (ProductEntities _products = new ProductEntities())
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = _products.Products.ToList();
            }
        }




        private void Database_shower_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void LoadProducts_Click(object sender, EventArgs e)
        {
            UpdateDatagrid();
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var Upd = new UpdateProduct(
                    dataGridView1.SelectedRows[0]
                    .Cells[0]
                    .Value.ToString());
                Upd.ShowDialog();

            }
            catch (Exception)
            {
                MessageBox.Show("Error, Probably You Forgot To Select A row");
                return;
            }

       
            UpdateDatagrid();




        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {

                ProductEntities _products = new ProductEntities();
            try
            {
                int Id = Convert.ToInt32(dataGridView1.SelectedRows[0]
                   .Cells[0]
                   .Value
                   .ToString());
                var ItemToDel = _products.Products.Find(Id);
                _products.Products.Remove(ItemToDel);
                _products.SaveChanges();
                UpdateDatagrid();
            }

            catch (Exception)
            {
                MessageBox.Show("Error, Perhaps You Forgot To Select a Row");
            }
                   
         
               



        }


        private void CreateProduct_Click(object sender, EventArgs e)
        {
            var CreateProductPg = new CreateProductPage();
            CreateProductPg.ShowDialog();
            UpdateDatagrid();


        }
    }
}
 