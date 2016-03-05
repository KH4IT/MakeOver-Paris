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
                    
                    const string SQL = @"INSERT INTO staffs(staffname, staffpassword, stafftype, lastlogin, commisionrate, storeid) VALUES(@staffname, @staffpassword, @stafftype, @lastlogin, @commisionrate, @storeid);";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@staffname", staff.Staffname);
                    command.Parameters.AddWithValue("@staffpassword", staff.Staffpassword);
                    command.Parameters.AddWithValue("@stafftype", staff.Stafftype);
                    command.Parameters.AddWithValue("@lastlogin", staff.Lastlogin);
                    command.Parameters.AddWithValue("@commisionrate", staff.Commisionrate);
                    command.Parameters.AddWithValue(@"storeid", staff.StoreId);
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
                    const string SQL = "UPDATE staffs SET staffname = @staffname, staffpassword = @staffpassword, stafftype= @stafftype, commisionrate= @commisionrate, storeid=@storeid where staffid= @staffid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@staffname", staff.Staffname);
                    command.Parameters.AddWithValue("@staffpassword", staff.Staffpassword);
                    command.Parameters.AddWithValue("@stafftype", staff.Stafftype);                    
                    command.Parameters.AddWithValue("@commisionrate", staff.Commisionrate);
                    command.Parameters.AddWithValue("@staffid", staff.Staffid);
                    command.Parameters.AddWithValue("@storeid", staff.StoreId);
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
            try
            {
                String sql = @"SELECT staffid, staffname, stafftype, lastlogin, commisionrate,storename, staffpassword FROM staffs LEFT JOIN stores ON stores.storeid = staffs.storeid WHERE staffname != 'admin'";
                DataSet ds = DBUtility.ExecuteQuery(sql);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public Staff Login(string username, string password)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            Staff staff = null;
            try
            {
                if (cnn != null)
                {
                    cnn.Open();
                    const string SQL = @"SELECT 
                                            staffid
                                            , staffname
                                            , staffpassword
                                            , stafftype
                                            , lastlogin
                                         FROM
                                            staffs
                                         WHERE
                                            staffname = LOWER(@staffname)
                                         AND
                                            staffpassword = @staffpassword";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@staffname", username);
                    command.Parameters.AddWithValue(@"staffpassword", password);
                    MySqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        staff = new Staff();
                        staff.Staffid = reader.GetInt16("staffid");
                        staff.Staffname = reader.GetString("staffname");
                        staff.Staffpassword = reader.GetString("staffpassword");
                        staff.Stafftype = reader.GetString("stafftype");
                        staff.Lastlogin = reader.GetDateTime("lastlogin");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                cnn.Close();
            }
            return staff;
        }

        public DataSet getStaffComission(int staffid, string startDate, string endDate)
        {
            try
            {
                String sql = @"SELECT I.Invoiceid, I.InvoiceDate, P.Productname, ID.Quantity, TRUNCATE(ID.PriceOut, 2), TRUNCATE((ID.Quantity*ID.Priceout), 2) AS Subtotal, TRUNCATE(((S.commisionrate/100)*ID.Quantity*ID.Priceout), 2) Commision 
                                FROM Staffs S INNER JOIN Invoices I ON I.staffid=S.staffid 
                                INNER JOIN InvoiceDetail ID ON I.Invoiceid=ID.Invoiceid 
                                INNER JOIN Products P ON ID.Productid=P.Productid
                                WHERE S.StaffID=@p1 AND I.Invoicedate BETWEEN @p2 AND @p3";
                DataSet ds = DBUtility.ExecuteQuery(sql, staffid, Convert.ToDateTime(startDate).ToString("yyyy-MM-dd"), Convert.ToDateTime(endDate).ToString("yyyy-MM-dd"));
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