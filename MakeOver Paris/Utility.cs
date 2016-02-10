using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeOver_Paris
{
    // TODO: TO CREATE FOR ALL THE UTILITY FUNCTION
    public static class Utility
    {

        // TODO: TO SET THE COLUMN HEADER TITLE OF THE DATA GRID VIEW
        public static void setGridHeaderText(String str, System.Windows.Forms.DataGridView grid)
        {
            String[] headers = str.Split('|');
            for(int i=0 ;i<headers.Length ; i++)
            {
                grid.Columns[i].HeaderText = headers[i];
            }
        }

        // TODO: TO SET THE COLUMN WIDTH SIZE OF THE DATA GRID VIEW
        public static void setGridHeaderWidth(String str, System.Windows.Forms.DataGridView grid)
        {
            String[] headers = str.Split('|');
            for (int i = 0; i < headers.Length; i++)
            {
                grid.Columns[i].Width = System.Convert.ToInt32(headers[i]);
            }
        }
    }
}
