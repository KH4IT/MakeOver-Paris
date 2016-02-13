using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeOver_Paris.Forms.Sale
{
    public partial class FrmSale : Form
    {
        public FrmSale()
        {
            InitializeComponent();
        }

        int count_enter = 0;

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.FrmMain frmMain = new Forms.FrmMain();
            frmMain.Show();
            this.Close();
        }

        private bool print()
        {
            DTO.Invoice invoice = new DTO.Invoice();
            System.Collections.ArrayList details = new System.Collections.ArrayList();
            for (int i = 0; i < grdItems.Rows.Count; i++)
            {
                DTO.InvoiceDetail d = new DTO.InvoiceDetail();
                DTO.Product p = new DTO.Product();
                p.Productid = int.Parse(grdItems.Rows[i].Cells[6].Value.ToString());
                d.Quantity = int.Parse(grdItems.Rows[i].Cells[2].Value.ToString());
                d.Priceout = decimal.Parse(grdItems.Rows[i].Cells[3].Value.ToString());
                d.Pricein = decimal.Parse(grdItems.Rows[i].Cells[7].Value.ToString());
                d.Product = p;
                details.Add(d);
            }
            Data.user = new DTO.Staff();
            Data.user.Staffid = 2;
            DTO.Member member = new DTO.Member();
            member.Memberid = 1;
            invoice.Staff = Data.user;
            invoice.Member = member;
            invoice.Remark = "";
            invoice.Discount = 10;
            invoice.InvoiceDetail = details;
            return new DAO.InvoiceDAO().addInvoice(invoice);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (print())
            {
                grdItems.Rows.Clear();
             //   rpt_saleinvoice rpt = new rpt_saleinvoice();
              //  rpt.SetParameterValue("p_invoiceid", 25);


                //rpt.PrintToPrinter(1, false, 1, 1);
            }
            count_enter = 0;
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCode.Text != "")
                {
                    count_enter = 0;
                    DTO.Product product = new DAO.ProductDao().getProduct(int.Parse(txtCode.Text));//replace by productcode as a overload method
                    addToGrid(product);
                    txtCode.Clear();
                }
                else
                {
                    count_enter += 1;
                }
                if (count_enter >= 2)
                {
                    if (print())
                    {
                        grdItems.Rows.Clear();
                      //  rpt_saleinvoice rpt = new rpt_saleinvoice();
                     //   rpt.SetParameterValue("p_invoiceid", 25);


                        //rpt.PrintToPrinter(1, false, 1, 1);
                    }
                    count_enter = 0;
                }
            }
        }

        private void addToGrid(DTO.Product product)
        {
            int row = checkInGrid(product.Productid);
            if (row == -1)
            {
                grdItems.Rows.Add(grdItems.RowCount + 1, product.Productname, 1, product.Priceout, product.Priceout, "-", product.Productid, product.Pricein);
            }
            else
            {
                grdItems.Rows[row].Cells[2].Value = int.Parse(grdItems.Rows[row].Cells[2].Value.ToString()) + 1;
            }
        }

        private int checkInGrid(int productid)
        {
            int row = -1;
            for (int i = 0; i < grdItems.RowCount; i++)
            {
                if (grdItems.Rows[i].Cells[6].Value.ToString() == (productid + ""))
                {
                    row = i;
                    break;
                }
            }
            return row;
        }

        private void grdItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                grdItems.Rows.RemoveAt(e.RowIndex);
                for (int i = 1; i < grdItems.RowCount; i++)
                {
                    grdItems.Rows[i - 1].Cells[0].Value = i;
                }
            }
        }



    }
}
