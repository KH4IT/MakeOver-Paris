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
    public partial class FrmUpdateMember : Form
    {
        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            FrmAddMember frmAddMember = new FrmAddMember();
            frmAddMember.Show();
            this.Close();
        }

        private void btnMemberList_Click(object sender, EventArgs e)
        {
            FrmMembers frmMembers = new FrmMembers();
            frmMembers.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAO.MemberDAO memberDAO = new DAO.MemberDAO();
            DTO.Member member = new DTO.Member();
            member.Memberid = System.Convert.ToInt32(txtID.Text);
            member.MemberCode = txtCode.Text;
            member.Membername = txtName.Text;
            member.Phonenumber = txtPhoneNumber.Text;
            member.Discountrate = System.Convert.ToDecimal(txtDiscountRate.Text);
            DTO.Staff staff = new DTO.Staff();
            staff.Staffid = 1;
            member.Updatedby = staff;

            if (memberDAO.updateMemeber(member))
            {
                lblMessage.Text = "YOU HAVE BEEN UPDATED SUCCESSFULLY!!!";
                lblMessage.Show();
            }
            else
            {
                lblMessage.Text = "YOU HAVE SOME ERRORS WHEN UPDATED THE MEMBER!!!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Show();

            }
        }

    }
}
