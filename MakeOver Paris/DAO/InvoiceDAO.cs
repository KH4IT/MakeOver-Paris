using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MakeOver_Paris.DTO;
using MySql.Data.MySqlClient;

namespace MakeOver_Paris.DAO
{
    class InvoiceDAO
    {

        public Boolean addInvoice(Invoice invoice)
        {
            MySqlConnection con = DBUtility.getConnection();
            con.Open();
            if (con != null)
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
                        invDetailCommand.Parameters.AddWithValue("@invoiceid"+i, invoice.Invoiceid);
                        invDetailCommand.Parameters.AddWithValue("@productid"+i, ((InvoiceDetail)invoice.InvoiceDetail[i]).Product.Productid);
                        invDetailCommand.Parameters.AddWithValue("@quanity"+i, ((InvoiceDetail)invoice.InvoiceDetail[i]).Quantity);
                        invDetailCommand.Parameters.AddWithValue("@pricein"+i, ((InvoiceDetail)invoice.InvoiceDetail[i]).Pricein);
                        invDetailCommand.Parameters.AddWithValue("@priceout" + i, ((InvoiceDetail)invoice.InvoiceDetail[i]).Priceout);
                    }
                    invDetailCommand.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.ToString());
                    transaction.Rollback();
                }
                

                con.Close();
                return true;
            }
            return false;
        }

    }
}
