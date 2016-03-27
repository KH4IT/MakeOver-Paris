using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MakeOver_Paris.DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace MakeOver_Paris.DAO
{
    class InvoiceDAO
    {

        public int addInvoice(Invoice invoice)
        {
            MySqlConnection con = DBUtility.getConnection();
            if (con != null)
                con.Open();
            {
                MySqlTransaction transaction = con.BeginTransaction();
                try
                {
                    String sql = "INSERT INTO Invoices(invoicedate, staffid, memberid, remark, discount) VALUES(NOW(), @staffid, @memberid, @remark, @discount); SELECT last_insert_id();";
                    MySqlCommand invCommand = new MySqlCommand(sql, con);
                    invCommand.Prepare();
                    invCommand.Parameters.AddWithValue("@staffid", invoice.Staff.Staffid);
                    invCommand.Parameters.AddWithValue("@memberid", invoice.Member.Memberid);
                    invCommand.Parameters.AddWithValue("@remark", invoice.Remark);
                    invCommand.Parameters.AddWithValue("@discount", invoice.Discount);
                    invoice.Invoiceid = Convert.ToInt16(invCommand.ExecuteScalar());

                    StringBuilder sb = new StringBuilder("INSERT INTO InvoiceDetail VALUES");
                    for (int i = 0; i < invoice.InvoiceDetail.Count; i++)
                    {
                        sb.AppendFormat("(@invoiceid{0}, @productid{0}, @quanity{0}, @pricein{0}, @priceout{0}, @discount{0}),", i);
                    }
                    sb.Replace(",", ";", sb.Length - 1, 1);

                    Console.WriteLine(sb.ToString());

                    MySqlCommand invDetailCommand = new MySqlCommand(sb.ToString(), con);
                    invDetailCommand.Prepare();
                    for (int i = 0; i < invoice.InvoiceDetail.Count; i++)
                    {
                        invDetailCommand.Parameters.AddWithValue("@invoiceid" + i, invoice.Invoiceid);
                        invDetailCommand.Parameters.AddWithValue("@productid" + i, ((InvoiceDetail)invoice.InvoiceDetail[i]).Product.Productid);
                        invDetailCommand.Parameters.AddWithValue("@quanity" + i, ((InvoiceDetail)invoice.InvoiceDetail[i]).Quantity);
                        invDetailCommand.Parameters.AddWithValue("@pricein" + i, ((InvoiceDetail)invoice.InvoiceDetail[i]).Pricein);
                        invDetailCommand.Parameters.AddWithValue("@priceout" + i, ((InvoiceDetail)invoice.InvoiceDetail[i]).Priceout);
                        invDetailCommand.Parameters.AddWithValue("@discount" + i, ((InvoiceDetail)invoice.InvoiceDetail[i]).Dicount);

                        String updateSql = "UPDATE StoreProduct SET quantity=quantity-@quantity WHERE productid=@productid AND Storeid=@storeid;";
                        MySqlCommand updateProductCommand = new MySqlCommand(updateSql, con);
                        updateProductCommand.Prepare();
                        updateProductCommand.Parameters.AddWithValue("@quantity", ((InvoiceDetail)invoice.InvoiceDetail[i]).Quantity);
                        updateProductCommand.Parameters.AddWithValue("@productid", ((InvoiceDetail)invoice.InvoiceDetail[i]).Product.Productid);
                        updateProductCommand.Parameters.AddWithValue("@storeid", invoice.Staff.StoreId);
                        updateProductCommand.ExecuteNonQuery();

                        //Product p = new ProductDao().getProduct(((InvoiceDetail)invoice.InvoiceDetail[i]).Product.Productid);
                        //p.Quantity -= ((InvoiceDetail)invoice.InvoiceDetail[i]).Quantity;
                        //new ProductDao().updateProduct(p);

                    }
                    invDetailCommand.ExecuteNonQuery();
                    transaction.Commit();
                    return invoice.Invoiceid;
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.ToString());
                    transaction.Rollback();
                }
                finally
                {
                    con.Close();
                }
            }
            return -1;
        }

        public Invoice getInvoice(int invoiceId)
        {
            MySqlConnection con = DBUtility.getConnection();
            if (con != null)
                con.Open();
            {
                try
                {
                    MySqlCommand cmdInv = new MySqlCommand("SELECT I.invoiceid, I.invoicedate, I.remark, I.discount, ID.quantity, ID.pricein, ID.priceout, ID.discount id_discount, S.staffid, S.staffname, S.stafftype, M.memberid, M.membername, M.membercode, M.phonenumber, M.createddate, P.productid, P.productcode, P.barcode, P.productname, P.description FROM Invoices I INNER JOIN InvoiceDetail ID ON I.invoiceid=ID.invoiceid INNER JOIN Products P ON ID.productid=P.productid INNER JOIN Staffs S ON I.Staffid=S.Staffid INNER JOIN Members M ON I.memberid=M.memberid WHERE I.invoiceid=" + invoiceId, con);
                    MySqlDataReader drInv = cmdInv.ExecuteReader();
                    ArrayList arrInvDetail = new ArrayList();
                    Invoice inv = new Invoice();
                    inv.Invoiceid = invoiceId;
                    Member member = new Member();
                    Staff staff = new Staff();
                    while (drInv.Read())
                    {
                        inv.Invoicedate = drInv.GetDateTime("invoicedate");
                        inv.Discount = drInv.GetDecimal("discount");
                        inv.Remark = DBUtility.SafeGetString(drInv, "remark");

                        InvoiceDetail invDetail = new InvoiceDetail();
                        Product product = new Product();
                        product.Productid = drInv.GetInt16("productid");
                        product.Productname = DBUtility.SafeGetString(drInv, "productname");
                        product.Productcode = DBUtility.SafeGetString(drInv, "productCode");
                        product.Barcode = DBUtility.SafeGetString(drInv, "barcode");
                        product.Quantity = drInv.GetDecimal("quantity");
                        product.Description = DBUtility.SafeGetString(drInv, "description");
                        invDetail.Product = product;
                        invDetail.Pricein = drInv.GetDecimal("pricein");
                        invDetail.Priceout = drInv.GetDecimal("priceout");
                        invDetail.Quantity = drInv.GetDecimal("quantity");
                        invDetail.Dicount = drInv.GetDecimal("id_discount");

                        arrInvDetail.Add(invDetail);

                        member.Memberid = drInv.GetInt16("memberid");
                        member.Membername = DBUtility.SafeGetString(drInv, "membername");
                        member.Phonenumber = DBUtility.SafeGetString(drInv, "phonenumber");


                        staff.Staffid = drInv.GetInt16("staffid");
                        staff.Staffname = drInv.GetString("staffname");
                        staff.Stafftype = drInv.GetString("stafftype");

                        inv.Staff = staff;
                        inv.Member = member;
                    }   
                    inv.InvoiceDetail = arrInvDetail;
                    return inv;
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            return null;
        }

        public DataSet getAllInvoices()
        {
            try
            {
                String sql = @"SELECT 
                                    CONCAT('I',LPAD(I.invoiceid,9,'0')) AS invoiceid
                                  , I.invoicedate
                                  , S.staffname
                                  , FORMAT(SUM(ID.quantity*ID.priceout)-(SUM((ID.quantity*ID.priceout))*(I.discount/100)),2) 
                                  , I.invoiceid AS id
                               FROM invoices I 
                               INNER JOIN staffs S ON I.staffid=S.staffid
                               INNER JOIN invoicedetail ID ON I.invoiceid=ID.invoiceid
                               GROUP BY I.invoiceid";
                DataSet ds = DBUtility.ExecuteQuery(sql);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public void exchangeProduct(int invoiceid, int oldProductId, int newProductId, decimal quantity)
        {
            /*
             * Reduce Invoice Detail on Old Product
             * -> Increase quantity in stock
             * If(NewProduct exist) -> += quantity
             * else -> insert to InvoiceDetail
             * -> Reduce quantity in stock
            */
            MySqlConnection con = DBUtility.getConnection();
            if (con != null)
                con.Open();
            {
                try
                {
                    //Reduce Quantity of OldProduct in Invoice
                    String sql = "UPDATE InvoiceDetail SET Quantity=Quantity-@quantity WHERE Invoiceid=@invoiceid AND ProductId=@productid";
                    MySqlCommand invCommand = new MySqlCommand(sql, con);
                    invCommand.Prepare();
                    invCommand.Parameters.AddWithValue("@quantity", quantity);
                    invCommand.Parameters.AddWithValue("@invoiceid", invoiceid);
                    invCommand.Parameters.AddWithValue("@productid", oldProductId);
                    invCommand.ExecuteNonQuery();

                    //Increase Quantity of OldProduct in Stock
                    String addProductSql = "UPDATE StoreProduct SET Quantity=Quantity+@quantity WHERE ProductId=@productid AND StoreId=(SELECT StoreID FROM Staffs WHERE Staffid=(SELECT Staffid FROM Invoices WHERE Invoiceid=@invoiceid))";
                    MySqlCommand addProductCommand = new MySqlCommand(addProductSql, con);
                    addProductCommand.Prepare();
                    addProductCommand.Parameters.AddWithValue("@quantity", quantity);
                    addProductCommand.Parameters.AddWithValue("@invoiceid", invoiceid);
                    addProductCommand.Parameters.AddWithValue("@productid", oldProductId);
                    addProductCommand.ExecuteNonQuery();

                    //Increase Quantity of newProduct in Invoice
                    String newProductSql = "UPDATE InvoiceDetail SET Quantity=Quantity+@quantity WHERE Invoiceid=@invoiceid AND ProductId=@productid";
                    MySqlCommand newProductCommand = new MySqlCommand(newProductSql, con);
                    newProductCommand.Prepare();
                    newProductCommand.Parameters.AddWithValue("@quantity", quantity);
                    newProductCommand.Parameters.AddWithValue("@invoiceid", invoiceid);
                    newProductCommand.Parameters.AddWithValue("@productid", newProductId);
                    int row = newProductCommand.ExecuteNonQuery();

                    if (row == 0)
                    {
                        //Increase Quantity of newProduct in Invoice
                        String addInvoiceDetailSql = "INSERT INTO InvoiceDetail VALUES(@invoiceid, @productid, @quantity, (SELECT Pricein FROM Products WHERE Productid=@productid), (SELECT Priceout FROM Products WHERE Productid=@productid), (SELECT ID2.Discount FROM InvoiceDetail ID2 WHERE Productid=@oldproductid AND Invoiceid=@invoiceid))";
                        MySqlCommand newInvoiceDetailCommand = new MySqlCommand(addInvoiceDetailSql, con);
                        newInvoiceDetailCommand.Prepare();
                        newInvoiceDetailCommand.Parameters.AddWithValue("@quantity", quantity);
                        newInvoiceDetailCommand.Parameters.AddWithValue("@invoiceid", invoiceid);
                        newInvoiceDetailCommand.Parameters.AddWithValue("@productid", newProductId);
                        newInvoiceDetailCommand.Parameters.AddWithValue("@oldproductid", oldProductId);
                        newInvoiceDetailCommand.ExecuteNonQuery();
                    }

                    //Increase Quantity of OldProduct in Stock
                    String reduceProductSql = "UPDATE StoreProduct SET Quantity=Quantity-@quantity WHERE ProductId=@productid AND StoreId=(SELECT StoreID FROM Staffs WHERE Staffid=(SELECT Staffid FROM Invoices WHERE Invoiceid=@invoiceid))";
                    MySqlCommand reduceProductCommand = new MySqlCommand(reduceProductSql, con);
                    reduceProductCommand.Prepare();
                    reduceProductCommand.Parameters.AddWithValue("@quantity", quantity);
                    reduceProductCommand.Parameters.AddWithValue("@invoiceid", invoiceid);
                    reduceProductCommand.Parameters.AddWithValue("@productid", newProductId);
                    reduceProductCommand.ExecuteNonQuery();
                    
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    con.Close();
                }
            }            
            
        }

        public void cancelInvoice(int invoiceid)
        {
            /*
             * Increase Quantity in Stock
             * Get Total Amount
             * Remove invoiceDetail by invoiceid
             * Remove invoice by invoiceid
             * Add tansaction withdrawal with Remark: Cancel Invoice...
             */
            MySqlConnection con = DBUtility.getConnection();
            if (con != null)
                con.Open();
            {
                try
                {
                    Invoice invoice = getInvoice(invoiceid);
                    decimal total = 0;
                    for (int i = 0; i < invoice.InvoiceDetail.Count; i++)
                    {

                        InvoiceDetail invoiceDetail = ((InvoiceDetail)invoice.InvoiceDetail[i]);
                        total += (invoiceDetail.Priceout * invoiceDetail.Quantity * (100 - invoiceDetail.Dicount));

                        String addProductSql = "UPDATE StoreProduct SET Quantity=Quantity+@quantity WHERE ProductId=@productid AND StoreId=(SELECT StoreID FROM Staffs WHERE Staffid=(SELECT Staffid FROM Invoices WHERE Invoiceid=@invoiceid))";
                        MySqlCommand addProductCommand = new MySqlCommand(addProductSql, con);
                        addProductCommand.Prepare();
                        addProductCommand.Parameters.AddWithValue("@quantity", ((InvoiceDetail)invoice.InvoiceDetail[i]).Quantity);
                        addProductCommand.Parameters.AddWithValue("@invoiceid", invoiceid);
                        addProductCommand.Parameters.AddWithValue("@productid", ((InvoiceDetail)invoice.InvoiceDetail[i]).Product.Productid);
                        addProductCommand.ExecuteNonQuery();
                    }
                    String removeDetailSql = "DELETE FROM InvoiceDetail WHERE InvoiceId=" + invoiceid;
                    MySqlCommand removeDetailCommand = new MySqlCommand(removeDetailSql, con);
                    removeDetailCommand.ExecuteNonQuery();

                    String removeInvoiceSql = "DELETE FROM Invoices WHERE InvoiceId=" + invoiceid;
                    MySqlCommand removeInvoiceCommand = new MySqlCommand(removeInvoiceSql, con);
                    removeInvoiceCommand.ExecuteNonQuery();

                    Transaction t = new Transaction();
                    t.Incomeamount = 0;
                    t.Expenseamount = total;
                    t.Createdby = UserSession.Session.Staff;
                    t.Remark = "Cancel on InvoiceID: " + invoiceid;
                    new TransactionDAO().AddTransaction(t);
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }

    }
}