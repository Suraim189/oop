using System;
using System.Drawing;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Common
{
    public partial class frmMain : Form
    {
        private Button _activeButton = null;
        private Form _currentForm = null;

        public frmMain()
        {
            InitializeComponent();
            Load += frmMain_Load;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UiEffects.StartClock(lblClock);
            timerClock.Start();
            lblLoggedUser.Text = AppState.CurrentUser?.DisplayName ?? "Admin";
            lblUserRole.Text = AppState.CurrentUser?.RoleName ?? "Administrator";
            lblWelcome.Text = "Welcome, " + (AppState.CurrentUser?.DisplayName ?? "Admin");
            SetActiveButton(btnDashboard);
            LoadModuleForm(new Dashboard.DashboardPanel());
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss  dddd, dd MMM yyyy");
        }

        private void SidebarButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;
            SetActiveButton(btn);
            string name = btn.Name;

            if (name == "btnNotifications")
            {
                pnlNotifSlide.Visible = !pnlNotifSlide.Visible;
                return;
            }
            pnlNotifSlide.Visible = false;

            Form formToLoad = null;
            string title = btn.Text;

            switch (name)
            {
                case "btnDashboard":     formToLoad = new Dashboard.DashboardPanel(); break;
                case "btnStudents":      formToLoad = new Students.frmStudents(); break;
                case "btnTeachers":      formToLoad = new Teachers.frmTeachers(); break;
                case "btnClasses":       formToLoad = new ClassesSections.frmClasses(); break;
                case "btnSubjects":      formToLoad = new SubjectsDomains.frmSubjects(); break;
                case "btnTimetable":     formToLoad = new Timetable.frmTimetableEditor(); break;
                case "btnAttendance":    formToLoad = new Attendance.frmAttendanceMarking(); break;
                case "btnExams":         formToLoad = new Exams.frmExams(); break;
                case "btnFees":          formToLoad = new Fees.frmFeePayment(); break;
                case "btnLibrary":       formToLoad = new Library.frmLibraryBooks(); break;
                case "btnReports":       formToLoad = new Reports.frmReports(); break;
                case "btnAdmin":         formToLoad = new AdminSecurity.frmUsers(); break;
            }

            lblModuleTitle.Text = title;
            if (formToLoad != null)
                LoadModuleForm(formToLoad);
        }

        private void LoadModuleForm(Form childForm)
        {
            if (_currentForm != null)
            {
                _currentForm.Close();
                _currentForm.Dispose();
            }
            _currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);
            childForm.Show();
        }

        private void SetActiveButton(Button activeBtn)
        {
            _activeButton = activeBtn;
            foreach (var b in _sidebarButtons)
            {
                if (b == activeBtn)
                {
                    b.BackColor = Theme.SidebarActive;
                    b.ForeColor = Theme.SidebarActTxt;
                    b.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                }
                else
                {
                    b.BackColor = Theme.BgSidebar;
                    b.ForeColor = Theme.TextSecondary;
                    b.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AppState.ClearUser();
                frmLogin login = new frmLogin();
                login.Show();
                Close();
            }
        }

        private void btnMarkAllRead_Click(object sender, EventArgs e)
        {
            var userId = AppState.CurrentUser?.UserId;
            if (!userId.HasValue)
            {
                MessageBox.Show("No user session found.", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                var svc = new NotificationService();
                int count = svc.MarkAllRead(userId);
                MessageBox.Show($"{count} notifications marked as read.", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
