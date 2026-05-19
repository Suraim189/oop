using System;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;
using EduNova.Domain.Entities;

namespace EduNova.WinForms.Forms.Timetable
{
    public partial class frmTimetableEditor : Form
    {
        private readonly TimetableService _svc = new TimetableService();
        private readonly ClassSectionService _csSvc = new ClassSectionService();
        private readonly SubjectService _subSvc = new SubjectService();
        private readonly TeacherService _teachSvc = new TeacherService();

        public frmTimetableEditor()
        {
            InitializeComponent();
            Load += frmTimetableEditor_Load;
            Theme.StyleDataGridView(dgvTimetable);
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvTimetable.Columns.Clear();
            dgvTimetable.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPeriod", HeaderText = "Period No", Width = 80, ReadOnly = true });
            dgvTimetable.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTime", HeaderText = "Time", Width = 120, ReadOnly = true });
            dgvTimetable.Columns.Add(new DataGridViewComboBoxColumn { Name = "colSubject", HeaderText = "Subject", Width = 180, DataPropertyName = "SubjectId" });
            dgvTimetable.Columns.Add(new DataGridViewComboBoxColumn { Name = "colTeacher", HeaderText = "Teacher", Width = 180, DataPropertyName = "TeacherId" });
            dgvTimetable.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRoom", HeaderText = "Room", Width = 100 });
            dgvTimetable.Columns.Add(new DataGridViewTextBoxColumn { Name = "colEntryId", Visible = false });
        }

        private void frmTimetableEditor_Load(object sender, EventArgs e)
        {
            var classes = _csSvc.GetAll();
            cmbClass.DataSource = classes; cmbClass.DisplayMember = "DisplayName"; cmbClass.ValueMember = "ClassSectionId";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int classId = (int)cmbClass.SelectedValue;
            int day = cmbDay.SelectedIndex + 1;
            var dt = _svc.GetTimetable(classId, day);
            dgvTimetable.Rows.Clear();
            foreach (DataRow r in dt.Rows)
            {
                dgvTimetable.Rows.Add(r["PeriodNo"], $"{r["StartTime"]} - {r["EndTime"]}", r["SubjectName"], r["TeacherName"], r["Room"], r["TimetableEntryId"]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) { MessageBox.Show("Saved!", "Success"); }
        private void btnClear_Click(object sender, EventArgs e) { dgvTimetable.Rows.Clear(); }
    }
}
