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
   
    public partial class addStockfrm : Form
    {
        public addStockfrm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            //taken from https://stackoverflow.com/questions/3005732/showing-a-hidden-form
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Homefrm);
            if (formToShow != null)
            {
                formToShow.Show();
                this.Close();
            }
        }
    }
}
