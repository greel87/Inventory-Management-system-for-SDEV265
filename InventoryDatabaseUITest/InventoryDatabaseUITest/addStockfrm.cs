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

    public partial class addStockfrm : Form
    {
        public addStockfrm()
        {
            InitializeComponent();
        }
        private void addStockfrm_Load(object sender, EventArgs e)
        {
            upcTxtbx.Text = UPCfrm.sendtext;
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homefrm HomeForm = new Homefrm();
            HomeForm.ShowDialog();
            this.Close();
        }

        private void viewInvbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewInventoryfrm ViewInventoryForm = new ViewInventoryfrm();
            ViewInventoryForm.ShowDialog();
            this.Close();
        }

        private void addNewbtn_Click(object sender, EventArgs e)
        {
            queryLib query = new queryLib();
            query.addNewStock(upcTxtbx.Text, prodNametxtbx.Text, (int)stockQuantnumeric.Value);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            queryLib query = new queryLib();
            query.updateStock(prodNametxtbx.Text, (int)stockQuantnumeric.Value);
        }
    }
}