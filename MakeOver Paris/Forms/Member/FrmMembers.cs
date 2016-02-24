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
                if (txtName.Text == "")
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                }
                else
                {
                    DTO.Category category = new DTO.Category(txtName.Text);
                    if (new MemberDAO().addMember())
                    {
                        txtName.Clear();
                        dgvCategory.DataSource = new DAO.CategoryDAO().GetAllCategories().Tables[0];
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
                DTO.Category cat = new DTO.Category(id, txtName.Text);
                if (new CategoryDAO().UdateCategory(cat))
                {
                    txtName.Clear();
                    dgvCategory.DataSource = new DAO.CategoryDAO().GetAllCategories().Tables[0];
                    id = 0;
                    btnDelete.Enabled = false;
                }
                else
                {

                }
            }
        }

    }
}
