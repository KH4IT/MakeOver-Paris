using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MakeOver_Paris.DAO
{
    class DBUtility
    {

        public static MySqlConnection getConnection ()
        {
            MySqlConnection con = null;
            string myConnectionString = "SERVER=127.0.0.1;UID=root;PWD=;DATABASE=makeover_db;Allow User Variables=True";

            try
            {
                con = new MySql.Data.MySqlClient.MySqlConnection();
                con.ConnectionString = myConnectionString;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return con;
        }

        public static String SafeGetString(MySqlDataReader reader, String columnname)
        {
            int colIndex = reader.GetOrdinal(columnname);
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            else
                return String.Empty;
        }


    }
}
