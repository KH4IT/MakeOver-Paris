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
    public partial class FrmFrontSaleOffice : Form
    {
        public FrmFrontSaleOffice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserSession.Session.Staff.Stafftype.ToLower() == "admin")
            {
                Forms.FrmMain frmMain = new Forms.FrmMain();
                frmMain.Show();
                this.Close();
            }
            else
            {
                UserSession.Session.Staff = null;
                Forms.FrmLogin form = new Forms.FrmLogin();
                form.Show();
                this.Close();
            }
        }

        private int insertToDB()
        {
            DTO.Invoice invoice = new DTO.Invoice();
            System.Collections.ArrayList details = new System.Collections.ArrayList();
            for (int i = 0; i < grdItems.Rows.Count; i++)
            {
                DTO.InvoiceDetail d = new DTO.InvoiceDetail();
                DTO.Product p = new DTO.Product();
                p.Productid = int.Parse(grdItems.Rows[i].Cells[7].Value.ToString());
                d.Quantity = int.Parse(grdItems.Rows[i].Cells[2].Value.ToString());
                d.Priceout = decimal.Parse(grdItems.Rows[i].Cells[3].Value.ToString());
                d.Dicount = decimal.Parse(grdItems.Rows[i].Cells[4].Value.ToString());
                d.Pricein = decimal.Parse(grdItems.Rows[i].Cells[8].Value.ToString());
                d.Product = p;
                details.Add(d);
            }
            
            DTO.Member member = new DTO.Member();
            member.Memberid = 1;            ///
            invoice.Staff = UserSession.Session.Staff;
            invoice.Member = member;
            invoice.Remark = "";
            //invoice.Discount = int.Parse(txtDiscount.Text.Replace("%", ""));
            invoice.InvoiceDetail = details;
            return new DAO.InvoiceDAO().addInvoice(invoice);
        }

        private void addToGrid(DTO.Product product)
        {
            int row = checkInGrid(product.Productid);
            if (row == -1)
            {
                if (product.Quantity >= 1)
                {
                    grdItems.Rows.Add(grdItems.RowCount + 1, product.Productname, 1, product.Priceout, 0, product.Priceout, "-", product.Productid, product.Pricein);
                }
                else
                {
                    MessageBox.Show("No Product In Stock");
                }
            }
            else
            {
                if (product.Quantity > int.Parse(grdItems.Rows[row].Cells[2].Value.ToString()))
                {
                    grdItems.Rows[row].Cells[2].Value = int.Parse(grdItems.Rows[row].Cells[2].Value.ToString()) + 1;
                    decimal subtotal = (decimal.Parse(grdItems.Rows[row].Cells[2].Value.ToString()) * decimal.Parse(grdItems.Rows[row].Cells[3].Value.ToString()));
                    decimal discount = subtotal*decimal.Parse(grdItems.Rows[row].Cells[4].Value.ToString())/100;
                    grdItems.Rows[row].Cells[5].Value = subtotal - discount;
                }
                else
                {
                    MessageBox.Show("Not enought product in stock");
                }

            }
            calculate();
        }

        private int checkInGrid(int productid)
        {
            int row = -1;
            for (int i = 0; i < grdItems.RowCount; i++)
            {
                if (grdItems.Rows[i].Cells[7].Value.ToString() == (productid + ""))
                {
                    row = i;
                    break;
                }
            }
            return row;
        }

        int count_enter = 0;

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCode.Text != "")
                {
                    count_enter = 0;
                    DTO.Product product = new DAO.ProductDAO().getProduct(txtCode.Text, UserSession.Session.Staff.StoreId);
                    if (product != null)
                    {
                        addToGrid(product);
                    }
                    else
                    {
                        MessageBox.Show("No Product Found");
                    }
                    txtCode.Clear();
                }
                else if (grdItems.Rows.Count > 0)
                {
                    count_enter += 1;
                }
                if (count_enter >= 2)
                {
                    int invoiceid = insertToDB();
                    if (invoiceid != -1)
                    {
                        decimal total = decimal.Parse(lblDollar.Text.Substring(0, lblDollar.Text.Length-2));
                        
                        FrmPay frmPay = new FrmPay();
                        frmPay.txtTotal.Text = total.ToString();
                        frmPay.invoiceid = invoiceid;
                        frmPay.ShowDialog();
                        grdItems.Rows.Clear();
                    }
                    count_enter = 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // Report.rpt_ListOfProducts rpt = new Report.rpt_ListOfProducts();
//            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "E:/test.pdf");

        }

        private void FrmFrontSaleOffice_Load(object sender, EventArgs e)
        {
            DataSet ds = new DAO.MemberDAO().getAllMembersWithDataSet();
            
            //DataRow dr = new DataRow("SELECT");
            //ds.Tables[0].Rows.InsertAt(,0);
            cboMember.DataSource = ds.Tables[0];
            cboMember.DisplayMember = "membername";
            cboMember.ValueMember = "memberid";
            //cboMember.Items.Insert(0, "-Select-");

        }

        private void cboMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMember.SelectedIndex != 0)
            {
                int memberid = (int)cboMember.SelectedValue;
                DTO.Member member = new DAO.MemberDAO().getMemberById(memberid);
                txtDiscount.Text = member.Discountrate + " %";
            }
            else
            {
                txtDiscount.Text = "0.00 %";
            }
            calculate();

        }

        private void calculate()
        {
            decimal total = 0;
            for (int i = 0; i < grdItems.Rows.Count; i++)
            {
                total += decimal.Parse(grdItems.Rows[i].Cells[5].Value.ToString());
            }
            total = (total * (100 - decimal.Parse(txtDiscount.Text.Substring(0, txtDiscount.Text.Length - 2))) / 100);
            lblDollar.Text = total + "";
            decimal rate = decimal.Parse(new DAO.SettingDao().getValue("ExchangeRate"));
            lblRiel.Text = (decimal.Parse(lblDollar.Text) * rate).ToString();
        }

        private void grdItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                grdItems.Rows.RemoveAt(e.RowIndex);
                for (int i = 1; i < grdItems.RowCount; i++)
                {
                    grdItems.Rows[i - 1].Cells[0].Value = i;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int invoiceid = insertToDB();
            if (invoiceid != -1)
            {
                decimal total = decimal.Parse(lblDollar.Text.Substring(0, lblDollar.Text.Length - 2));


                FrmPay frmPay = new FrmPay();
                frmPay.txtTotal.Text = total.ToString();
                frmPay.invoiceid = invoiceid;
                frmPay.ShowDialog();
                grdItems.Rows.Clear();
            }
            count_enter = 0;
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            calculate();
        }

        private void btnCheckProduct_Click(object sender, EventArgs e)
        {
            //new FrmCheckProduct().Show();
            new FrmCheckProductNew().Show();
        }

        private void grdItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            row_calculate(e.RowIndex);
        }

        private void row_calculate(int row)
        {
            decimal subtotal = (decimal.Parse(grdItems.Rows[row].Cells[2].Value.ToString()) * decimal.Parse(grdItems.Rows[row].Cells[3].Value.ToString()));
            decimal discount = subtotal * decimal.Parse(grdItems.Rows[row].Cells[4].Value.ToString()) / 100;
            grdItems.Rows[row].Cells[5].Value = subtotal - discount;
            calculate();
        }

        private void btnExchangeProduct_Click(object sender, EventArgs e)
        {
            //new FrmExchageProduct().Show();
            new FrmExchangeProductNew().Show();
        }



    }
}
