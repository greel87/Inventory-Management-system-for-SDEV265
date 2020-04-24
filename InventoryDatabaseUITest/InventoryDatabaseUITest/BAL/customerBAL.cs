using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//code used from IamTimCorey youtube video https://www.youtube.com/watch?v=Et2khGnrIqc&list=PLLWMQd6PeGY3b89Ni7xsNZddi9wD5Esv2

namespace InventoryDatabaseUITest.BAL
{
   public class customerBAL
    {
        //maps mysql customer table to class through properties
        public int Customer_ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Street { get; set; }
        public string State_ID { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        public string customerInfofull
        {   //25 Fname Lname Street State Zip Phone number Email. This displays customer information requested
            get { return $"{ Customer_ID } { Fname } { Lname } { Street } { State_ID }{ Zip }{ Phone }{ Email }"; }
        }

    }
}
