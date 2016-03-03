using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeOver_Paris.DTO;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MakeOver_Paris.DAO
{
    class StoreDAO
    {
        public DataSet GetAllStores()
        {
            try
            {
                //List<Store> members = new List<Store>();
                String sql = @"SELECT storeid
                                , storename
                                , storeaddress
                            FROM stores";
                DataSet ds = DBUtility.ExecuteQuery(sql);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public bool AddStore(Store store)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                cnn.Open();
                MySqlTransaction transaction = cnn.BeginTransaction();
                try
                {
                    const string SQL = @"INSERT INTO 
											stores(
												storename
                                                , storeaddress
											) 
										VALUES(
											@storename
                                            , @storeaddress
										);";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@storename", store.StroreName);
                    command.Parameters.AddWithValue("@storeaddress", store.StoreAddress);
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

        public bool DeleteStore(int storeId)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = @"DELETE FROM 
											stores 
										WHERE 
											storeid = @storeid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@storeid", storeId);
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

        public bool UpdateStore(Store store)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = @"UPDATE 
											stores 
										SET 
											storename = @storename 
                                            , storeaddress = @storeaddress
										WHERE 
											storeid = @storeid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@storename", store.StroreName);
                    command.Parameters.AddWithValue("@storeaddress", store.StoreAddress);
                    command.Parameters.AddWithValue("@storeid", store.StroreId);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                    MessageBox.Show(e.ToString());
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
