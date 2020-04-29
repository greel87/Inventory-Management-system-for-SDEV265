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
            //uses db connection to create a stored procedure command and adds the results to the list
            using (MySqlConnection conn = new MySqlConnection(Helper.cnnVal("invmanagdb")))
            {
                var resultsList = conn.Query<customerBAL>("get_customers", new { last = lName }, commandType: CommandType.StoredProcedure).ToList();
                
                return resultsList;
                
            }
        }
        /*public List<stockBAL> GetInventory(string product)
        {
            List<stockBAL> resultsList = new List<stockBAL>();
            stockBAL results = null;


        }*/
    }
}
