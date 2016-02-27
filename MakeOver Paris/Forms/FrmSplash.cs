using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MakeOver_Paris.Forms
{
    public partial class FrmSplash : Form
    {

        public FrmSplash()
        {
           
            InitializeComponent();
           
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            this.pnlSplashScreen.Left = (this.Width - this.pnlSplashScreen.Width) / 2 ;
            this.pnlSplashScreen.Top = (this.Height - this.pnlSplashScreen.Height) / 2 ;
            timer1.Enabled = true;
            //string printerName = "Posiflex PP6900 Partial Cut v3.01"; // Your Printer Name
            //System.Drawing.Printing.PrintDocument doctoprint = new System.Drawing.Printing.PrintDocument();
            //doctoprint.PrinterSettings.PrinterName = printerName;
            //int rawKind = 0;
            //for (int i = 0; i <= doctoprint.PrinterSettings.PaperSizes.Count - 1; i++)
            //{
            //    if (doctoprint.PrinterSettings.PaperSizes[i].PaperName == "3.14 x 6 in") // "LXP : Your Page Size"
            //    {
            //        rawKind = Convert.ToInt32(doctoprint.PrinterSettings.PaperSizes[i].GetType().GetField
            //         ("kind",
            //        System.Reflection.BindingFlags.Instance |
            //        System.Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes[i]));
            //        break;
            //    }
            //}

            //rpt_saleinvoice rpt = new rpt_saleinvoice();
            //rpt.Refresh();
            //rpt.SetParameterValue("p_invoiceid", 1);
            //rpt.SetParameterValue("p_received", 100.0);
            //rpt.PrintOptions.PaperSize = (CrystalDecisions.Shared.PaperSize)rawKind;
            //rpt.PrintToPrinter(1, false, 1, 1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Forms.FrmLogin frmLogin = new Forms.FrmLogin();
            frmLogin.Visible = true;
            this.Visible = false;
            timer1.Stop();
            
        }

    }
}
