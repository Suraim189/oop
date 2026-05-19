using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Attendance
{
    public partial class frmAttendanceMarking : Form
    {
        private readonly AttendanceService _svc = new AttendanceService();
        private readonly ClassSectionService _csSvc = new ClassSectionService();
        private DataTable _students;

        public frmAttendanceMarking()
        {
            InitializeComponent();
            Load += frmAttendanceMarking_Load;
            Theme.StyleDataGridView(dgvAttendance);
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvAttendance.Columns.Clear();
            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRoll", HeaderText = "Roll No", Width = 80, ReadOnly = true });
            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Student Name", Width = 200, ReadOnly = true });
            var colStatus = new DataGridViewComboBoxColumn { Name = "colStatus", HeaderText = "Status", Width = 150 };
            colStatus.Items.AddRange("Present", "Absent", "Late", "Leave"); colStatus.DefaultCellStyle.NullValue = "Present";
            dgvAttendance.Columns.Add(colStatus);
        }

        private void frmAttendanceMarking_Load(object sender, EventArgs e)
        {
            var classes = _csSvc.GetAll();
            cmbClassSection.DataSource = classes; cmbClassSection.DisplayMember = "DisplayName"; cmbClassSection.ValueMember = "ClassSectionId";
            dtpDate.Value = DateTime.Now;
        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            int classId = (int)cmbClassSection.SelectedValue;
            _students = _svc.GetStudentsForAttendance(classId, dtpDate.Value);
            dgvAttendance.Rows.Clear();
            foreach (DataRow r in _students.Rows)
                dgvAttendance.Rows.Add(r["RollNo"], r["StudentName"], "Present");
            UpdateSummary();
        }

        private void UpdateSummary()
        {
            int p = 0, a = 0, l = 0, le = 0;
            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                string s = row.Cells["colStatus"].Value?.ToString() ?? "Present";
                if (s == "Present") p++; else if (s == "Absent") a++; else if (s == "Late") l++; else le++;
            }
            lblSummary.Text = $"Present: {p} | Absent: {a} | Late: {l} | Leave: {le}";
        }

        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            int classId = (int)cmbClassSection.SelectedValue;
            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                int studentId = Convert.ToInt32(_students.Rows[row.Index]["StudentId"]);
                string status = row.Cells["colStatus"].Value?.ToString() ?? "Present";
                int statusCode = status == "Present" ? 1 : status == "Absent" ? 2 : status == "Late" ? 3 : 4;
                _svc.SaveAttendance(studentId, classId, dtpDate.Value, statusCode, 1);
            }
            MessageBox.Show("Attendance saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
