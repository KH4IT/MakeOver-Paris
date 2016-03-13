using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeOver_Paris.DTO;
using MakeOver_Paris.DAO;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace MakeOver_Paris.DAO
{
    class StoreProductDAO
    {
        public bool AddStoreProduct(StoreProduct storeProduct)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                cnn.Open();

                MySqlCommand cmd_checkstock = new MySqlCommand("SELECT COUNT(*) FROM StoreProduct WHERE Storeid=@storeid AND productid=@Productid", cnn);
                cmd_checkstock.Prepare();
                cmd_checkstock.Parameters.AddWithValue("@storeid", storeProduct.StoreId);
                cmd_checkstock.Parameters.AddWithValue("@productid", storeProduct.ProductId);
                int record = int.Parse(cmd_checkstock.ExecuteScalar().ToString());
                if (record > 0)
                {
                    return false;
                }

                MySqlTransaction transaction = cnn.BeginTransaction();
                try
                {
                    const string SQL = @"INSERT INTO 
											storeproduct(
												storeid
                                                , productid
                                                , quantity
                                                , returnquantity
											) 
										VALUES(
											@storeid
                                            , @productid
                                            , @quantity
                                            , @returnquantity
										);";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@storeid", storeProduct.StoreId);
                    command.Parameters.AddWithValue("@productid", storeProduct.ProductId);
                    command.Parameters.AddWithValue("@quantity", storeProduct.Quantity);
                    command.Parameters.AddWithValue("@returnquantity", storeProduct.ReturnQuantity);
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

        public bool DeleteStoreProduct(int storeProductId, int productId)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = @"DELETE FROM 
											storeproduct 
										WHERE 
											storeid = @storeid
                                        AND productid = @productid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@storeid", storeProductId);
                    command.Parameters.AddWithValue("@productid", productId);
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

        public bool UdateStoreProduct(StoreProduct storeProduct)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = @"UPDATE 
											storeproduct 
										SET 
                                              quantity = @quantity
                                            , returnquantity = @returnquantity 
										WHERE 
											storeid = @storeid AND productid = @productid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@storeid", storeProduct.StoreId);
                    command.Parameters.AddWithValue("@productid", storeProduct.ProductId);
                    command.Parameters.AddWithValue(@"quantity", storeProduct.Quantity);
                    command.Parameters.AddWithValue(@"returnquantity", storeProduct.ReturnQuantity);
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

        public DataSet GetAllStoreProducts()
        {
            try
            {
                String sql = @"SELECT (SELECT storename FROM stores WHERE stores.storeid = storeproduct.storeid) AS storename
                                      , (SELECT productname FROM products WHERE products.productid = storeproduct.productid) AS productname
                                      , quantity
                                      , returnquantity
                            FROM storeproduct";
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
