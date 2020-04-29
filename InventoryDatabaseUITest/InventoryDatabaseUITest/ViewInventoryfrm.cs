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
    public partial class ViewInventoryfrm : Form
    {
        public ViewInventoryfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homefrm HomeForm = new Homefrm();
            HomeForm.ShowDialog();
            this.Close();
        }
    }
}