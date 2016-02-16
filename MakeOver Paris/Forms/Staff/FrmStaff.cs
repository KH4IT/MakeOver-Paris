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

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Name cannot be empty");
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Password cannot be empty");
                }
                else if (txtCommission.Text == "")
                {
                    MessageBox.Show("Commision Rate cannot be empty");
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
                        MessageBox.Show("Transaction Failed");
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
                staff.Commisionrate = int.Parse(txtCommission.Text);
                if (new StaffDAO().UpdateStaff(staff))
                {
                    clearForm();
                    listStaff();
                    id = 0;
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Transaction Failed");
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
            btnDelete.Enabled = true;
            id = System.Convert.ToInt32(dgvStaff.CurrentRow.Cells[0].Value);
            txtName.Text = dgvStaff.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dgvStaff.CurrentRow.Cells[2].Value.ToString();
            txtType.Text = dgvStaff.CurrentRow.Cells[3].Value.ToString();
            txtCommission.Text = dgvStaff.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    MessageBox.Show("Transaction fail!!");
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

        private void txtCommission_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtCommission_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        

    }
}
