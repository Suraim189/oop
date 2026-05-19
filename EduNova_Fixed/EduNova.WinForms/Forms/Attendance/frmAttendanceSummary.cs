using System;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Attendance
{
    public partial class frmAttendanceSummary : Form
    {
        private readonly AttendanceService _svc = new AttendanceService();
        private readonly ClassSectionService _csSvc = new ClassSectionService();
        private DataTable _data;
        public frmAttendanceSummary() { InitializeComponent(); Load += frmAttendanceSummary_Load; Theme.StyleDataGridView(dgvMain); SetupGrid(); }
        private void SetupGrid()
        {
            dgvMain.Columns.Clear();
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Student Name", Width = 180, DataPropertyName = "StudentName" });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "Total Days", Width = 80, DataPropertyName = "TotalDays" });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPresent", HeaderText = "Present", Width = 80, DataPropertyName = "PresentCount" });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAbsent", HeaderText = "Absent", Width = 80, DataPropertyName = "AbsentCount" });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colLate", HeaderText = "Late", Width = 70, DataPropertyName = "LateCount" });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colLeave", HeaderText = "Leave", Width = 70, DataPropertyName = "LeaveCount" });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPct", HeaderText = "%", Width = 70, DataPropertyName = "AttendancePercentage" });
        }
        private void frmAttendanceSummary_Load(object sender, EventArgs e) { var cl = _csSvc.GetAll(); cmbClass.DataSource = cl; cmbClass.DisplayMember = "DisplayName"; cmbClass.ValueMember = "ClassSectionId"; dtpFrom.Value = DateTime.Now.AddMonths(-1); dtpTo.Value = DateTime.Now; }
        private void btnLoad_Click(object sender, EventArgs e) { try { _data = _svc.GetSummary((int)cmbClass.SelectedValue, dtpFrom.Value, dtpTo.Value); dgvMain.DataSource = _data; lblCount.Text = $"Total: {_data.Rows.Count}"; } catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); } }
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            CsvExporter.ExportDataTable(_data, "attendance-summary.csv");
        }

    }
}
