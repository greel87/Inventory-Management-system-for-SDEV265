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
        List<stockBAL> stock = new List<stockBAL>();
        
        public ViewInventoryfrm()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {

            stockDatagridVw.DataSource = stock;
            stockDatagridVw.Columns[2].Visible = false;
        }
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
    }
}