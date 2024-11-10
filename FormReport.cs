using System;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormReport : Form
    {
        private int _idHoaDon = -1;
        public FormReport()
        {
            InitializeComponent();
        }

        public FormReport(int idHoaDon) : this()
        {
            _idHoaDon = idHoaDon;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            report.SetDataSource(_idHoaDon < 0 ? DBConnection.Instance.SelectDB("vChiTietHoaDon") : DBConnection.Instance.SelectDB("vChiTietHoaDon", $"iMaHoaDon={_idHoaDon}"));
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
            cboMaMang.LoadDataSource("tblMang", "sTenMang", "sTenMang");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            report.SetDataSource(DBConnection.Instance.SelectDB("vChiTietHoaDon", $"iMaHoaDon={_idHoaDon} AND sTenMang='{cboMaMang.SelectedValue}'"));
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

        private void btnInAll_Click(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            report.SetDataSource(DBConnection.Instance.SelectDB("vChiTietHoaDon", $"iMaHoaDon={_idHoaDon}"));
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
