using System;
using System.Windows.Forms;

namespace MakeOver_Paris.Forms.Member
{
    public partial class FrmAddMember : Form
    {
        public FrmAddMember()
        {
            InitializeComponent();
        }
        private void btnMemberList_Click(object sender, EventArgs e)
        {
            FrmMembers frmMembers = new FrmMembers();
            frmMembers.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAO.MemberDAO memberDAO = new DAO.MemberDAO();
            DTO.Member member = new DTO.Member();
            member.MemberCode = txtCode.Text;
            member.Membername = txtName.Text;
            member.Phonenumber = txtPhoneNumber.Text;
            member.Discountrate = System.Convert.ToDecimal(txtDiscountRate.Text);
            DTO.Staff staff = new DTO.Staff();
            staff.Staffid = 1;
            member.Createdby = staff;

            if (memberDAO.addMember(member))
            {
                //MessageBox.Show("YOU HAVE BEEN INSERTED SUCCESSFULLY!!!");
                lblMessage.Text = "YOU HAVE BEEN INSERTED SUCCESSFULLY!!!";
                lblMessage.Show();
            }
            else
            {
                //MessageBox.Show("YOU HAVE SOME ERRORS WHEN INSERT THE MEMBER!!!");
                lblMessage.Text = "YOU HAVE SOME ERRORS WHEN INSERT THE MEMBER!!!";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Show();

            }
        }

  
    }
}
