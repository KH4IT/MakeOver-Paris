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
    class ProductDAO
    {

        public bool addProduct(Product product)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                MySqlTransaction transaction = cnn.BeginTransaction();
                try
                {
                    cnn.Open();
                    const string SQL = "INSERT INTO products VALUES(productcode,barcode,productname,quantity,description,pricein,priceout,returnquantity,remark,createddate,createdby,updateddate,updatedby,categoryid)" +
                                       "VALUES(@productcode,@barcode,@productname,@quantity,@description,@pricein,@priceout,@returnquantity,@remark,@createddate,@createdby,@updateddate,@updatedby,@categoryid)";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@productcode", product.Productcode);
                    command.Parameters.AddWithValue("@barcode", product.Barcode);
                    command.Parameters.AddWithValue("@productname", product.Productname);
                    command.Parameters.AddWithValue("@quantity", product.Quantity);
                    command.Parameters.AddWithValue("@description", product.Description);
                    command.Parameters.AddWithValue("@pricein", product.Pricein);
                    command.Parameters.AddWithValue("@priceout", product.Priceout);
                    command.Parameters.AddWithValue("@returnquantity", product.Returnquantity);
                    command.Parameters.AddWithValue("@remark", product.Remark);
                    command.Parameters.AddWithValue("@createddate", product.Createddate);
                    command.Parameters.AddWithValue("@createdby", product.Createdby);
                    command.Parameters.AddWithValue("@updateddate", product.Updateddate);
                    command.Parameters.AddWithValue("@updatedby", product.Updatedby);
                    command.Parameters.AddWithValue("@categoryid", product.Category.Categoryid);
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

        public bool deleteProduct(int productId)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "DELETE FROM products WHERE productid = @productId";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@productId", productId);
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

        public bool updateProduct(Product product)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "UPDATE settings SET productcode = @productcode ," +
                                                           "barcode=@barcode, " +
                                                           "productname=@productname " +
                                                           "quantity=@quantity, " +
                                                           "description=@description " +
                                                           "pricein=@pricein, " +
                                                           "priceout=@priceout " +
                                                           "returnquantity=@remark, " +
                                                           "createddate=@createddate " +
                                                           "createdby=@createdby, " +
                                                           "updateddate=@updateddate " +
                                                           "updatedby=@updatedby, " +
                                                           "categoryid=@categoryid " +
                                                           "WHERE productid = @productid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@productcode", product.Productcode);
                    command.Parameters.AddWithValue("@barcode", product.Barcode);
                    command.Parameters.AddWithValue("@productname", product.Productname);
                    command.Parameters.AddWithValue("@quantity", product.Quantity);
                    command.Parameters.AddWithValue("@description", product.Description);
                    command.Parameters.AddWithValue("@pricein", product.Pricein);
                    command.Parameters.AddWithValue("@priceout", product.Priceout);
                    command.Parameters.AddWithValue("@returnquantity", product.Returnquantity);
                    command.Parameters.AddWithValue("@remark", product.Remark);
                    command.Parameters.AddWithValue("@createddate", product.Createddate);
                    command.Parameters.AddWithValue("@createdby", product.Createdby);
                    command.Parameters.AddWithValue("@updateddate", product.Updateddate);
                    command.Parameters.AddWithValue("@updatedby", product.Updatedby);
                    command.Parameters.AddWithValue("@categoryid", product.Category.Categoryid);
                    command.Parameters.AddWithValue("@productid", product.Productid);
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
                    const string SQL = "SELECT productid,productcode,barcode,productname,quantity,description,pricein,priceout,returnquantity,remark,createddate,createdby,updateddate,updatedby,categoryid FROM products;";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    MySqlDataReader reader = command.ExecuteReader();
                    ArrayList products = new ArrayList();
                    Product product = null;
                    while (reader.Read())
                    {
                        product = new Product();
                        product.Productid = reader.GetInt16("productid");
                        product.Productcode = reader.GetString("productcode");
                        product.Barcode = reader.GetString("barcode");
                        product.Productname = reader.GetString("productname");
                        product.Quantity = reader.GetInt16("quantity");
                        product.Description = reader.GetString("description");
                        product.Pricein = reader.GetInt16("pricein");
                        product.Priceout = reader.GetInt16("priceout");
                        product.Returnquantity = reader.GetInt16("returnquantity");
                        product.Remark = reader.GetString("remark");
                        product.Createddate = reader.GetDateTime("createddate");
                        product.Createdby.Staffid = reader.GetInt16("createdby");
                        product.Updatedby.Staffid = reader.GetInt16("updatedby");
                        product.Updateddate = reader.GetDateTime("updateddate");
                        product.Category.Categoryid = reader.GetInt16("categoryid");
                        products.Add(product);
                    }
                    return products;
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

        public Product getProduct(int productid)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "SELECT productid,productcode,barcode,productname,quantity,description,pricein,priceout,returnquantity,remark,createddate,createdby,updateddate,updatedby,categoryid FROM products WHERE productid=@productid;";
                    MySqlCommand command = new MySqlCommand(SQL, cnn); command.Prepare();
                    command.Parameters.AddWithValue("@productid", productid);
                    MySqlDataReader reader = command.ExecuteReader();
                    Product product = null;
                    while (reader.Read())
                    {
                        product = new Product();
                        product.Productid = reader.GetInt16("productid");
                        product.Productcode = reader.GetString("productcode");
                        product.Barcode = reader.GetString("barcode");
                        product.Productname = reader.GetString("productname");
                        product.Quantity = reader.GetInt16("quantity");
                        product.Description = reader.GetString("description");
                        product.Pricein = reader.GetInt16("pricein");
                        product.Priceout = reader.GetInt16("priceout");
                        product.Returnquantity = reader.GetInt16("returnquantity");
                        product.Remark = reader.GetString("remark");
                        product.Createddate = reader.GetDateTime("createddate");
                        product.Createdby.Staffid = reader.GetInt16("createdby");
                        product.Updatedby.Staffid = reader.GetInt16("updatedby");
                        product.Updateddate = reader.GetDateTime("updateddate");
                        product.Category.Categoryid = reader.GetInt16("categoryid");
                    }
                    return product;
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
