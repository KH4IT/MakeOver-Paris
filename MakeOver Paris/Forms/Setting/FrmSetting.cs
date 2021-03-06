﻿using System;
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
            dgvSetting.DataSource = new DAO.SettingDao().getAllSettingDS().Tables[0];
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
                if (txtTitle.Text.Trim() == "")
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                }
                else if (txtValue.Text.Trim() == "")
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
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
                        MessageBox.Show("ប្រតិបត្តិការណ៍បរាជ័យ!!!");
                    }
                }
            }
            else
            {
                if (txtTitle.Text.Trim() == "")
                {
                    MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                }
                    else if (txtValue.Text.Trim() == "")
                    {
                        MessageBox.Show("សូមបំពេញពត៏មានឲ្យបានត្រឹមត្រូវ!!!");
                    }
                    else
                    {
                        DTO.Setting setting = new DTO.Setting();
                        setting.Title = txtTitle.Text.Trim();
                        setting.Value = txtValue.Text.Trim();
                        setting.Settingid = id;
                        if (new DAO.SettingDao().updateSetting(setting))
                        {
                            txtTitle.Clear();
                            txtValue.Clear();
                            dgvSetting.DataSource = new DAO.SettingDao().getAllSettingDS().Tables[0];
                            id = 0;
                            btnDelete.Visible = false;
                            txtTitle.ReadOnly = false;
                        }
                        else
                        {
                            MessageBox.Show("ប្រតិបត្តិការណ៍បរាជ័យ!!!");
                        }
                    }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("តើអ្នកពិតជាចង់លុបទិន្នន័យនេះមែនទេ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new SettingDao().deleteSetting(id))
                {
                    txtTitle.Clear();
                    txtValue.Clear();
                    dgvSetting.DataSource = new DAO.SettingDao().getAllSettingDS().Tables[0];
                    id = 0;
                    btnDelete.Visible = false;
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

        private void dgvSetting_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = System.Convert.ToInt32(dgvSetting.CurrentRow.Cells[0].Value);
                txtTitle.Text = dgvSetting.CurrentRow.Cells[1].Value.ToString();
                txtValue.Text = dgvSetting.CurrentRow.Cells[2].Value.ToString();
                btnDelete.Visible = true;
                txtTitle.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void FrmSetting_Load(object sender, EventArgs e)
        {
            txtTitle.Focus();
            Utility.setGridHeaderText("ល.រ|ឈ្មោះ|តម្លៃ",dgvSetting);
            Utility.setGridHeaderWidth("80",dgvSetting);
        }

        private void FrmSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBack_Click(sender, e);
            }
        }

        
    }
}
