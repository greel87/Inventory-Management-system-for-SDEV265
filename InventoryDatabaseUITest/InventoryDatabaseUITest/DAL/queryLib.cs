using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using InventoryDatabaseUITest.BAL;
using System.Windows.Forms;

namespace InventoryDatabaseUITest.DAL
{
    //queries library for use with forms
    public class queryLib
    {
        
        //Select query customers
        public List<customerBAL> GetCustomers(string lName)
        {
            List<customerBAL> resultsList = new List<customerBAL>();
            customerBAL results = null;
            //uses db connection to create a stored procedure command and adds the results to the list
            using (MySqlConnection conn = new MySqlConnection(Helper.cnnVal("invmanagdb")))
            {


                MySqlDataReader read = null;
                MySqlCommand cmd = new MySqlCommand();
               

                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "get_customers";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@last", lName);
                read = cmd.ExecuteReader();
                try
                {
                    while (read.Read())
                    {
                        results = new customerBAL();
                        results.Customer_ID = int.Parse(read["Customer_ID"].ToString());
                        results.Fname = read["Fname"].ToString();
                        results.Lname = read["Lname"].ToString();
                        results.Street = read["Street"].ToString();
                        results.State_ID = read["State_ID"].ToString();
                        results.Zip = read["Zip"].ToString();
                        results.Phone = read["Phone"].ToString();
                        results.Email = read["Email"].ToString();
                        resultsList.Add(results);
                }      
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    read.Close();
                    conn.Close();
                    
                }
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
