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
// This form contains buttons to take user to different forms based on what they want to do
namespace InventoryDatabaseUITest
{
    public partial class Homefrm : Form
    {
        public Homefrm()
        {
            InitializeComponent();
        }
        private void addStockbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            addStockfrm addStockform = new addStockfrm();
            addStockform.ShowDialog();
            this.Close();
        }

        private void viewInvbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewInventoryfrm ViewInventoryForm = new ViewInventoryfrm();
            ViewInventoryForm.ShowDialog();
            this.Close();
        }

        private void viewCustbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCustomerfrm viewCustomerfrm = new ViewCustomerfrm();
            viewCustomerfrm.ShowDialog();
            this.Close();
        }

        private void addCustomerbtn_Click(object sender, EventArgs e)
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

        private void UPC_Click(object sender, EventArgs e)
        {
            this.Hide();
            UPCfrm UPCForm = new UPCfrm();
            UPCForm.ShowDialog();
            this.Close();
        }
    }
}
