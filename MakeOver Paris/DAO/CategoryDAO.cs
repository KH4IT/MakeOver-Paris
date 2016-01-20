using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeOver_Paris.DTO;
using MySql.Data.MySqlClient;

namespace MakeOver_Paris.DAO
{
    class CategoryDAO
    {
        public Boolean AddCategory(Category category)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                MySqlTransaction transaction = cnn.BeginTransaction();
                try
                {
                    cnn.Open();
                    const string SQL = "INSERT INTO category VALUES(categoryname) VALUES(@categoryname)";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@categoryname", category.Categoryid);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        transaction.Commit();
                        return true;
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                    transaction.Rollback();
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
