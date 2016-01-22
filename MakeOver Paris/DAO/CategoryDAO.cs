using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeOver_Paris.DTO;
using MySql.Data.MySqlClient;
using System.Collections;

/*
 * BUNRONG LEANG
 * CATEGORIES DAO
 */

namespace MakeOver_Paris.DAO
{
    class CategoryDAO
    {
        public bool AddCategory(Category category)
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

        public bool DeleteCategory(int categoryId)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "DELETE FROM category WHERE categoryid = @categoryid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@categoryid", categoryId);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    cnn.Close();
                }
            }
            return false;
        }

        public bool UdateCategory(Category category)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if(cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "UPDATE category SET categoryname = @categoryname WHERE categoryid = @categoryid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@categoryname", category.Categoryname);
                    command.Parameters.AddWithValue("@categoryid",category.Categoryid);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    cnn.Close();
                }
            }
            return false;
        }

        public ArrayList GetAllCategories()
        {
            MySqlConnection cnn = DBUtility.getConnection();
            ArrayList categories = new ArrayList();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "SELECT categoryid, categoryname FROM category;";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    
                    
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    cnn.Close();
                }
            }
            return categories;
        }
    }
}