﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//code used from IamTimCorey youtube video https://www.youtube.com/watch?v=Et2khGnrIqc&list=PLLWMQd6PeGY3b89Ni7xsNZddi9wD5Esv2

namespace InventoryDatabaseUITest.BAL
{
    public class OrderLineBAL
    {
        //maps Order_Line from mysql to class
        public int Order_ID { get; set; }
        public string UPC { get; set; }
        public int Quantity { get; set; }
        public string Serial_Number { get; set; }

    }
}
