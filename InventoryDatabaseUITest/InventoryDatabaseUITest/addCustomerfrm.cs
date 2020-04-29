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

<<<<<<< HEAD
=======
        private void viewInv_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCustomerfrm ViewCustomerForm = new ViewCustomerfrm();
            ViewCustomerForm.ShowDialog();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homefrm HomeForm = new Homefrm();
            HomeForm.ShowDialog();
            this.Close();
        }


>>>>>>> a83a6973d409f01f4150474ecaea6b5969aa7604
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