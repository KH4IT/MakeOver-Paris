using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeOver_Paris.Forms.Product
{
    public partial class FrmProduct : Form
    {

        int id;

        public FrmProduct()
        {
            InitializeComponent();
            dgvProduct.DataSource = new DAO.ProductDAO().getAllProductDS().Tables[0];

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.FrmMain frmMain = new Forms.FrmMain();
            frmMain.Show();
            this.Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                if (    txtBarcode.Text.Trim() == ""    || txtProductCode.Text.Trim() == ""
                    ||  txtName.Text.Trim()  == ""     // || cboCategory.SelectedValue == ""
                    ||  txtQuantity.Text.Trim() == ""   
                    ||  txtPriceIn.Text.Trim() == ""    || txtPriceOut.Text.Trim() == ""
                    ||  txtReturnQuantity.Text.Trim() == ""
                )
                {
                    MessageBox.Show("All fields is reuqied and can't be empty!");
                }
                else
                {
                    DTO.Staff staff = new DTO.Staff();
                    staff.Staffid = 1;// Data.user.Staffid;
                    DTO.Category cate = new DTO.Category();
                    cate.Categoryid = 1;//(int)cboCategory.SelectedValue;
                    DTO.Product product = new DTO.Product(0, txtProductCode.Text.Trim(), txtBarcode.Text.Trim(), txtName.Text.Trim(), Decimal.Parse(txtQuantity.Text.Trim()), txtDescription.Text.Trim(),
                       Decimal.Parse(txtPriceIn.Text.Trim()), Decimal.Parse(txtPriceOut.Text.Trim()), Decimal.Parse(txtReturnQuantity.Text.Trim()), txtRemark.Text.Trim(), staff, staff, cate);
                    if (new DAO.ProductDAO().addProduct(product))
                    {
                        dgvProduct.DataSource = new DAO.ProductDAO().getAllProductDS().Tables[0];
                        id = 0;
                    }
                    else
                    {
                        MessageBox.Show("Transaction fail!!!");
                    }
                }
            }
            else
            {

                if (txtBarcode.Text.Trim() == "" || txtProductCode.Text.Trim() == ""
                   || txtName.Text.Trim() == ""     // || cboCategory.SelectedValue == ""
                   || txtQuantity.Text.Trim() == ""
                   || txtPriceIn.Text.Trim() == "" || txtPriceOut.Text.Trim() == ""
                   || txtReturnQuantity.Text.Trim() == ""
               )
                {
                    MessageBox.Show("All fields is reuqied and can't be empty!");
                }
                else
                {
                    DTO.Staff staff = new DTO.Staff();
                    staff.Staffid = 1;// Data.user.Staffid;
                    DTO.Category cate = new DTO.Category();
                    cate.Categoryid = 1;//(int)cboCategory.SelectedValue;
                    DTO.Product product = new DTO.Product(id, txtProductCode.Text.Trim(), txtBarcode.Text.Trim(), txtName.Text.Trim(), Decimal.Parse(txtQuantity.Text.Trim()), txtDescription.Text.Trim(),
                       Decimal.Parse(txtPriceIn.Text.Trim()), Decimal.Parse(txtPriceOut.Text.Trim()), Decimal.Parse(txtReturnQuantity.Text.Trim()), txtRemark.Text.Trim(), staff, staff, cate);
                    if (new DAO.ProductDAO().updateProduct(product))
                    {
                        txtProductCode.Clear();
                        txtBarcode.Clear();
                        txtName.Clear();
                        txtQuantity.Clear();
                        txtDescription.Clear();
                        txtPriceIn.Clear();
                        txtPriceOut.Clear();
                        txtReturnQuantity.Clear();
                        txtRemark.Clear();
                        dgvProduct.DataSource = new DAO.ProductDAO().getAllProductDS().Tables[0];
                        id = 0;
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Transaction fail!!!");
                    }
                }


                //if (txtTitle.Text.Trim() == "")
                //{
                //    MessageBox.Show("Title can't be empty");
                //}
                //else if (txtValue.Text.Trim() == "")
                //{
                //    MessageBox.Show("Value can't be empty");
                //}
                //else
                //{
                //    DTO.Setting setting = new DTO.Setting();
                //    setting.Title = txtTitle.Text.Trim();
                //    setting.Value = txtValue.Text.Trim();
                //    setting.Settingid = id;
                //    if (new DAO.SettingDao().updateSetting(setting))
                //    {
                //        txtTitle.Clear();
                //        txtValue.Clear();
                //        dgvSetting.DataSource = new DAO.SettingDao().getAllSettingDS().Tables[0];
                //        id = 0;
                //        btnDelete.Enabled = false;
                //    }
                //    else
                //    {
                //        MessageBox.Show("Transaction fail!!!");
                //    }
                //}
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            id = System.Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value);
            txtProductCode.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            txtBarcode.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            txtName.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            txtQuantity.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
            txtDescription.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
            txtPriceIn.Text = dgvProduct.CurrentRow.Cells[6].Value.ToString();
            txtPriceOut.Text = dgvProduct.CurrentRow.Cells[7].Value.ToString();
            txtReturnQuantity.Text = dgvProduct.CurrentRow.Cells[8].Value.ToString();
            txtRemark.Text = dgvProduct.CurrentRow.Cells[9].Value.ToString();

            //txtBarcode.Text = dgvProduct.CurrentRow.Cells[14].Value.ToString();;



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new DAO.ProductDAO().deleteProduct(id))
                {
                    txtProductCode.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
                    txtBarcode.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
                    txtName.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
                    txtQuantity.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
                    txtDescription.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
                    txtPriceIn.Text = dgvProduct.CurrentRow.Cells[6].Value.ToString();
                    txtPriceOut.Text = dgvProduct.CurrentRow.Cells[7].Value.ToString();
                    txtReturnQuantity.Text = dgvProduct.CurrentRow.Cells[8].Value.ToString();
                    txtRemark.Text = dgvProduct.CurrentRow.Cells[9].Value.ToString();
                    id = 0;
                    btnDelete.Enabled = false;
                    dgvProduct.DataSource = new DAO.ProductDAO().getAllProductDS().Tables[0];
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
            bs.DataSource = dgvProduct.DataSource;
            bs.Filter = "productname LIKE '%" + txtSearch.Text + "%' ";
            dgvProduct.DataSource = bs;
        }

        private void txtPriceIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        private void txtPriceOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyNumber(sender, e);
        }

      

    }
}
