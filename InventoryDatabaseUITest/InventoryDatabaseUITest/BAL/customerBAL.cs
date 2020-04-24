using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabaseUITest.BAL
{
   public class customerBAL
    {
        public string Customer_ID { get; set; }
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
