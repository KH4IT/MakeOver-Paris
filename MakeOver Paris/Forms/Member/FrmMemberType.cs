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
    public partial class FrmMemberType : Form
    {
        private int id;
        public FrmMemberType()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.FrmMain frmMain = new Forms.FrmMain();
            frmMain.Show();
            this.Close();
        }

        private void FrmMemberType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBack_Click(sender, e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                if (txtTitle.Text == "")
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                }
                else
                {
                    DTO.MemberType memberType = new MemberType(txtTitle.Text);
                  
                    if (new MemberTypeDAO().AddMemberType(memberType))
                    {
                        txtTitle.Clear();
                        dgvMemberType.DataSource = new DAO.MemberTypeDAO().GetAllMemberTypes().Tables[0];
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
                DTO.MemberType memebrType = new DTO.MemberType(id, txtTitle.Text);
                if (new MemberTypeDAO().UdateMemberType(memebrType))
                {
                    txtTitle.Clear();
                    dgvMemberType.DataSource = new DAO.MemberTypeDAO().GetAllMemberTypes().Tables[0];
                    id = 0;
                    btnDelete.Visible = false;
                }
                else
                {
                    MessageBox.Show("ប្រតិបត្តិការណ៍បរាជ័យ!!!");
                }
            }
        }

        private void FrmMemberType_Load(object sender, EventArgs e)
        {
            txtTitle.Focus();
            DataSet dataSet = new MemberTypeDAO().GetAllMemberTypes();
            dgvMemberType.DataSource = dataSet.Tables[0];
            Utility.setGridHeaderText("ល.រ|ប្រភេទសមាជិក", dgvMemberType);
            Utility.setGridHeaderWidth("100", dgvMemberType);
        }

        private void dgvMemberType_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id = System.Convert.ToInt32(dgvMemberType.CurrentRow.Cells[0].Value);
                txtTitle.Text = dgvMemberType.CurrentRow.Cells[1].Value.ToString();
                btnDelete.Visible = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("តើអ្នកពិតជាចង់លុបទិន្នន័យនេះមែនទេ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new MemberTypeDAO().DeleteMemberType(id))
                {
                    txtTitle.Clear();
                    btnDelete.Visible = false;
                    dgvMemberType.DataSource = new DAO.MemberTypeDAO().GetAllMemberTypes().Tables[0];
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
