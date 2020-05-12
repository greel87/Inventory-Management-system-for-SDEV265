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
        
        //Executes the customer select query and returns all results as a list
        public List<customerBAL> GetCustomers(string lName)
        {
            //uses Dapper functions to create connection and execute query
            using (MySqlConnection conn = new MySqlConnection(Helper.cnnVal("invmanagdb")))
            {
                var results = conn.Query<customerBAL>("get_customers", new { last = lName },
                    commandType: CommandType.StoredProcedure).AsList();
                return results;
                
            }
        }
        //Executes the stock select query and returns all results as a list
        public List<stockBAL> GetInventory(string product)
        {
            //uses Dapper functions to create connection and execute query
            using (MySqlConnection conn = new MySqlConnection(Helper.cnnVal("invmanagdb")))
            {
                var resultsList = conn.Query<stockBAL>("get_inventory", new { Product = product }, commandType: CommandType.StoredProcedure).AsList();

                return resultsList;

            }


        }
        //Executes the add query to create a new customer
        public List<customerBAL> addCustomer(string fName, string lName, string Street,
            string State_ID, string Zip, string Phone, string Email)
        {
            //uses Dapper functions to create connection and execute query
            using (MySqlConnection conn = new MySqlConnection(Helper.cnnVal("invmanagdb")))
            {
                var resultsList = conn.Query<customerBAL>("add_customers", new {firstName = fName, lastName = lName,
                StreetAddress = Street, state_id_code = State_ID, zipCode = Zip, 
                    phoneNumber = Phone, emailAddress = Email }, commandType: CommandType.StoredProcedure).AsList();

                return resultsList;

            }
        }
        //executes the add stock function to add quantity to stock
        public void updateStock(string product, int quantityAmount)
        {
            //uses Dapper functions to create connection and execute query
            using (MySqlConnection conn = new MySqlConnection(Helper.cnnVal("invmanagdb")))
            {
                    var resultsList = conn.Execute("update_stock_add", new { Product = product, quantityAmount = quantityAmount },
              commandType: CommandType.StoredProcedure);
              
            }
        }

        // executes the add new stock function to create a new stock item
        public void addNewStock(string upcValue, string product, int quantityAmount)
        {
            //uses Dapper functions to create connection and execute query
            using (MySqlConnection conn = new MySqlConnection(Helper.cnnVal("invmanagdb")))
            {
                var resultsList = conn.Execute("add_new_stock", new { upcVal = upcValue, product = product, quantityAmount = quantityAmount },
              commandType: CommandType.StoredProcedure);
            }
        }
        //executes the reduce function to subtract quantity from stock
        public void reduceStock(string product, int quantityAmount)
        {
            //uses Dapper functions to create connection and execute query
            using (MySqlConnection conn = new MySqlConnection(Helper.cnnVal("invmanagdb")))
            {
                var resultsList = conn.Execute("update_stock_reduce", new { Product = product, quantityAmount = quantityAmount },
              commandType: CommandType.StoredProcedure);
            }
        }
    } 
}
