using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using InventoryDatabaseUITest.BAL;
using System.Windows.Forms;
using Dapper;

namespace InventoryDatabaseUITest.DAL
{
    //queries library for use with forms
    public class queryLib
    {
        
        //Select query customers
        public List<customerBAL> GetCustomers(string lName)
        {
            //uses dapper to connect to a MySql database from helper class connection string
            using (MySqlConnection conn = new MySqlConnection(Helper.cnnVal("invmanagdb")))
            {
                var results = conn.Query<customerBAL>("get_customers", new { last = lName },
                    commandType: CommandType.StoredProcedure).AsList();
                return results;
                
            }
        }
        public List<stockBAL> GetInventory(string product)
        {
            using (MySqlConnection conn = new MySqlConnection(Helper.cnnVal("invmanagdb")))
            {
                var resultsList = conn.Query<stockBAL>("get_inventory", new { Product = product }, commandType: CommandType.StoredProcedure).ToList();

                return resultsList;

            }


        }
    }
}
