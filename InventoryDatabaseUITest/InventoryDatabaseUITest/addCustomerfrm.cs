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
    public partial class addCustomerfrm : Form
    {
        //list to hold customer info to be sent to database
        List<customerBAL> customer = new List<customerBAL>();
        public addCustomerfrm()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homefrm HomeForm = new Homefrm();
            HomeForm.ShowDialog();
            this.Close();
        }

       

        private void viewCustBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCustomerfrm viewCustomerfrm = new ViewCustomerfrm();
            viewCustomerfrm.ShowDialog();
            this.Close();
        }

        //takes customer info input and adds to database then sets all fields to blank
        private void addCustomerbtn_Click(object sender, EventArgs e)
        {
            queryLib query = new queryLib();

            customer = query.addCustomer(fNameTxtbx.Text, lNameTxtbx.Text, Streettxtbx.Text,
                stateTxtbx.Text, ziptxtbx.Text, phonetxtbx.Text, emailTxtbx.Text);
            fNameTxtbx.Text = "";
            lNameTxtbx.Text = "";
            Streettxtbx.Text = "";
            cityTxtbx.Text = "";
            stateTxtbx.Text = "";
            ziptxtbx.Text = "";
            phonetxtbx.Text = "";
            emailTxtbx.Text = "";
        }
       
    }
}