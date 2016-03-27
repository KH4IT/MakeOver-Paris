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
    public partial class FrmPay : Form
    {
        public FrmPay()
        {
            InitializeComponent();
        }

        public int invoiceid = 0;

        private void FrmPay_Load(object sender, EventArgs e)
        {
            exchangerate = decimal.Parse(new DAO.SettingDao().getValue("ExchangeRate"));
            txtTotalRiel.Text = (decimal.Parse(txtTotal.Text) * exchangerate).ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string printerName = "Posiflex PP6900 Partial Cut v3.01"; // Your Printer Name


            System.Drawing.Printing.PrintDocument doctoprint = new System.Drawing.Printing.PrintDocument();
            doctoprint.PrinterSettings.PrinterName = printerName;
            int rawKind = 0;
            for (int i = 0; i <= doctoprint.PrinterSettings.PaperSizes.Count - 1; i++)
            {
                if (doctoprint.PrinterSettings.PaperSizes[i].PaperName == "3.14 x 6 in") // "LXP : Your Page Size"
                {
                    rawKind = Convert.ToInt32(doctoprint.PrinterSettings.PaperSizes[i].GetType().GetField
                     ("kind",
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes[i]));
                    break;
                }
                
            }

            if (txtRecieve.Text != "")
            {
                //MakeOver_Paris.rpt_saleinvoice rpt = new rpt_saleinvoice();
                MakeOver_Paris.rpt_test rpt = new rpt_test();
                rpt.Refresh();
                rpt.SetParameterValue("p_invoiceid", invoiceid);
                rpt.SetParameterValue("p_received", decimal.Parse(txtRecieve.Text));
                try
                {
                    rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5;
                    rpt.PrintToPrinter(1, false, 0, 0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                DTO.Transaction transaction = new DTO.Transaction();
                transaction.Incomeamount = decimal.Parse(txtTotal.Text);
                transaction.Createdby = UserSession.Session.Staff;
                transaction.Remark = "InvoiceID: " + invoiceid;
                new DAO.TransactionDAO().AddTransaction(transaction);
                this.Dispose();
            }
        }
        decimal exchangerate = 0;
        private void txtRecieve_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        private void txtRecieveRiel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.AllowOnlyDecimalNumber(sender, e);
        }

        private void txtRecieve_TextChanged(object sender, EventArgs e)
        {
            txtChange.Text = "";
            if (txtRecieve.Text != "" & txtRecieveRiel.Text != "")
            {
                decimal recievedRiel = decimal.Parse(txtRecieveRiel.Text);
                decimal recievedDollar = decimal.Parse(txtRecieve.Text);
                decimal recieved = recievedDollar + (recievedRiel / exchangerate);
                txtChange.Text = (recieved - decimal.Parse(txtTotal.Text.ToString())).ToString();
                txtChangeRiel.Text = (decimal.Parse(txtChange.Text) * exchangerate).ToString(); ;
            }
            else
            {
                txtRecieve.Text = "0";
            }
        }

        private void txtRecieveRiel_TextChanged(object sender, EventArgs e)
        {
            txtChange.Text = "";
            if (txtRecieve.Text != "" & txtRecieveRiel.Text != "")
            {
                decimal recievedRiel = decimal.Parse(txtRecieveRiel.Text);
                decimal recievedDollar = decimal.Parse(txtRecieve.Text);
                decimal recieved = recievedDollar + (recievedRiel / exchangerate);
                txtChange.Text = (recieved - decimal.Parse(txtTotal.Text.ToString())).ToString();
                txtChangeRiel.Text = (decimal.Parse(txtChange.Text) * exchangerate).ToString(); ;
            }
            else
            {
                txtRecieveRiel.Text = "0";
            }
        }

        private void FrmPay_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        
    }
}
