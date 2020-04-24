using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;

namespace InventoryDatabaseUITest.DAL
{
    public class dbConnection
    {

        
        MySqlCommand cmd;
        public MySqlCommand query 
        {
            get
            {
                return cmd;
            }

            set
            {
                using (MySqlConnection conn = new MySqlConnection(Helper.cnnVal("invmanagdb")))
                {
                    var cmd = new MySqlCommand();
                };
            }
        }
    }
}

