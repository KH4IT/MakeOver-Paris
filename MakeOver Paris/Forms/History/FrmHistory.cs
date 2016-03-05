using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeOver_Paris.Forms.History
{
    public partial class FrmHistory : Form
    {
        public FrmHistory()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.FrmMain frmMain = new Forms.FrmMain();
            frmMain.Show();
            this.Close();
        }

        private void FrmHistory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBack_Click(sender, e);
            }
        }

        private void FrmHistory_Load(object sender, EventArgs e)
        {
            DataSet invoices = new DAO.InvoiceDAO().getAllInvoices();
            dgvReport.DataSource = invoices.Tables[0];
            Utility.setGridHeaderText("លេខកូដវិក្ក័យប័ត្រ|កាលបរិច្ឆេទចេញវិក្ក័យប័ត្រ|ឈ្មោះអ្នកលក់|តម្លៃសរុប", dgvReport);
            Utility.setGridHeaderWidth("100|200|300|200", dgvReport);
            dgvReport.Columns["id"].Visible= false;
               
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvReport.DataSource;
            bs.Filter = "staffname LIKE '%" + textBox1.Text + "%'";
            dgvReport.DataSource = bs;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvReport.DataSource;
            bs.Filter = "Convert(invoicedate,'System.String') LIKE '%" + textBox2.Text + "%'";
            dgvReport.DataSource = bs;
        }

        private void btnPrintInvoice_Click_1(object sender, EventArgs e)
        {
            Forms.History.FrmInvoiceView invoiceView = new Forms.History.FrmInvoiceView();
            invoiceView.id = System.Convert.ToInt32(dgvReport.CurrentRow.Cells["id"].Value.ToString());
            invoiceView.Show();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("តើ​អ្នកពិតជាចង់លុបវិក្កយបត្រនេះមែនឬទេ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new DAO.InvoiceDAO().cancelInvoice(int.Parse(dgvReport.Rows[dgvReport.CurrentRow.Index].Cells[0].Value.ToString().Substring(7)));
                FrmHistory_Load(sender, e);
            }
        }

    }
}
