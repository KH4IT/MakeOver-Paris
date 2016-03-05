using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeOver_Paris.DTO;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;

namespace MakeOver_Paris.DAO
{
    class ProductDAO
    {

        public bool addProduct(Product product)
        {
            
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                cnn.Open();
                MySqlTransaction transaction = cnn.BeginTransaction();
                try
                {
                   
                    const string SQL = @"INSERT INTO products (productcode,barcode,productname,description,pricein,priceout,remark,createddate,createdby,categoryid)" +
                                       "VALUES(@productcode,@barcode,@productname,@description,@pricein,@priceout,@remark,CURRENT_TIMESTAMP(),@createdby,@categoryid)";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@productcode", product.Productcode);
                    command.Parameters.AddWithValue("@barcode", product.Barcode);
                    command.Parameters.AddWithValue("@productname", product.Productname);
                    command.Parameters.AddWithValue("@description", product.Description);
                    command.Parameters.AddWithValue("@pricein", product.Pricein);
                    command.Parameters.AddWithValue("@priceout", product.Priceout);
                    command.Parameters.AddWithValue("@remark", product.Remark);
                    command.Parameters.AddWithValue("@createdby", product.Createdby.Staffid);
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
                    const string SQL = @"UPDATE products SET productcode = @productcode ," +
                                                           "barcode=@barcode, " +
                                                           "productname=@productname, " +
                                                           "description=@description, " +
                                                           "pricein=@pricein, " +
                                                           "priceout=@priceout, " +
                                                           "remark=@remark," +
                                                           "updateddate=CURRENT_TIMESTAMP()," +
                                                           "updatedby=@updatedby, " +
                                                           "categoryid=@categoryid " +
                                                           "WHERE productid = @productid";
                    MySqlCommand command = new MySqlCommand(SQL, cnn);
                    command.Prepare();
                    command.Parameters.AddWithValue("@productcode", product.Productcode);
                    command.Parameters.AddWithValue("@barcode", product.Barcode);
                    command.Parameters.AddWithValue("@productname", product.Productname);
                   // command.Parameters.AddWithValue("@quantity", product.Quantity);
                    command.Parameters.AddWithValue("@description", product.Description);
                    command.Parameters.AddWithValue("@pricein", product.Pricein);
                    command.Parameters.AddWithValue("@priceout", product.Priceout);
                   // command.Parameters.AddWithValue("@returnquantity", product.Returnquantity);
                    command.Parameters.AddWithValue("@remark", product.Remark);
                    command.Parameters.AddWithValue("@updatedby", product.Updatedby.Staffid);
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

        public DataSet getAllProductDS()
        {
            try
            {
                const string SQL = @"SELECT productid
                                          , productcode
                                          , barcode
                                          , productname
                                          , pricein
                                          , priceout
                                          , (SELECT staffname FROM staffs WHERE staffs.staffid = products.createdby) AS createdby
                                          , (SELECT staffname FROM staffs WHERE staffs.staffid = products.updatedby) AS createdby
                                          , createddate
                                          , updateddate
                                          , categoryname 
                                          , description 
                                          , remark
                                    FROM products 
                                    LEFT JOIN categories ON products.categoryid = categories.categoryid";
                DataSet ds = DBUtility.ExecuteQuery(SQL);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public DataSet searchProductDS(String productname)
        {
            try
            {
                const string SQL = @"SELECT productid,productcode,barcode,productname,description,pricein,priceout,remark,createddate,createdby,updateddate,updatedby,categoryid FROM products where productname like;";
                DataSet ds = DBUtility.ExecuteQuery(SQL);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public ArrayList getAllProduct()
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "SELECT productid,productcode,barcode,productname,description,pricein,priceout,remark,createddate,createdby,updateddate,updatedby,categoryid FROM products;";
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
                    const string SQL = "SELECT productid,productcode,barcode,productname,description,pricein,priceout,remark,createddate,createdby,updateddate,updatedby,categoryid FROM products WHERE productid=@productid;";
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
                        //product.Quantity = reader.GetInt16("quantity");
                        product.Description = reader.GetString("description");
                        product.Pricein = reader.GetInt16("pricein");
                        product.Priceout = reader.GetInt16("priceout");
                        //product.Returnquantity = reader.GetInt16("returnquantity");
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

        public Product getProduct(String code, int storeid)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "SELECT P.productid,productcode,barcode,productname,description,pricein,priceout,remark,createddate,createdby,updateddate,updatedby,categoryid, Quantity, ReturnQuantity FROM products P LEFT JOIN StoreProduct SP ON P.productid=SP.productid WHERE (productcode=@productcode OR barcode=@barcode) AND Storeid=@storeid;";
                    MySqlCommand command = new MySqlCommand(SQL, cnn); command.Prepare();
                    command.Parameters.AddWithValue("@productcode", code);
                    command.Parameters.AddWithValue("@barcode", code);
                    command.Parameters.AddWithValue("@storeid", storeid);
                    MySqlDataReader reader = command.ExecuteReader();
                    Product product = null;
                    while (reader.Read())
                    {
                        product = new Product();
                        product.Productid = reader.GetInt16("productid");
                        product.Productcode = DBUtility.SafeGetString(reader, "productcode");
                        product.Barcode = DBUtility.SafeGetString(reader, "barcode");
                        product.Productname = DBUtility.SafeGetString(reader, "productname");
                        product.Quantity = reader.GetInt16("quantity");
                        product.Description = DBUtility.SafeGetString(reader, "description");
                        product.Pricein = reader.GetInt16("pricein");
                        product.Priceout = reader.GetInt16("priceout");
                        product.Returnquantity = reader.GetInt16("returnquantity");
                        product.Remark = DBUtility.SafeGetString(reader, "remark");
                        product.Createddate = reader.GetDateTime("createddate");
                        Staff createdby = new Staff();
                        createdby.Staffid = reader.GetInt16("createdby");
                        Staff updatedby = new Staff();
                        updatedby.Staffid = reader.GetInt16("updatedby");
                        product.Createdby = createdby;
                        product.Updatedby = updatedby;
                        product.Updateddate = reader.GetDateTime("updateddate");
                        Category category = new Category();
                        category.Categoryid = reader.GetInt16("categoryid");
                        product.Category = category;
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

        public DataSet getAllProductsSold(String startDate, String endDate)
        {
            try
            {
                const string SQL = @"SELECT 
                                           P.productid
                                         , P.productname
                                         , SUM(ID.productid)
                                     FROM products P 
                                     INNER JOIN invoicedetail ID ON P.productid=ID.productid
                                     INNER JOIN invoices I ON ID.invoiceid=I.invoiceId
                                     WHERE DATE(I.invoicedate) BETWEEN @p1 AND @p2
                                     GROUP BY P.productid";
                DataSet ds = DBUtility.ExecuteQuery(SQL, Convert.ToDateTime(startDate).ToString("yyyy-MM-dd"), Convert.ToDateTime(endDate).ToString("yyyy-MM-dd"));
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public DataSet getSamePriceProduct(int productid)
        {
            try
            {
                string SQL = ("SELECT * FROM Products WHERE Priceout = (SELECT Priceout FROM Products WHERE Productid=" + productid + ")");
                DataSet ds = DBUtility.ExecuteQuery(SQL);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public Boolean checkProduct(String productCode)
        {
            MySqlConnection cnn = DBUtility.getConnection();
            if (cnn != null)
            {
                try
                {
                    cnn.Open();
                    const string SQL = "SELECT COUNT(productcode) AS COUNT FROM products WHERE productcode=@productcode;";
                    MySqlCommand command = new MySqlCommand(SQL, cnn); command.Prepare();
                    command.Parameters.AddWithValue("@productcode", productCode);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.GetInt16("COUNT") > 0)
                        {
                            return true;
                        }
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
    }
}
