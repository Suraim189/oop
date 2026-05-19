using System;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Dashboard
{
    public partial class DashboardPanel : Form
    {
        private readonly AdminService _adminService = new AdminService();
        private readonly TimetableService _ttService = new TimetableService();

        public DashboardPanel()
        {
            InitializeComponent();
            Load += DashboardPanel_Load;
            Theme.StyleDataGridView(dgvTodaySubstitutions);
            SetupSubstitutionsGrid();
        }

        private void SetupSubstitutionsGrid()
        {
            dgvTodaySubstitutions.Columns.Clear();
            dgvTodaySubstitutions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPeriod", HeaderText = "Period", Width = 120 });
            dgvTodaySubstitutions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClass", HeaderText = "Class", Width = 150 });
            dgvTodaySubstitutions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSubject", HeaderText = "Subject", Width = 150 });
            dgvTodaySubstitutions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colOriginal", HeaderText = "Original Teacher", Width = 150 });
            dgvTodaySubstitutions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSubstitute", HeaderText = "Substitute", Width = 150 });
            dgvTodaySubstitutions.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Status", Width = 100 });
        }

        private void DashboardPanel_Load(object sender, EventArgs e)
        {
            try
            {
                var dt = _adminService.GetDashboardCounts();
                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    lblTotalStudents.Text = row["TotalStudents"].ToString();
                    lblTotalTeachers.Text = row["TotalTeachers"].ToString();
                    lblAttendance.Text = row["TodayAttendancePercent"].ToString() + "%";
                    lblFeeDue.Text = row["FeeDueCount"].ToString();
                    lblSubstitutions.Text = row["TodaySubstitutions"].ToString();
                }

                var subDt = _ttService.GetTodaySubstitutions();
                dgvTodaySubstitutions.Rows.Clear();
                foreach (DataRow r in subDt.Rows)
                {
                    dgvTodaySubstitutions.Rows.Add(
                        r["PeriodTime"].ToString(),
                        r["ClassName"].ToString(),
                        r["SubjectName"].ToString(),
                        r["OriginalTeacherName"].ToString(),
                        r["SubstituteTeacherName"].ToString(),
                        r["Status"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
