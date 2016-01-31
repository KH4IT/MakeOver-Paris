using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeOver_Paris.DTO;
using System.Collections;
using MySql.Data.MySqlClient;

namespace MakeOver_Paris.DAO
{
    class StaffDAO
    {

        public bool AddStaff(Staff staff)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if(cnn != null)
            {
                MySqlTransaction transaction = cnn.BeginTransaction();
                try
                {
                    cnn.Open();
                    const string SQL = "INSERT INTO staff() VALUES(@staffname, @staffpassword, @stafftype, @lastlogin, @comissionrate);";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@staffname",staff.Staffname);
                    command.Parameters.AddWithValue("@staffpassword", staff.Staffpassword);
                    command.Parameters.AddWithValue("@stafftype", staff.Stafftype);
                    command.Parameters.AddWithValue("@lastlogin", staff.Lastlogin);
                    command.Parameters.AddWithValue("@comissionrate", staff.Commisionrate);
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

        public bool DeleteStaff(int id)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null) 
            {
                try
                {
                    cnn.Open();
                    const string SQL = "DELETE FROM staff WHERE staffid = @staffid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@staffid",id);
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

        public bool UpdateStaff(Staff staff)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "UPDATE";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@staffname", staff.Staffname);
                    command.Parameters.AddWithValue("@staffpassword", staff.Staffpassword);
                    command.Parameters.AddWithValue("@stafftype", staff.Stafftype);
                    command.Parameters.AddWithValue("@lastlogin", staff.Lastlogin);
                    command.Parameters.AddWithValue("@comissionrate", staff.Commisionrate);
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

        public ArrayList GetAllStaffs()
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "SELECT staffid, staffname, staffpassword, stafftype, lastlogin, comissionrate FROM staff";
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
            
            return null;
        }
    }
}
