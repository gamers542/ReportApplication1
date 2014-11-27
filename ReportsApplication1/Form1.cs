/*Michael Cumberbatch
 *Form1.cs
 *November 26,2014
 *This program shows a sample report.  Thee report skips a line between values.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ReportsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GamesPlayedDataSet.AllGames' table. You can move, or remove it, as needed.
            this.AllGamesTableAdapter.Fill(this.GamesPlayedDataSet.AllGames);
            this.reportViewer1.LocalReport.ReportPath = "c:\\users\\michael\\documents\\visual studio 2012\\Projects\\ReportsApplication1\\ReportsApplication1\\Report1.rdlc";
            foreach (DataTable dt in GamesPlayedDataSet.Tables)
            {
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsGP", dt));
            }
            this.reportViewer1.RefreshReport();
        }
    }
}