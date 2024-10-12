using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormReport : Form
    {
        public FormReport(ReportDocument report)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {

        }
    }
}
