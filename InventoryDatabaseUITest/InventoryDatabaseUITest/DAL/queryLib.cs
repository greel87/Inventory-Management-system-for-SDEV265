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
                var resultsList = conn.Query<stockBAL>("get_inventory", new { Product = product }, commandType: CommandType.StoredProcedure).AsList();

                return resultsList;

            }


        }
        public List<customerBAL> addCustomer(string fName, string lName, string Street,
            string State_ID, string Zip, string Phone, string Email)
        {
            using (MySqlConnection conn = new MySqlConnection(Helper.cnnVal("invmanagdb")))
            {
                var resultsList = conn.Query<customerBAL>("add_customers", new {firstName = fName, lastName = lName,
                StreetAddress = Street, state_id_code = State_ID, zipCode = Zip, 
                    phoneNumber = Phone, emailAddress = Email }, commandType: CommandType.StoredProcedure).AsList();

                return resultsList;

            }
        }
        public void updateStock(string product, int quantityAmount)
        {
            using (MySqlConnection conn = new MySqlConnection(Helper.cnnVal("invmanagdb")))
            {
                if (quantityAmount <= 0)
                {
                    var resultsList = conn.Execute("update_stock_reduce", new { Product = product, quantityAmount = quantityAmount },
              commandType: CommandType.StoredProcedure);
                }
                else
                {
                    var resultsList = conn.Execute("update_stock_add", new { Product = product, quantityAmount = quantityAmount },
              commandType: CommandType.StoredProcedure);
                } 
            }
        }
        public void addNewStock(string upcValue, string product, int quantityAmount)
        {
            using (MySqlConnection conn = new MySqlConnection(Helper.cnnVal("invmanagdb")))
            {
                var resultsList = conn.Execute("add_new_stock", new { upcVal = upcValue, product = product, quantityAmount = quantityAmount },
              commandType: CommandType.StoredProcedure);
            }
        }
    } 
}
