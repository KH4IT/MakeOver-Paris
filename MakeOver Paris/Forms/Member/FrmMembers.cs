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

namespace MakeOver_Paris.Forms.Member
{
    public partial class FrmMembers : Form
    {
        private int id;
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
            Utility.setGridHeaderText("ល.រ|លេខកូដ|ឈ្មោះ|ទូរសព្ទ័|អត្រាភាគរយ|កាលបរិច្ជេទចាប់ផ្តើម|ដោយ",dgvMember);

            // TODO: TO SET THE WIDTH SIZE OF THE DataGridView
            Utility.setGridHeaderWidth("30|70|150|100|100|100|150", dgvMember);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Forms.FrmMain frmMain = new Forms.FrmMain();
            frmMain.Show();
            this.Close();
        }

        private void FrmMembers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBack_Click_1(sender, e);
            }
        }

        private void txtDiscountRate_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtDiscountRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                if (txtName.Text == "" || txtPhone.Text == "" || txtCode.Text == "")
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                }
                else
                {
                    DTO.Member member = new DTO.Member();
                    member.Membername = txtName.Text;
                    member.MemberCode = txtCode.Text;
                    member.Phonenumber = txtPhone.Text;
                    DTO.Staff staff = new DTO.Staff();
                    staff.Staffid = UserSession.Session.Staff.Staffid;
                    member.Createdby = staff;
                    decimal discount = 0;
                    if (txtDiscountRate.Text != "")
                    {
                        discount = System.Convert.ToDecimal(txtDiscountRate.Text);
                    }
                    member.Discountrate = discount;
                    if (new MemberDAO().addMember(member))
                    {
                        txtName.Clear();
                        txtCode.Clear();
                        txtDiscountRate.Clear();
                        txtPhone.Clear();
                        dgvMember.DataSource = new DAO.MemberDAO().getAllMembersWithDataSet().Tables[0];
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
                DTO.Member member = new DTO.Member();
                member.Membername = txtName.Text;
                member.MemberCode = txtCode.Text;
                member.Phonenumber = txtPhone.Text;
                DTO.Staff staff = new DTO.Staff();
                staff.Staffid = UserSession.Session.Staff.Staffid;
                member.Updatedby = staff;
                member.Memberid = id;
                decimal discount = 0;
                if (txtDiscountRate.Text != "")
                {
                    discount = System.Convert.ToDecimal(txtDiscountRate.Text);
                }
                member.Discountrate = discount;
                if (new MemberDAO().updateMemeber(member))
                {
                    txtName.Clear();
                    txtCode.Clear();
                    txtDiscountRate.Clear();
                    txtPhone.Clear();
                    dgvMember.DataSource = new DAO.MemberDAO().getAllMembersWithDataSet().Tables[0];
                    id = 0;
                    delete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("ប្រតិបត្តិការណ៍បរាជ័យ!!!");
                }
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvMember.DataSource;
            bs.Filter = "membername LIKE '%" + txtSearch.Text + "%'";
            dgvMember.DataSource = bs;
        }

        private void dgvMember_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id = System.Convert.ToInt32(dgvMember.CurrentRow.Cells[0].Value.ToString());
                txtCode.Text = dgvMember.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = dgvMember.CurrentRow.Cells[2].Value.ToString();
                txtPhone.Text = dgvMember.CurrentRow.Cells[3].Value.ToString();
                txtDiscountRate.Text = dgvMember.CurrentRow.Cells[4].Value.ToString();
                delete.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("តើអ្នកពិតជាចង់លុបទិន្នន័យនេះមែនទេ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new MemberDAO().DeleteMember(id))
                {
                    txtName.Clear();
                    txtCode.Clear();
                    txtDiscountRate.Clear();
                    txtPhone.Clear();
                    delete.Enabled = false;
                    dgvMember.DataSource = new DAO.MemberDAO().getAllMembersWithDataSet().Tables[0];
                    id = 0;
                }
                else
                {
                    MessageBox.Show("ប្រតិបត្តិការណ៍បរាជ័យ!!!");
                }
            }
            else
            {
                // user clicked no
            }
        }

    }
}
