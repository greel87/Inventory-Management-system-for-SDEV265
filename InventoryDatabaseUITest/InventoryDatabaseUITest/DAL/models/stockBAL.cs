﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//code used from IamTimCorey youtube video https://www.youtube.com/watch?v=Et2khGnrIqc&list=PLLWMQd6PeGY3b89Ni7xsNZddi9wD5Esv2
namespace InventoryDatabaseUITest.BAL
{
    public class stockBAL
    {
        

        //maps stock table from mysql to class. this is the model used for all queries in stock
        public string UPC { get; set; }
        public string Prod_Name { get; set; }
        public int Quantity { get; set; }


    }
}

