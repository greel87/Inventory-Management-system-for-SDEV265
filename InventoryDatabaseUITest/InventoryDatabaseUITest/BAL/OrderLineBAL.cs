using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabaseUITest.BAL
{
    class OrderLineBAL
    {
        public int Order_ID { get; set; }
        public string UPC { get; set; }
        public int Quantity { get; set; }
        public string Serial_Number { get; set; }


        public string orderLinefull
        {   //25 3 10/11/2020 this displays requested order information
            get { return $"{ Order_ID } { UPC } { Serial_Number } { Quantity }"; }
        }
    }
}
