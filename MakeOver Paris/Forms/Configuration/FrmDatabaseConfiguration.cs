﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace MakeOver_Paris.Forms.Configuration
{
    public partial class FrmDatabaseConfiguration : Form
    {
        public FrmDatabaseConfiguration()
        {
            InitializeComponent();
        }

        private void FrmConfiguration_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cnn = DAO.DBUtility.getConnection();
                cnn.Open();
                FrmSplash frmSplash = new FrmSplash();
                frmSplash.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_configure_Click(object sender, EventArgs e)
        {
            string constr = "";
            constr = @"SERVER=" + txt_server.Text + ";DATABASE=" + cbo_database.Text + ";UID=" + txt_uid.Text + ";PWD=" + txt_pwd.Text + ";Allow User Variables=True";
            Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\MAKEOVER_PARIS", "ConStr", constr);
            try
            {
                MySqlConnection cnn = DAO.DBUtility.getConnection();
                cnn.Open();
                MessageBox.Show("CONNECTION SUCCESSFULLY!!!");
                //Application.Exit();
                //Application.Run(new Forms.FrmSplash());
                DAO.DBUtility.ConnectionString = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\MAKEOVER_PARIS", "ConStr", "").ToString();
                FrmSplash frmSplash = new FrmSplash();
                frmSplash.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CONNECTION FAILED!!!"+ ex.ToString());
            }
        }

        private void txt_test_connection_Click(object sender, EventArgs e)
        {
            string constr = "";
            if (cbo_database.Text == "")
            {
                MessageBox.Show("CONNECTION FAILED!!!");
                return;
            }
            constr = @"SERVER=" + txt_server.Text + ";DATABASE=" + cbo_database.Text + ";UID=" + txt_uid.Text + ";PWD=" + txt_pwd.Text + ";Allow User Variables=True";
            try
            {
                MySqlConnection cnn = new MySqlConnection(constr);
                cnn.Open();
                MessageBox.Show("CONNECTION SUCCESSFULLY!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("CONNECTION FAILED!!!");
            }
        }

        private void setComboDatabases()
        {
            try
            {
                string conStr = "SERVER=" + txt_server.Text + ";UID=" + txt_uid.Text + ";" + "PASSWORD=" + txt_pwd.Text + ";Allow User Variables=True";
                MySqlConnection connection = new MySqlConnection(conStr);
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SHOW DATABASES;";
                MySqlDataReader Reader;
                connection.Open();
                Reader = command.ExecuteReader();
                cbo_database.Items.Clear();
                while (Reader.Read())
                {
                    string row = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        row += Reader.GetValue(i).ToString();
                    cbo_database.Items.Add(row);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void txt_server_MouseLeave(object sender, EventArgs e)
        {
            setComboDatabases();
        }

        private void txt_uid_MouseLeave(object sender, EventArgs e)
        {
            setComboDatabases();
        }

        private void txt_pwd_MouseLeave(object sender, EventArgs e)
        {
            setComboDatabases();
        }

    }
}
