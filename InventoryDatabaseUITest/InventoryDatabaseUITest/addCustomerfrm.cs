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


    }
}