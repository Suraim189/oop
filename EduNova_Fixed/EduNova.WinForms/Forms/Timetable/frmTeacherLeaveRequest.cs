using System;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Timetable
{
    public partial class frmTeacherLeaveRequest : Form
    {
        private readonly TimetableService _svc = new TimetableService();
        private readonly TeacherService _teachSvc = new TeacherService();
        private DataTable _leaves;

        public frmTeacherLeaveRequest()
        {
            InitializeComponent();
            Load += frmTeacherLeaveRequest_Load;
            Theme.StyleDataGridView(dgvLeaveRequests);
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvLeaveRequests.Columns.Clear();
            dgvLeaveRequests.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTeacher", HeaderText = "Teacher", Width = 160 });
            dgvLeaveRequests.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDate", HeaderText = "Leave Date", Width = 120 });
            dgvLeaveRequests.Columns.Add(new DataGridViewTextBoxColumn { Name = "colReason", HeaderText = "Reason", Width = 200 });
            dgvLeaveRequests.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Status", Width = 100 });
        }

        private void frmTeacherLeaveRequest_Load(object sender, EventArgs e)
        {
            try
            {
                var teachers = _teachSvc.GetActive();
                cmbTeacher.DataSource = teachers; cmbTeacher.DisplayMember = "FullName"; cmbTeacher.ValueMember = "TeacherId";
                LoadLeaves();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void LoadLeaves()
        {
            try { _leaves = _svc.GetLeaveRequests(); dgvLeaveRequests.DataSource = _leaves; }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnSubmitLeave_Click(object sender, EventArgs e)
        {
            try { int teacherId = (int)cmbTeacher.SelectedValue; _svc.SubmitLeave(teacherId, dtpLeaveDate.Value, txtReason.Text.Trim()); MessageBox.Show("Leave submitted!"); LoadLeaves(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}
