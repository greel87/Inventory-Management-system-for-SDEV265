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

namespace InventoryDatabaseUITest
{
    public partial class ViewInventoryfrm : Form
    {
        //List to store returned items for stock
        List<stockBAL> stock = new List<stockBAL>();

        public ViewInventoryfrm()
        {
            InitializeComponent();
            UpdateBinding();
        }
        //updates the DataGridView with currently pulled information
        private void UpdateBinding()
        {

            stockDatagridVw.DataSource = stock;
        }
        // call to queryLib to get select query
        private void btnViewinventory_Click(object sender, EventArgs e)
        {
            queryLib query = new queryLib();

            stock = query.GetInventory(prodNametxtbx.Text);
            UpdateBinding();

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homefrm HomeForm = new Homefrm();
            HomeForm.ShowDialog();
            this.Close();
        }
        //call to print to print the form
        // code taken from https://stackoverflow.com/questions/15853746/how-to-print-values-from-a-datagridview-control/15853845
        //first answer
        private void print_Click(object sender, EventArgs e)
        {
            printCls _printCLS = new printCls(stockDatagridVw, "Stock");
            _printCLS.PrintForm();
        }
    }
}