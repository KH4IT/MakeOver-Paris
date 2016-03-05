using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeOver_Paris.Forms.History
{
    public partial class FrmInvoiceView : Form
    {
        public int id;

        public FrmInvoiceView()
        {
            InitializeComponent();
        }

        private void FrmInvoiceView_Load(object sender, EventArgs e)
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


            //MakeOver_Paris.rpt_saleinvoice rpt = new rpt_saleinvoice();
            Forms.History.rpt_invoice rpt = new Forms.History.rpt_invoice();
            rpt.Refresh();
            rpt.SetParameterValue("p_invoiceid", id);
            //rpt.SetParameterValue("p_received", decimal.Parse("100"));

            //rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5;
            //rpt.PrintToPrinter(1, false, 0, 0);
            //DTO.Transaction transaction = new DTO.Transaction();
            //transaction.Incomeamount = decimal.Parse(txtTotal.Text);
            //transaction.Createdby = UserSession.Session.Staff;
            //transaction.Remark = "InvoiceID: " + invoiceid;
            //new DAO.TransactionDAO().AddTransaction(transaction);
            //this.Close();
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
