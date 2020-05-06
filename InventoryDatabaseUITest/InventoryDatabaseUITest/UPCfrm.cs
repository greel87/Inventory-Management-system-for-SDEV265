using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using Dapper;
using System.Drawing.Printing;

namespace InventoryDatabaseUITest
{
    public partial class UPCfrm : Form
    {
        public static string sendtext = "";
        
        public UPCfrm()
        {
            InitializeComponent();
        }

        private void Encode_button_Click(object sender, EventArgs e)
        {
            BarcodeWriter newUPC = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            pic.Image = newUPC.Write(UPCcode.Text);
        }

        private void Print_Button_Click(object sender, EventArgs e)
        {
            
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(pic_PrintPage);
            printDocument1.Print();
          
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homefrm HomeForm = new Homefrm();
            HomeForm.ShowDialog();
            this.Close();
        }
        private void pic_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pic.Image, 0, 0);
        }

        private void AddStock_Button_Click(object sender, EventArgs e)
        {
            sendtext = UPCcode.Text;
            this.Hide();
            addStockfrm AddStockForm = new addStockfrm();
            AddStockForm.ShowDialog();
            this.Close();
        }
    }
}
