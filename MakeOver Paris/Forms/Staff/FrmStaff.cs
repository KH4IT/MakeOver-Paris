using MakeOver_Paris.DAO;
using MakeOver_Paris.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeOver_Paris.Forms.Staff
{
    public partial class FrmStaff : Form
    {
        int id;
        public FrmStaff()
        {
            InitializeComponent();
            txtType.SelectedIndex = 0;

            listStaff();
          
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
                if (txtName.Text == "")
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                }
                else if (txtCommission.Text == "")
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                }
                else
                {
                    DTO.Staff staff = new DTO.Staff();
                    staff.Staffname = txtName.Text;
                    staff.Staffpassword = txtPassword.Text;
                    staff.Stafftype = txtType.Text;
                    staff.Commisionrate = System.Convert.ToDecimal(txtCommission.Text);
                    staff.Lastlogin = System.DateTime.Today;
                    if (new StaffDAO().AddStaff(staff))
                    {
                        clearForm();
                        listStaff();
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
                staff.Staffid = id;
                staff.Staffname = txtName.Text;
                staff.Staffpassword = txtPassword.Text;
                staff.Stafftype = txtType.Text;
                staff.Commisionrate = System.Convert.ToDecimal(txtCommission.Text);
                if (new StaffDAO().UpdateStaff(staff))
                {
                    clearForm();
                    listStaff();
                    id = 0;
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("ប្រតិបត្តិការណ៍បរាជ័យ!!!");
                }
            }
        }

        private void clearForm()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtCommission.Clear();
        }

        private void listStaff()
        {
            DataSet dataSet = new StaffDAO().GetAllStaffs();
            dgvStaff.DataSource = dataSet.Tables[0];
            Utility.setGridHeaderText("ល.រ|ឈ្មោះ|លេខសម្ងាត់|ប្រភេទ|ថ្ងៃចូល|អត្រាចំណាញ", dgvStaff);
            if (dgvStaff.Rows.Count > 0)
            {
                dgvStaff.Columns["staffpassword"].Visible = false;
            }
        }

        private void dgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnDelete.Enabled = true;
                id = System.Convert.ToInt32(dgvStaff.CurrentRow.Cells[0].Value);
                txtName.Text = dgvStaff.CurrentRow.Cells[1].Value.ToString();
                txtPassword.Text = dgvStaff.CurrentRow.Cells[2].Value.ToString();
                txtType.Text = dgvStaff.CurrentRow.Cells[3].Value.ToString();
                txtCommission.Text = dgvStaff.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("តើអ្នកពិតជាចង់លុបទិន្នន័យនេះមែនទេ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new StaffDAO().DeleteStaff(id))
                {
                    clearForm();
                    btnDelete.Enabled = false;
                    listStaff();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvStaff.DataSource;
            bs.Filter = "staffname LIKE '%" + txtSearch.Text + "%'";
            dgvStaff.DataSource = bs;
        }

        private void txtCommission_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        private void FrmStaff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBack_Click(sender, e);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void FrmStaff_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        

    }
}
