using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeOver_Paris.DTO;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;

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
                cnn.Open();
                MySqlTransaction transaction = cnn.BeginTransaction();
                try
                {
                    const string SQL = "INSERT INTO categories(categoryname) VALUES(@categoryname)";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@categoryname", category.Categoryname);
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
                    const string SQL = "DELETE FROM categories WHERE categoryid = @categoryid";
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
                    const string SQL = "UPDATE categories SET categoryname = @categoryname WHERE categoryid = @categoryid";
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
/*
        public ArrayList GetAllCategories()
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "SELECT categoryid, categoryname FROM categories;";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    MySqlDataReader reader = command.ExecuteReader();
                    ArrayList categories = new ArrayList();
                    Category category = null;
                    while(reader.Read())
                    {
                        category = new Category();
                        category.Categoryid = reader.GetInt16("categoryid");
                        category.Categoryname = reader.GetString("categoryname");
                        categories.Add(category);
                    }
                    return categories;
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
            return null;
        }
        */
        public DataSet GetAllCategories()
        {
            try
            {
                List<Member> members = new List<Member>();
                String sql = @"SELECT categoryid
                                , categoryname
                            FROM categories";
                DataSet ds = DBUtility.ExecuteQuery(sql);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public Category GetCategory(int id)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            return null;
        }
    }
}