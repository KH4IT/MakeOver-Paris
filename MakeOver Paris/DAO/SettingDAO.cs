using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeOver_Paris.DTO;
using MySql.Data.MySqlClient;
using System.Collections;

/*
 * Tola
 */

namespace MakeOver_Paris.DAO
{
    class ProductDao
    {
        public bool addSetting(Setting setting)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                MySqlTransaction transaction = cnn.BeginTransaction();
                try
                {
                    cnn.Open();
                    const string SQL = "INSERT INTO settings VALUES(title,value) VALUES(@title,@value)";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@title", setting.Title);
                    command.Parameters.AddWithValue("@title", setting.Value);
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

        public bool deleteSetting(int settingId)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "DELETE FROM settings WHERE settingid = @settingId";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@settingId", settingId);
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

        public bool updateSetting(Setting setting)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if(cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "UPDATE settings SET title = @title , value=@value WHERE settingid = @settingid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@title", setting.Title);
                    command.Parameters.AddWithValue("@value", setting.Value);
                    command.Parameters.AddWithValue("@settingid", setting.Settingid);
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

        public ArrayList getAllSetting()
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "SELECT settingid, title , value FROM settings;";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    MySqlDataReader reader = command.ExecuteReader();
                    ArrayList settings = new ArrayList();
                    Setting setting = null;
                    while(reader.Read())
                    {
                        setting = new Setting();
                        setting.Settingid = reader.GetInt16("settingid");
                        setting.Title = reader.GetString("title");
                        setting.Value = reader.GetString("value");
                        settings.Add(setting);
                    }
                    return settings;
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


        public Setting getSetting(int productid)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "SELECT settingid, title , value FROM settings WHERE productid=@productid;";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@productid", productid);
                    MySqlDataReader reader = command.ExecuteReader();
                    Setting setting = null;
                    while (reader.Read())
                    {
                        setting = new Setting();
                        setting.Settingid = reader.GetInt16("settingid");
                        setting.Title = reader.GetString("title");
                        setting.Value = reader.GetString("value");
                    }
                    return setting;
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
    }
}