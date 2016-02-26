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

        public Boolean addInvoice(Invoice invoice)
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
                        sb.AppendFormat("(@invoiceid{0}, @productid{0}, @quanity{0}, @pricein{0}, @priceout{0}),", i);
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

                        String updateSql = "UPDATE Products SET quantity=quantity-@quantity WHERE productid=@productid";
                        MySqlCommand updateProductCommand = new MySqlCommand(updateSql, con);
                        updateProductCommand.Prepare();
                        updateProductCommand.Parameters.AddWithValue("@quantity", ((InvoiceDetail)invoice.InvoiceDetail[i]).Quantity);
                        updateProductCommand.Parameters.AddWithValue("@productid" + i, ((InvoiceDetail)invoice.InvoiceDetail[i]).Product.Productid);
                        updateProductCommand.ExecuteNonQuery();

                        //Product p = new ProductDao().getProduct(((InvoiceDetail)invoice.InvoiceDetail[i]).Product.Productid);
                        //p.Quantity -= ((InvoiceDetail)invoice.InvoiceDetail[i]).Quantity;
                        //new ProductDao().updateProduct(p);

                    }
                    invDetailCommand.ExecuteNonQuery();
                    transaction.Commit();
                    return true;
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
            return false;
        }

        public Invoice getInvoice(int invoiceId)
        {
            MySqlConnection con = DBUtility.getConnection();
            if (con != null)
                con.Open();
            {
                try
                {
                    MySqlCommand cmdInv = new MySqlCommand("SELECT I.invoiceid, I.invoicedate, I.remark, I.discount, ID.quantity, ID.pricein, ID.priceout, S.staffid, S.staffname, S.stafftype, M.memberid, M.membername, M.membercode, M.phonenumber, M.createddate, P.productid, P.productcode, P.barcode, P.productname, P.quantity, P.description FROM Invoices I INNER JOIN InvoiceDetail ID ON I.invoiceid=ID.invoiceid INNER JOIN Products P ON ID.productid=P.productid INNER JOIN Staffs S ON I.Staffid=S.Staffid INNER JOIN Members M ON I.memberid=M.memberid WHERE I.invoiceid=" + invoiceId, con);
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
                                    I.invoiceid
                                  , I.invoicedate
                                  , S.staffname
                                  , SUM(ID.quantity*ID.priceout)
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
    }
}