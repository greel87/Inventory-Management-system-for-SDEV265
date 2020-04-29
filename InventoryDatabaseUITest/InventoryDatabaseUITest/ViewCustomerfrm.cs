using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryDatabaseUITest.DAL;
using InventoryDatabaseUITest.BAL;

//code used from IamTimCorey youtube video https://www.youtube.com/watch?v=Et2khGnrIqc&list=PLLWMQd6PeGY3b89Ni7xsNZddi9wD5Esv2

namespace InventoryDatabaseUITest
{
    public partial class ViewCustomerfrm : Form
    {
        List<customerBAL> customer = new List<customerBAL>();

        public ViewCustomerfrm()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
<<<<<<< HEAD
        { 
=======
        {
>>>>>>> b9745a8d3670a289ad322270eb1dfde48a57adae
            CustomerSearchListBox.DataSource = customer;
            CustomerSearchListBox.DisplayMember = "customerInfofull";
        }


        private void custBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homefrm HomeForm = new Homefrm();
            HomeForm.ShowDialog();
            this.Close();
        }

        private void custSearchbtn_Click(object sender, EventArgs e)
        {
            queryLib query = new queryLib();

            customer = query.GetCustomers(Lnametxtbx.Text);
            UpdateBinding();
        }
    }
}
