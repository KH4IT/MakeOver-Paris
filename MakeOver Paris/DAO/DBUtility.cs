using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Microsoft.Win32;
using System.Configuration;

namespace MakeOver_Paris.DAO
{
    class DBUtility
    {

        private static string cs = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MAKEOVER_PARIS", "ConStr", "").ToString();//"SERVER=127.0.0.1;UID=root;PWD=;DATABASE=makeover_db;Allow User Variables=True";

        public static MySqlConnection getConnection()
        {
            MySqlConnection con = null;
            string myConnectionString = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MAKEOVER_PARIS", "ConStr", "").ToString();//"SERVER=127.0.0.1;UID=root;PWD=;DATABASE=makeover_db;Allow User Variables=True";
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

        // TODO: TO USE FOR ALL EexcuteNonQuery
        // EXAMPLE: 
        //      DBUtility.ExecuteNonQuery("INSERT INTO tables VALUE(@p1,@p2,@p3)" ,1 ,2 ,3);
        public static Boolean ExecuteNonQuery(string sql, params object[] fields)
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
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    transaction.Rollback();
                }
                finally
                {
                    cmd.Dispose();
                }
                return false;
            }
        }

        // TODO: TO USE FOR ExecuteQuery
        // EXAMPLE: 
        //      DBUtility.ExecuteQuery("SELECT field1 FROM table1 WHERE id= @p1", id);
        public static DataSet ExecuteQuery(string sql, params object[] fields)
        {
            DataSet dataset = new DataSet();
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                try
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
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return null;
                }
            }
        }
    }
}
