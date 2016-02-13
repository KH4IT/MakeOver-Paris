using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MakeOver_Paris.DAO;
using MakeOver_Paris.DTO;

namespace MakeOver_Paris.Forms.Setting
{
    public partial class FrmSetting : Form
    {

        int id;

        public FrmSetting()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Title can't be empty");
            Forms.FrmMain frmMain = new Forms.FrmMain();
            frmMain.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Title can't be empty");
            if (id == 0)
            {
                if (txtTitle.Text.Trim() == "")
                {
                    MessageBox.Show("Title can't be empty");
                }
                else if (txtValue.Text.Trim() == "")
                {
                    MessageBox.Show("Value can't be empty");
                }
                else
                {
                    DTO.Setting setting = new DTO.Setting();
                    setting.Title = txtTitle.Text.Trim();
                    setting.Value = txtValue.Text.Trim();
                    if (new DAO.SettingDao().addSetting(setting))
                    {
                        txtTitle.Clear();
                        txtValue.Clear();
                        dgvSetting.DataSource = new DAO.SettingDao().getAllSettingDS().Tables[0];
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
                DTO.Setting setting = new DTO.Setting();
                setting.Title = txtTitle.Text.Trim();
                setting.Value = txtValue.Text.Trim();
                if (new DAO.SettingDao().updateSetting(setting))
                {
                    txtTitle.Clear();
                    txtValue.Clear();
                    dgvSetting.DataSource = new DAO.SettingDao().getAllSettingDS().Tables[0];
                    id = 0;
                    btnDelete.Enabled = false;
                }
                else
                {

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Title can't be empty");

        }

        
    }
}
