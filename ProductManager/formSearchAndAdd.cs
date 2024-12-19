using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketplaceManagement
{
    public partial class formSearchAndAdd : Form
    {
        public formSearchAndAdd()
        {
            InitializeComponent();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            formAddProduct formAddProduct = new formAddProduct();
            formAddProduct.Show();
            this.Hide();

        }

        private void returnButtonControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
