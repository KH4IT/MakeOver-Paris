using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeOver_Paris.DTO;
using MySql.Data.MySqlClient;
using System.Collections;

namespace MakeOver_Paris.DAO
{
    class TransactionDAO
    {
        public bool AddTransaction(Transaction transaction)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                MySqlTransaction tran = cnn.BeginTransaction();
                try
                {
                    cnn.Open();
                    const string SQL = "INSERT INTO transaction() VALUES();";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    // command.Parameters.AddWithValue("",);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        tran.Commit();
                        return true;
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                    tran.Rollback();
                }
                finally
                {
                    cnn.Close();
                }
            }
            return false;
        }

    }
}
