using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//code used from IamTimCorey youtube video https://www.youtube.com/watch?v=Et2khGnrIqc&list=PLLWMQd6PeGY3b89Ni7xsNZddi9wD5Esv2

namespace InventoryDatabaseUITest
{
    public partial class Homefrm : Form
    {
        public Homefrm()
        {
            InitializeComponent();
        }

        private void addStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            addStockfrm addStockform = new addStockfrm();
            addStockform.ShowDialog();
            this.Close();

        }

        private void viewInv_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewInventoryfrm ViewInventoryForm = new ViewInventoryfrm();
            ViewInventoryForm.ShowDialog();
            this.Close();
        }

        private void viewCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCustomerfrm viewCustomerfrm = new ViewCustomerfrm();
            viewCustomerfrm.ShowDialog();
            this.Close();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            addCustomerfrm AddCustomerForm = new addCustomerfrm();
            AddCustomerForm.ShowDialog();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCustomer_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            addCustomerfrm AddCustomerForm = new addCustomerfrm();
            AddCustomerForm.ShowDialog();
            this.Close();
        }
    }
}
