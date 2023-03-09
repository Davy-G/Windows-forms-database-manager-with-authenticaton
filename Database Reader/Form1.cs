using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Reader
{
    public partial class DatabaseViewer : Form
    {
        
        
        public DatabaseViewer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)

        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            
        }
    }
}
