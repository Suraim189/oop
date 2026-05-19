using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Reports
{
    public partial class frmReports : Form
    {
        private readonly ReportService _svc = new ReportService();

        public frmReports()
        {
            InitializeComponent();
            Load += frmReports_Load;
            Theme.StyleDataGridView(dgvFeeDue); Theme.StyleDataGridView(dgvAttendanceRpt);
            Theme.StyleDataGridView(dgvExamResults); Theme.StyleDataGridView(dgvSubstitutions);
            SetupFeeDueGrid(); SetupAttendanceGrid(); SetupExamGrid(); SetupSubGrid();
        }

        private void SetupFeeDueGrid()
        {
            dgvFeeDue.Columns.Clear();
            dgvFeeDue.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStudent", HeaderText = "Student", Width = 150 });
            dgvFeeDue.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAdmNo", HeaderText = "Adm No", Width = 100 });
            dgvFeeDue.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClass", HeaderText = "Class", Width = 100 });
            dgvFeeDue.Columns.Add(new DataGridViewTextBoxColumn { Name = "colVouchers", HeaderText = "Vouchers Due", Width = 100 });
            dgvFeeDue.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotalDue", HeaderText = "Total Due", Width = 120 });
        }
        private void SetupAttendanceGrid()
        {
            dgvAttendanceRpt.Columns.Clear();
            dgvAttendanceRpt.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Student", Width = 180 });
            dgvAttendanceRpt.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPresent", HeaderText = "Present", Width = 80 });
            dgvAttendanceRpt.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAbsent", HeaderText = "Absent", Width = 80 });
            dgvAttendanceRpt.Columns.Add(new DataGridViewTextBoxColumn { Name = "colLate", HeaderText = "Late", Width = 70 });
            dgvAttendanceRpt.Columns.Add(new DataGridViewTextBoxColumn { Name = "colLeave", HeaderText = "Leave", Width = 70 });
            dgvAttendanceRpt.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPct", HeaderText = "%", Width = 70 });
        }
        private void SetupExamGrid()
        {
            dgvExamResults.Columns.Clear();
            dgvExamResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStudent", HeaderText = "Student", Width = 180 });
            dgvExamResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSubject", HeaderText = "Subject", Width = 150 });
            dgvExamResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "Total", Width = 80 });
            dgvExamResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "colObtained", HeaderText = "Obtained", Width = 80 });
            dgvExamResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGrade", HeaderText = "Grade", Width = 70 });
        }
        private void SetupSubGrid()
        {
            dgvSubstitutions.Columns.Clear();
            dgvSubstitutions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDate", HeaderText = "Date", Width = 100 });
            dgvSubstitutions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPeriod", HeaderText = "Period", Width = 100 });
            dgvSubstitutions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClass", HeaderText = "Class", Width = 120 });
            dgvSubstitutions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSubject", HeaderText = "Subject", Width = 120 });
            dgvSubstitutions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colOrigTeacher", HeaderText = "Original", Width = 140 });
            dgvSubstitutions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSubTeacher", HeaderText = "Substitute", Width = 140 });
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            try
            {
                var fd = _svc.GetFeeDueReport(null); dgvFeeDue.DataSource = fd;
                var at = _svc.GetAttendanceReport(1, DateTime.Now.AddMonths(-1), DateTime.Now); dgvAttendanceRpt.DataSource = at;
                var er = _svc.GetExamResultsReport(1, 1); dgvExamResults.DataSource = er;
                var sb = _svc.GetSubstitutionReport(DateTime.Now.AddMonths(-1), DateTime.Now); dgvSubstitutions.DataSource = sb;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}
