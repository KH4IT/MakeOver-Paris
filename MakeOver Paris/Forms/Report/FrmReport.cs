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
            if (cbxReportType.SelectedIndex == 0)
            {
                InvisibleFilter();
                DataSet dataSet = staffDAO.GetAllStaffs();
                dgvReport.DataSource = dataSet.Tables[0];
                Utility.setGridHeaderText("ល.រ|ឈ្មោះ|លេខសម្ងាត់|ប្រភេទ|ថ្ងៃចូលធ្វើការ|អត្រាចំណាញ", dgvReport);
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
                Utility.setGridHeaderText("ល.រ|លេខកូដ|ឈ្មោះ|ទូរសព្ទ័|អត្រាភាគរយ|កាលបរិច្ជេទបង្កើត|បង្កើតដោយ|កាលបរិច្ឆទកែប្រែ|កែប្រែដោយ" , dgvReport);

                // TODO: TO SET THE WIDTH SIZE OF THE DataGridView
                Utility.setGridHeaderWidth("30|70|150|100|100|100|150|100|150", dgvReport);
            }
            else if (cbxReportType.SelectedIndex == 2)
            {
                InvisibleFilter();
                dgvReport.DataSource = productDAO.getAllProductDS().Tables[0];
                Utility.setGridHeaderText("ល.រ|លេខទំនិញ|បារកូដ|ឈ្មោះ|បរិមាណ|តម្លៃទិញចូល|តម្លៃលក់ចេញ|បរិមាណប្តូរវិញ|បង្កើតដោយ|កែប្រែដោយ|កាលបរិច្ឆេទបង្កើត|កាលបរិច្ឆេទកែប្រែ|ប្រភេទ|បរិយាយ|កំណត់ចំណាំ", dgvReport);
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
            }
            else if (cbxReportType.SelectedIndex == 5)
            {
                VisibleFilter();
                filterProductSold(dpStartDate.Text, dpEndDate.Text);
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
            MessageBox.Show(Convert.ToDateTime(dpEndDate.Text).ToString("yyyy-MM-dd"));
        }

        private void getAllCashBook()
        {
            DataSet dataSet = transactionDAO.GetAllCashBook(dpStartDate.Text, dpEndDate.Text);
            dgvReport.DataSource = dataSet.Tables[0];
            Utility.setGridHeaderText("ល.រ|កាលបរិច្ឆេទ|ចំនូល|ចំណាយ|ប្រតិបត្តិដោយ|សគាល់", dgvReport);
            Utility.setGridHeaderWidth("100", dgvReport);
        }
    }
}
