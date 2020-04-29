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
    public partial class addCustomerfrm : Form
    {
        public addCustomerfrm()
        {
            InitializeComponent();
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Homefrm HomeForm = new Homefrm();
            HomeForm.ShowDialog();
            this.Close();
        }

        private void viewInv_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ViewCustomerfrm viewCustomerfrm = new ViewCustomerfrm();
            viewCustomerfrm.ShowDialog();
            this.Close();
        }
    }
}