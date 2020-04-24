using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using InventoryDatabaseUITest.BAL;

namespace InventoryDatabaseUITest.DAL
{
    public class queryLib
    {
        //Select query customers
        public List<customerBAL> GetCustomers(string lName)
        {
            var connect = new dbConnection();
            var cmd = connect.query;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@lName", get_customers);

            
        }
    }
}
