using MakeOver_Paris.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeOver_Paris.Forms.Sale
{
    public partial class FrmCheckProductNew : Form
    {
        public FrmCheckProductNew()
        {
            InitializeComponent();
        }

        private void FrmCheckProductNew_Load(object sender, EventArgs e)
        {
            string select = @"SET @sql = NULL;
                            SELECT
                              GROUP_CONCAT(DISTINCT
                                CONCAT(
                                  'GROUP_CONCAT((CASE Storeid when ',
                                  Storeid,
                                  ' then quantity else NULL END)) AS ',
                                  Storename
                                )
                              ) INTO @sql
                            FROM ProductInStock;


                            SET @sql = CONCAT('SELECT Productid, ProductName, ', @sql, ' 
                                              FROM ProductInStock 
                                              GROUP BY ProductId, ProductName');

                            PREPARE stmt FROM @sql;
                            EXECUTE stmt;
                            DEALLOCATE PREPARE stmt;";
            MySql.Data.MySqlClient.MySqlConnection cnn = DBUtility.getConnection();
            MySql.Data.MySqlClient.MySqlDataAdapter dataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(select, cnn); //c.con is the connection string

            MySql.Data.MySqlClient.MySqlCommandBuilder commandBuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0]; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
