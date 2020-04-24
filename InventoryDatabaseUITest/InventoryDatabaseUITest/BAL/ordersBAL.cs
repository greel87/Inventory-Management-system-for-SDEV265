using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//code used from IamTimCorey youtube video https://www.youtube.com/watch?v=Et2khGnrIqc&list=PLLWMQd6PeGY3b89Ni7xsNZddi9wD5Esv2

namespace InventoryDatabaseUITest.BAL
{
   public class ordersBAL
    {
        //maps orders table from mysql to class
        public int Order_ID { get; set; }
        public int Customer_ID { get; set; }
        public DateTime Order_Date { get; set; }


        public  string orderInfofull
        {   //25 3 10/11/2020 this displays requested order information
            get { return $"{ Order_ID } { Customer_ID } { Order_Date }"; }
        }

    }
}
