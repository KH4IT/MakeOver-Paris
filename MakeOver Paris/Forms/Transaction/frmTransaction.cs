using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MakeOver_Paris.DAO;
using MakeOver_Paris.DTO;
using System.Data;

namespace MakeOver_Paris.Forms.Transaction
{
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.FrmMain frmMain = new Forms.FrmMain();
            frmMain.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new TransactionDAO().GetAllTransactions();
            dgvTransaction.DataSource = dataSet.Tables[0];
            Utility.setGridHeaderText("ល.រ|កាលបរិច្ឆេទ|ចំនូល|ចំណាយ|ប្រតិបត្តិដោយ|សគាល់", dgvTransaction);
            Utility.setGridHeaderWidth("100", dgvTransaction);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvTransaction.DataSource;
            bs.Filter = "staffname LIKE '%" + txtSearch.Text + "%'";
            dgvTransaction.DataSource = bs;
        }

    }
}
