using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeOver_Paris.DTO;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;

namespace MakeOver_Paris.DAO
{
    class StaffDAO
    {
        public bool AddStaff(Staff staff)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                cnn.Open();
                MySqlTransaction transaction = cnn.BeginTransaction();
                try
                {
                    
                    const string SQL = @"INSERT INTO staffs(staffname, staffpassword, stafftype, lastlogin, commisionrate) VALUES(@staffname, @staffpassword, @stafftype, @lastlogin, @commisionrate);";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@staffname", staff.Staffname);
                    command.Parameters.AddWithValue("@staffpassword", staff.Staffpassword);
                    command.Parameters.AddWithValue("@stafftype", staff.Stafftype);
                    command.Parameters.AddWithValue("@lastlogin", staff.Lastlogin);
                    command.Parameters.AddWithValue("@commisionrate", staff.Commisionrate);
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
                    const string SQL = "DELETE FROM staffs WHERE staffid = @staffid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@staffid", id);
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
                    const string SQL = "UPDATE staffs SET staffname = @staffname, staffpassword = @staffpassword, stafftype= @stafftype, commisionrate= @commisionrate where staffid= @staffid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@staffname", staff.Staffname);
                    command.Parameters.AddWithValue("@staffpassword", staff.Staffpassword);
                    command.Parameters.AddWithValue("@stafftype", staff.Stafftype);                    
                    command.Parameters.AddWithValue("@commisionrate", staff.Commisionrate);
                    command.Parameters.AddWithValue("@staffid", staff.Staffid);
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

        public DataSet GetAllStaffs()
        {
            //MySqlConnection cnn = DBUtility.getConnection();
            //if (cnn != null)
            //{
            //    try
            //    {
            //        cnn.Open();
            //        const string SQL = "SELECT staffid, staffname, staffpassword, stafftype, lastlogin, comissionrate FROM staff";
            //        MySqlCommand command = new MySqlCommand(SQL, cnn);
            //        MySqlDataReader reader = command.ExecuteReader();
            //        ArrayList staffs = new ArrayList();
            //        Staff staff = null;
            //        while (reader.Read())
            //        {
            //            staff = new Staff(reader.GetInt16("staffid"), reader.GetString("staffname"),
            //                              reader.GetString("staffpassword"), reader.GetString("stafftype"),
            //                              reader.GetDateTime("lastlogin"), reader.GetDecimal("comissionrate"));
            //            staffs.Add(staffs);
            //        }
            //        return staffs;
            //    }
            //    catch (MySqlException e)
            //    {
            //        Console.WriteLine(e);
            //    }
            //    finally
            //    {
            //        cnn.Close();
            //    }
            //}

            //return null;

            try
            {
                List<Staff> staff = new List<Staff>();
                String sql = @"SELECT staffid, staffname, staffpassword, stafftype, lastlogin, commisionrate FROM staffs";
                DataSet ds = DBUtility.ExecuteQuery(sql);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}