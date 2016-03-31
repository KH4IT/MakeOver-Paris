using MakeOver_Paris.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeOver_Paris.Forms.Report
{
    public partial class FrmReport : Form
    {
        private DAO.ProductDAO productDAO;
        private DAO.InvoiceDAO invoiceDAO;
        private DAO.TransactionDAO transactionDAO;
        private DAO.MemberDAO memberDAO;
        private DAO.StaffDAO staffDAO;
        public FrmReport()
        {
            InitializeComponent();
            productDAO = new DAO.ProductDAO();
            invoiceDAO = new DAO.InvoiceDAO();
            transactionDAO = new DAO.TransactionDAO();
            memberDAO = new DAO.MemberDAO();
            staffDAO = new DAO.StaffDAO();
            DataSet ds = new DAO.StaffDAO().GetAllStaffs();

            //DataRow dr = new DataRow("SELECT");
            //ds.Tables[0].Rows.InsertAt(,0);
            cboStaffs.DataSource = ds.Tables[0];
            cboStaffs.DisplayMember = "staffname";
            cboStaffs.ValueMember = "staffid";
            //cboMember.Items.Insert(0, "-Select-");
        }

        private void FrmReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBack_Click(sender, e);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.FrmMain frmMain = new Forms.FrmMain();
            frmMain.Show();
            this.Close();
        }

        private void cbxReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboStaffs.Visible = false;
                if (cbxReportType.SelectedIndex == 0)
                {
                    InvisibleFilter();
                    DataSet dataSet = staffDAO.GetAllStaffs();
                    dgvReport.DataSource = dataSet.Tables[0];
                    Utility.setGridHeaderText("ល.រ|ឈ្មោះ|ប្រភេទ|ថ្ងៃចូល|អត្រាចំណាញ|ស្តុក", dgvReport);
                    if (dgvReport.Rows.Count > 0)
                    {
                        dgvReport.Columns["staffpassword"].Visible = false;
                    }
                }
                else if (cbxReportType.SelectedIndex == 1)
                {
                    InvisibleFilter();
                    // TODO: TO GET ALL THE MEMBERS
                    DataSet ds = memberDAO.getAllMembersWithDataSet();

                    // TODO: TO BIND DATASET TO THE DataGridView
                    dgvReport.DataSource = ds.Tables[0];

                    // TODO: TO SET THE COLUMN NAME OF THE DataGridView
                    Utility.setGridHeaderText("ល.រ|លេខកូដ|ឈ្មោះ|ទូរសព្ទ័|អត្រាភាគរយ|កាលបរិច្ជេទបង្កើត|បង្កើតដោយ|សមាជិក|កាលបរិច្ឆទកែប្រែ|កែប្រែដោយ", dgvReport);

                    // TODO: TO SET THE WIDTH SIZE OF THE DataGridView
                    Utility.setGridHeaderWidth("50|70|150|100|100|150|100|150|150|100", dgvReport);

                    dgvReport.Columns["membertypeid"].Visible = false;
                }
                else if (cbxReportType.SelectedIndex == 2)
                {
                    InvisibleFilter();
                    dgvReport.DataSource = productDAO.getAllProductDS().Tables[0];
                    Utility.setGridHeaderText("ល.រ|លេខទំនិញ|បារកូដ|ឈ្មោះ|បរិមាណ|សាខា|តម្លៃទិញចូល|តម្លៃលក់ចេញ|បរិមាណប្តូរវិញ|បង្កើតដោយ|កែប្រែដោយ|កាលបរិច្ឆេទបង្កើត|កាលបរិច្ឆេទកែប្រែ|ប្រភេទ|បរិយាយ|កំណត់ចំណាំ", dgvReport);
                    Utility.setGridHeaderWidth("30", dgvReport);
                }
                else if (cbxReportType.SelectedIndex == 3)
                {
                    // TODO: TO GET ALL THE MEMBERS
                    //InvisibleFilter();
                    VisibleFilter();
                    getAllCashBook();
                }
                else if (cbxReportType.SelectedIndex == 4)
                {
                    InvisibleFilter();
                    // TODO: TO GET ALL THE MEMBERS
                    DataSet dataSet = invoiceDAO.getAllInvoices();
                    dgvReport.DataSource = dataSet.Tables[0];
                    Utility.setGridHeaderText("លេខកូដវិក្ក័យប័ត្រ|កាលបរិច្ឆេទចេញវិក្ក័យប័ត្រ|ឈ្មោះអ្នកលក់|តម្លៃសរុប", dgvReport);
                    Utility.setGridHeaderWidth("100|200|300|200", dgvReport);
                    dgvReport.Columns["id"].Visible = false;
                }
                else if (cbxReportType.SelectedIndex == 5)
                {
                    VisibleFilter();
                    filterProductSold(dpStartDate.Text, dpEndDate.Text);
                }
                else if (cbxReportType.SelectedIndex == 6)
                {
                    //filterStaffComission();
                    cboStaffs.Visible = true;
                    VisibleFilter();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void filterProductSold(string startDate, string endDate)
        {
            DataSet dataSet = productDAO.getAllProductsSold(startDate, endDate);
            dgvReport.DataSource = dataSet.Tables[0];
            Utility.setGridHeaderText("លេខកូដទំនិញ|ឈ្មោះទំនិញ|ចំនួនវិក្ក័យប័ត្រ", dgvReport);
            Utility.setGridHeaderWidth("100|500|200", dgvReport);
        }

        private void VisibleFilter()
        {
            lblEndDate.Visible = true;
            lblStartDate.Visible = true;
            dpEndDate.Visible = true;
            dpStartDate.Visible = true;
        }

        private void InvisibleFilter()
        {
            lblEndDate.Visible = false;
            lblStartDate.Visible = false;
            dpEndDate.Visible = false;
            dpStartDate.Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            String dirUrl = new DAO.SettingDao().getValue("SaveAddress");
            System.IO.Directory.CreateDirectory(dirUrl);
            String currentDate = Convert.ToDateTime(DateTime.Now).ToString("dd_MM_yyyy").ToString();
            try
            {
                switch (cbxReportType.SelectedIndex)
                {
                    case 0:
                        rpt_ListStaff staffs = new rpt_ListStaff();
                        staffs.Refresh();
                        staffs.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, dirUrl + "Staff_" + currentDate + ".pdf");
                        break;
                    case 1:
                        rpt_ListMembers listmember = new rpt_ListMembers();
                        listmember.Refresh();
                        listmember.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, dirUrl + "Member_" + currentDate + ".pdf");
                        break;
                    case 2:
                        rpt_ListOfProducts products = new rpt_ListOfProducts();
                        products.Refresh();
                        products.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, dirUrl + "Product_" + currentDate + ".pdf");
                        break;
                    case 3:
                        rpt_Cashbook cashbook = new rpt_Cashbook();
                        cashbook.Refresh();
                        cashbook.SetParameterValue("p_startdate", dpStartDate.Text);
                        cashbook.SetParameterValue("p_enddate", dpEndDate.Text);
                        cashbook.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, dirUrl + "Cashbook_" + currentDate + ".pdf");
                        break;
                    case 4:
                        rpt_ListInvoice invoices = new rpt_ListInvoice();
                        invoices.Refresh();
                        invoices.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, dirUrl + "List of Invoice_" + currentDate + ".pdf");
                        break;
                    case 5:
                        rpt_ListProductSold productSold = new rpt_ListProductSold();
                        productSold.Refresh();
                        productSold.SetParameterValue("p_startdate", dpStartDate.Text);
                        productSold.SetParameterValue("p_enddate", dpEndDate.Text);
                        productSold.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, dirUrl + "Product Sold_" + currentDate + ".pdf");
                        break;
                    case 6:
                        rpt_StaffProfit staffprofit = new rpt_StaffProfit();
                        staffprofit.Refresh();
                        int staffid = (int)cboStaffs.SelectedValue;
                        staffprofit.SetParameterValue("p_staffid", staffid);
                        staffprofit.SetParameterValue("p_startdate", dpStartDate.Text);
                        staffprofit.SetParameterValue("p_enddate", dpEndDate.Text);
                        staffprofit.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, dirUrl + "Staff Profit _" + currentDate + ".pdf");
                        break;
                }
                System.Diagnostics.Process.Start(@dirUrl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void dpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (cbxReportType.SelectedIndex == 3)
            {
                getAllCashBook();
            }
            else if (cbxReportType.SelectedIndex == 5)
            {
                filterProductSold(dpStartDate.Text, dpEndDate.Text);
            }
            else if (cbxReportType.SelectedIndex == 6)
            {
                filterStaffComission();
            }
        }

        private void dpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (cbxReportType.SelectedIndex == 3)
            {
                getAllCashBook();
            }
            else if (cbxReportType.SelectedIndex == 5)
            {
                filterProductSold(dpStartDate.Text, dpEndDate.Text);
            }
            else if (cbxReportType.SelectedIndex == 6)
            {
                filterStaffComission();
            }
            //MessageBox.Show(Convert.ToDateTime(dpEndDate.Text).ToString("yyyy-MM-dd"));
        }

        private void getAllCashBook()
        {
            DataSet dataSet = transactionDAO.GetAllCashBook(dpStartDate.Text, dpEndDate.Text);
            dgvReport.DataSource = dataSet.Tables[0];
            Utility.setGridHeaderText("ល.រ|កាលបរិច្ឆេទ|ចំនូល|ចំណាយ|ប្រតិបត្តិដោយ|សគាល់", dgvReport);
            Utility.setGridHeaderWidth("100", dgvReport);
        }

        private void cboStaffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterStaffComission();
        }

        private void filterStaffComission()
        {
            int staffid = -1;
            try
            {
                 staffid = (int)cboStaffs.SelectedValue;
            }
            catch (Exception e){}
            if (staffid < 0)
            {
                return;
            }
            dgvReport.DataSource = staffDAO.getStaffComission(staffid, dpStartDate.Text, dpEndDate.Text).Tables[0];
            Utility.setGridHeaderText("លេខ​វិក័យបត្រ|កាល​បរិច្ឆេទ|មុខ​ទំនិញ|បរិមាណ|តម្លៃរាយ|តម្លៃ​សរុប|កម្រៃ", dgvReport);
            Utility.setGridHeaderWidth("200", dgvReport);
        }
    }
}
