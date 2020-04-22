using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryDatabaseUITest
{
   
    public partial class addStockfrm : Form
    {
        Homefrm homefrm = new Homefrm();
        public addStockfrm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            
            homefrm.Show();
            this.Close();
        }
    }
}
