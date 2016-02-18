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

namespace MakeOver_Paris.Forms.Transaction
{
    public partial class frmTransaction : Form
    {
        int id;
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
            if (id == 0)
            {
                if (txtExpenseAmount.Text == "" && txtIncomeAmount.Text == "")
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                }
                else
                {
                    DTO.Staff staff = new DTO.Staff();
                    // GET FROM USER SESSION
                    staff.Staffid = 1;
                    // CONVERTING VALIDATION
                    decimal incomeAmount = 0;
                    decimal expenseAmount = 0;
                    if (txtIncomeAmount.Text != "")
                        incomeAmount = System.Convert.ToDecimal(txtIncomeAmount.Text);
                    else
                        incomeAmount = 0;
                    if (txtExpenseAmount.Text != "")
                        expenseAmount = System.Convert.ToDecimal(txtExpenseAmount.Text);
                    else
                        expenseAmount = 0;

                    DTO.Transaction tran = new DTO.Transaction(incomeAmount
                                                               , expenseAmount
                                                               , staff
                                                               , txtRemark.Text);
                    if (new TransactionDAO().AddTransaction(tran))
                    {
                        txtIncomeAmount.Clear();
                        txtExpenseAmount.Clear();
                        txtRemark.Clear();
                        txtIncomeAmount.Enabled = true;
                        txtExpenseAmount.Enabled = true;
                        dgvTransaction.DataSource = new DAO.TransactionDAO().GetAllTransactions().Tables[0];
                        id = 0;
                    }
                    else
                    {
                        MessageBox.Show("ប្រតិបត្តិការណ៍បរាជ័យ!!!");
                    }
                }
            }
            else
            {
                DTO.Staff staff = new DTO.Staff();
                // GET FROM USER SESSION
                staff.Staffid = UserSession.Session.Staff.Staffid;
                // CONVERTING VALIDATION
                decimal incomeAmount = 0;
                decimal expenseAmount = 0;
                if (txtIncomeAmount.Text != "")
                    incomeAmount = System.Convert.ToDecimal(txtIncomeAmount.Text);
                else
                    incomeAmount = 0;
                if (txtExpenseAmount.Text != "")
                    expenseAmount = System.Convert.ToDecimal(txtExpenseAmount.Text);
                else
                    expenseAmount = 0;

                DTO.Transaction tran = new DTO.Transaction(incomeAmount
                                                           , expenseAmount
                                                           , staff
                                                           , txtRemark.Text);
                tran.Transactionid = id;
                if (new TransactionDAO().UpdateTransaction(tran))
                {
                    txtIncomeAmount.Clear();
                    txtExpenseAmount.Clear();
                    txtRemark.Clear();
                    txtIncomeAmount.Enabled = true;
                    txtExpenseAmount.Enabled = true;
                    dgvTransaction.DataSource = new DAO.TransactionDAO().GetAllTransactions().Tables[0];
                    id = 0;
                    btnDelete.Enabled = false;
                }
                else
                {

                }
            }
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new TransactionDAO().GetAllTransactions();
            dgvTransaction.DataSource = dataSet.Tables[0];
            Utility.setGridHeaderText("ល.រ|កាលបរិច្ឆេទ|ចំនូល|ចំណាយ|ប្រតិបត្តិដោយ|សគាល់", dgvTransaction);
            Utility.setGridHeaderWidth("100", dgvTransaction);
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvTransaction.DataSource;
            bs.Filter = "staffname LIKE '%" + txtSearch.Text + "%'";
            dgvTransaction.DataSource = bs;
        }

        private void txtIncomeAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        private void txtExpenseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        private void txtIncomeAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void txtExpenseAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void txtIncomeAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtIncomeAmount.Text != "")
                txtExpenseAmount.Enabled = false;
            else
                txtExpenseAmount.Enabled = true;
        }

        private void txtExpenseAmount_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtExpenseAmount.Text != "")
                txtIncomeAmount.Enabled = false;
            else
                txtIncomeAmount.Enabled = true;
        }

        private void dgvTransaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = System.Convert.ToInt32(dgvTransaction.CurrentRow.Cells[0].Value.ToString());
                txtIncomeAmount.Text = dgvTransaction.CurrentRow.Cells[2].Value.ToString();
                txtExpenseAmount.Text = dgvTransaction.CurrentRow.Cells[3].Value.ToString();
                txtRemark.Text = dgvTransaction.CurrentRow.Cells[5].Value.ToString();
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

    }
}
