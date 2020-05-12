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
            UPCfrm.sendtext = "";
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homefrm HomeForm = new Homefrm();
            HomeForm.ShowDialog();
            this.Close();
            upcTxtbx.Text = "";
            prodNametxtbx.Text = "";
            stockQuantnumeric.Value = 0;
        }

        //takes to the view inventory form and sets all values to blank
        private void viewInvbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewInventoryfrm ViewInventoryForm = new ViewInventoryfrm();
            ViewInventoryForm.ShowDialog();
            this.Close();
            upcTxtbx.Text = "";
            prodNametxtbx.Text = "";
            stockQuantnumeric.Value = 0;
        }

        private void addNewbtn_Click(object sender, EventArgs e)
        {
            queryLib query = new queryLib();
            query.addNewStock(upcTxtbx.Text, prodNametxtbx.Text, (int)stockQuantnumeric.Value);
            upcTxtbx.Text = "";
            prodNametxtbx.Text = "";
            stockQuantnumeric.Value = 0;
        }

        //Takesw stock info and adds new item to database then sets all values to blank
        private void updateBtn_Click(object sender, EventArgs e)
        {
            queryLib query = new queryLib();
            query.updateStock(prodNametxtbx.Text, (int)stockQuantnumeric.Value);
            upcTxtbx.Text = "";
            prodNametxtbx.Text = "";
            stockQuantnumeric.Value = 0;
        }

        private void reduceStockbtn_Click(object sender, EventArgs e)
        {
            queryLib query = new queryLib();
            query.reduceStock(prodNametxtbx.Text, (int)stockQuantnumeric.Value);
            upcTxtbx.Text = "";
            prodNametxtbx.Text = "";
            stockQuantnumeric.Value = 0;
        }
    }
}