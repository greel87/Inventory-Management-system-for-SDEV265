using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabaseUITest.BAL
{
    public class stockBAL
    {
        public string UPC { get; set; }
        public string Prod_Name { get; set; }
        public bool Serial_Number_Required { get; set; }
        public int Quantity { get; set; }
        public int serial_number { get; set; }


        public string stockInfoFull
        {   //1234567 name 2 123456789102 this displays the stock info requested
            get { return $"{ UPC } { Prod_Name } { Quantity }{ serial_number }"; }
        }

    }
}
