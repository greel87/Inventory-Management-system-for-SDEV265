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
        //updates the DataGridView with currently pulled information
        private void UpdateBinding()
        {

            customerDatagridView.DataSource = customer;
        }



        private void custBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homefrm HomeForm = new Homefrm();
            HomeForm.ShowDialog();
            this.Close();
        }
        // call to queryLib to execute select query
        private void custSearchbtn_Click(object sender, EventArgs e)
        {
            queryLib query = new queryLib();

            customer = query.GetCustomers(Lnametxtbx.Text);
            UpdateBinding();
        }

        //call to print to print the form
        // code taken from https://stackoverflow.com/questions/15853746/how-to-print-values-from-a-datagridview-control/15853845
        //first answer
        private void printBtn_Click(object sender, EventArgs e)
        {
            printCls _printCLS = new printCls(customerDatagridView, "Customer");
            _printCLS.PrintForm();
        }
    }
}
    
