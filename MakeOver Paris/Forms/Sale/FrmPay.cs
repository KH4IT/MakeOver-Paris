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
            txtRecieve.Focus();
        }

        private void txtRecieve_TextChanged(object sender, EventArgs e)
        {
            //Prevent String input
            txtChange.Text = "";
            if(txtRecieve.Text!="")
                txtChange.Text = (decimal.Parse(txtRecieve.Text.ToString()) - decimal.Parse(txtTotal.Text.ToString())).ToString();
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
                rpt_saleinvoice rpt = new rpt_saleinvoice();
                rpt.SetParameterValue("p_invoiceid", invoiceid);
                rpt.SetParameterValue("p_received", txtRecieve.Text);
                rpt.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)rawKind;
                rpt.Refresh();


                rpt.PrintToPrinter(1, false, 1, 1);
                this.Close();
            }
        }
    }
}
