using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeOver_Paris.Forms.Member
{
    public partial class FrmMembers : Form
    {
        public FrmMembers()
        {
            InitializeComponent();
        }

        private void FrmMembers_Load(object sender, EventArgs e)
        {
            // TODO: TO MAKE THE PANEL IN THE CENTER OF THE WINDOW
            Panel1.Left = (this.Width - Panel1.Width) / 2;
            Panel1.Top = (this.Height - Panel1.Height) / 2;

            // TODO: TO GET ALL THE MEMBERS
            DAO.MemberDAO memberDAO = new DAO.MemberDAO();
            DataSet ds = memberDAO.getAllMembersWithDataSet();

            // TODO: TO BIND DATASET TO THE DataGridView
            dgvMember.DataSource = ds.Tables[0];
            dgvMember.Columns[7].Visible = false;
            dgvMember.Columns[8].Visible = false;

            // TODO: TO SET THE COLUMN NAME OF THE DataGridView
            Utility.setGridHeaderText("ID|Code|Name|Phone Number|Discount Rate|Created Date|Created By",dgvMember);

            // TODO: TO SET THE WIDTH SIZE OF THE DataGridView
            Utility.setGridHeaderWidth("30|70|150|100|100|100|150", dgvMember);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvMember.DataSource;
            bs.Filter = "membername LIKE '%" + txtSearch.Text + "%' OR "
                      + "createdby LIKE '%" + txtSearch.Text + "%' OR "
                      + "phonenumber LIKE '%" + txtSearch.Text + "%' ";
            dgvMember.DataSource = bs;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            //btnAddMember.BackColor = Color.White;
            //btnAddMember.ForeColor = Color.Black;
            FrmAddMember frmAddMember = new FrmAddMember();
            frmAddMember.Show();
            this.Hide();
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            FrmUpdateMember frmUpdateMember = new FrmUpdateMember();
            frmUpdateMember.txtID.Text = dgvMember.CurrentRow.Cells[0].Value.ToString();
            frmUpdateMember.txtCode.Text = dgvMember.CurrentRow.Cells[1].Value.ToString();
            frmUpdateMember.txtName.Text = dgvMember.CurrentRow.Cells[2].Value.ToString();
            frmUpdateMember.txtPhoneNumber.Text = dgvMember.CurrentRow.Cells[3].Value.ToString();
            frmUpdateMember.txtDiscountRate.Text = dgvMember.CurrentRow.Cells[4].Value.ToString();
            frmUpdateMember.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.FrmMain frmMain = new Forms.FrmMain();
            frmMain.Show();
            this.Close();
        }
    }
}
