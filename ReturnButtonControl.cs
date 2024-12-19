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
    public partial class ReturnButtonControl : UserControl
    {
        public ReturnButtonControl()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Ana forma geri dön
            if (MainForm.Instance != null)
            {
                this.FindForm()?.Hide(); // Şu anki formu gizle
                MainForm.Instance.Show(); // Ana formu göster
            }
        }
    }
}
