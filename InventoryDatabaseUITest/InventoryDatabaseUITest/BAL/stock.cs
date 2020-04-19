using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabaseUITest.BAL
{
    public class stock
    {
        public string UPC { get; set; }
        public string Prod_Name { get; set; }
        public bool Serial_Number_Required { get; set; }
        public int Quantity { get; set; }
        public int serial_number { get; set; }
    }
}
