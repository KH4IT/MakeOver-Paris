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

            DataSet dataSet = new StaffDAO().GetAllStaffs();
            dgvStaff.DataSource = dataSet.Tables[0];
            Utility.setGridHeaderText("ល.រ|ឈ្មោះ|លេខសម្ងាត់|ប្រភេទ|ថ្ងៃចូល|អត្រាចំណាញ", dgvStaff);
           // Utility.setGridHeaderWidth("100|100|100|100|100", dgvStaff);
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

        private void FrmStaff_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new StaffDAO().GetAllStaffs();
            dgvStaff.DataSource = dataSet.Tables[0];
          //  Utility.setGridHeaderText("ល.រ|ឈ្មោះ|លេខសម្ងាត់|ប្រភេទ|ថ្ងៃចូល|អត្រាចំណាញ", dgvStaff);
          //  Utility.setGridHeaderWidth("100|100|100|100|100|100", dgvStaff);

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
                    staff.Commisionrate = Decimal.Parse(txtCommission.Text);
                    staff.Lastlogin = System.DateTime.Today;
                    if (new StaffDAO().AddStaff(staff))
                    {
                        clearForm();
                        dgvStaff.DataSource = new StaffDAO().GetAllStaffs();
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
                staff.Staffname = txtName.Text;
                staff.Staffpassword = txtPassword.Text;
                staff.Stafftype = txtType.Text;
                staff.Commisionrate = Decimal.Parse(txtCommission.Text);
                if (new StaffDAO().UpdateStaff(staff))
                {
                    clearForm();
                    dgvStaff.DataSource = new StaffDAO().GetAllStaffs();
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

    }
}
