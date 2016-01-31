using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace MakeOver_Paris.DAO
{
    class DBUtility
    {

        private static string cs = "SERVER=127.0.0.1;UID=root;PWD=;DATABASE=makeover_db;Allow User Variables=True";

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

        public static bool ExecuteNonQuery(string sql, params object[] fields)
        {  
            using (MySqlConnection cnn = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand();
                MySqlTransaction transaction = null;
                try
                {
                    cnn.Open();
                    transaction = cnn.BeginTransaction();
                    cmd.CommandText = sql;
                    cmd.Connection = cnn;

                    int i = 1;
                    foreach (var field in fields)
                    {
                        cmd.Parameters.AddWithValue("@p" + i, field);
                        i++;
                    }

                    int result = cmd.ExecuteNonQuery();
                    transaction.Commit();
                    if (result != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    transaction.Rollback();
                    return false;
                }
                finally
                {
                    cmd.Dispose();
                }
            }
        }

        public static DataSet ExecuteQuery(string sql, params object[] fields)
        {
            DataSet dataset = new DataSet();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = con;

                int i = 1;
                foreach (var field in fields)
                {
                    cmd.Parameters.AddWithValue("@p" + i, field);
                    i++;
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataset);
                return dataset;
            }
        }
    }
}
