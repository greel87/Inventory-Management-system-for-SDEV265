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
        //zxing function to create barcode
        private void Encode_button_Click(object sender, EventArgs e)
        {
            BarcodeWriter newUPC = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            pic.Image = newUPC.Write(UPCcode.Text);
        }
        // Print button crates a print document and wires the pic_PrintPage method to the event for printing
        private void Print_Button_Click(object sender, EventArgs e)
        {
            
            PrintDocument printUPC = new PrintDocument();
            printUPC.PrintPage += new PrintPageEventHandler(pic_PrintPage);
            printUPC.Print();
          
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homefrm HomeForm = new Homefrm();
            HomeForm.ShowDialog();
            this.Close();
        }
        // Method to print UPC 
        private void pic_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pic.Image, 0, 0);
        }
        // button to go to add stock form and sends text entered in UPCcode text box
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
