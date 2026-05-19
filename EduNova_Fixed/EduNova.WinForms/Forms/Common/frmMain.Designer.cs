namespace EduNova.WinForms.Forms.Common
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppSub;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnClasses;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnExams;
        private System.Windows.Forms.Button btnFees;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel pnlSidebarBottom;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblModuleTitle;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlNotifSlide;
        private System.Windows.Forms.DataGridView dgvNotifications;
        private System.Windows.Forms.Button btnMarkAllRead;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Button[] _sidebarButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Button CreateSidebarButton(string name, string text, int y)
        {
            var btn = new System.Windows.Forms.Button();
            btn.Location = new System.Drawing.Point(0, y);
            btn.Size = new System.Drawing.Size(220, 48);
            btn.Name = name;
            btn.Text = text;
            btn.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            btn.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#0A1510");
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            return btn;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAppSub = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.pnlSidebarBottom = new System.Windows.Forms.Panel();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblModuleTitle = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlNotifSlide = new System.Windows.Forms.Panel();
            this.dgvNotifications = new System.Windows.Forms.DataGridView();
            this.btnMarkAllRead = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);

            // Sidebar buttons
            this.btnDashboard  = CreateSidebarButton("btnDashboard",  "\u229E Dashboard",       86);
            this.btnStudents   = CreateSidebarButton("btnStudents",   "\uD83D\uDC64 Students",      134);
            this.btnTeachers   = CreateSidebarButton("btnTeachers",   "\uD83D\uDC68\u200D\uD83C\uDFEB Teachers",    182);
            this.btnClasses    = CreateSidebarButton("btnClasses",    "\uD83C\uDFEB Classes",       230);
            this.btnSubjects   = CreateSidebarButton("btnSubjects",   "\uD83D\uDCDA Subjects",      278);
            this.btnTimetable  = CreateSidebarButton("btnTimetable",  "\uD83D\uDCC5 Timetable",      326);
            this.btnAttendance = CreateSidebarButton("btnAttendance", "\u2705 Attendance",     374);
            this.btnExams      = CreateSidebarButton("btnExams",      "\uD83D\uDCDD Exams",         422);
            this.btnFees       = CreateSidebarButton("btnFees",       "\uD83D\uDCB0 Fees",          470);
            this.btnLibrary    = CreateSidebarButton("btnLibrary",    "\uD83D\uDCD6 Library",       518);
            this.btnNotifications = CreateSidebarButton("btnNotifications", "\uD83D\uDD14 Notifications", 566);
            this.btnReports    = CreateSidebarButton("btnReports",    "\uD83D\uDCCA Reports",       614);
            this.btnAdmin      = CreateSidebarButton("btnAdmin",      "\u2699 Admin",            662);

            this._sidebarButtons = new System.Windows.Forms.Button[] {
                this.btnDashboard, this.btnStudents, this.btnTeachers, this.btnClasses,
                this.btnSubjects, this.btnTimetable, this.btnAttendance, this.btnExams,
                this.btnFees, this.btnLibrary, this.btnNotifications, this.btnReports, this.btnAdmin
            };

            foreach (var b in this._sidebarButtons)
            {
                b.Click += new System.EventHandler(this.SidebarButton_Click);
            }

            this.SuspendLayout();

            // pnlSidebar
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 220;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.BackColor = System.Drawing.ColorTranslator.FromHtml("#0A1510");
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Controls.Add(this.pnlDivider);
            foreach (var b in this._sidebarButtons)
                this.pnlSidebar.Controls.Add(b);
            this.pnlSidebar.Controls.Add(this.pnlSidebarBottom);

            // pnlLogo
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Size = new System.Drawing.Size(220, 80);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.BackColor = System.Drawing.ColorTranslator.FromHtml("#0A1510");
            this.pnlLogo.Controls.Add(this.lblAppName);
            this.pnlLogo.Controls.Add(this.lblAppSub);

            // lblAppName
            this.lblAppName.Location = new System.Drawing.Point(16, 16);
            this.lblAppName.Size = new System.Drawing.Size(188, 32);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Text = "EduNova";
            this.lblAppName.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 18f, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;

            // lblAppSub
            this.lblAppSub.Location = new System.Drawing.Point(16, 50);
            this.lblAppSub.Size = new System.Drawing.Size(188, 20);
            this.lblAppSub.Name = "lblAppSub";
            this.lblAppSub.Text = "School Management";
            this.lblAppSub.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 8f, System.Drawing.FontStyle.Regular);
            this.lblAppSub.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblAppSub.BackColor = System.Drawing.Color.Transparent;

            // pnlDivider
            this.pnlDivider.Location = new System.Drawing.Point(16, 80);
            this.pnlDivider.Size = new System.Drawing.Size(188, 1);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.BackColor = System.Drawing.ColorTranslator.FromHtml("#2A4030");

            // pnlSidebarBottom
            this.pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarBottom.Height = 80;
            this.pnlSidebarBottom.Name = "pnlSidebarBottom";
            this.pnlSidebarBottom.BackColor = System.Drawing.ColorTranslator.FromHtml("#0A1510");
            this.pnlSidebarBottom.Controls.Add(this.lblLoggedUser);
            this.pnlSidebarBottom.Controls.Add(this.lblUserRole);
            this.pnlSidebarBottom.Controls.Add(this.btnLogout);

            // lblLoggedUser
            this.lblLoggedUser.Location = new System.Drawing.Point(12, 8);
            this.lblLoggedUser.Size = new System.Drawing.Size(196, 20);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Text = "Admin";
            this.lblLoggedUser.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9f, System.Drawing.FontStyle.Bold);
            this.lblLoggedUser.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblLoggedUser.BackColor = System.Drawing.Color.Transparent;

            // lblUserRole
            this.lblUserRole.Location = new System.Drawing.Point(12, 28);
            this.lblUserRole.Size = new System.Drawing.Size(196, 16);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Text = "Administrator";
            this.lblUserRole.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 8f, System.Drawing.FontStyle.Regular);
            this.lblUserRole.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblUserRole.BackColor = System.Drawing.Color.Transparent;

            // btnLogout
            this.btnLogout.Location = new System.Drawing.Point(12, 48);
            this.btnLogout.Size = new System.Drawing.Size(196, 28);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Text = "Logout";
            this.btnLogout.BackColor = System.Drawing.ColorTranslator.FromHtml("#7B2D2D");
            this.btnLogout.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFB3B3");
            this.btnLogout.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 8.5f, System.Drawing.FontStyle.Bold);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // pnlTopBar
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Height = 55;
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.pnlTopBar.Controls.Add(this.lblModuleTitle);
            this.pnlTopBar.Controls.Add(this.lblWelcome);
            this.pnlTopBar.Controls.Add(this.lblClock);

            // lblModuleTitle
            this.lblModuleTitle.Location = new System.Drawing.Point(16, 14);
            this.lblModuleTitle.Size = new System.Drawing.Size(350, 28);
            this.lblModuleTitle.Name = "lblModuleTitle";
            this.lblModuleTitle.Text = "Dashboard";
            this.lblModuleTitle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 16f, System.Drawing.FontStyle.Bold);
            this.lblModuleTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblModuleTitle.BackColor = System.Drawing.Color.Transparent;

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(700, 8);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Text = "Welcome, Admin";
            this.lblWelcome.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9f, System.Drawing.FontStyle.Regular);
            this.lblWelcome.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;

            // lblClock
            this.lblClock.AutoSize = true;
            this.lblClock.Location = new System.Drawing.Point(700, 28);
            this.lblClock.Name = "lblClock";
            this.lblClock.Text = "";
            this.lblClock.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10f, System.Drawing.FontStyle.Regular);
            this.lblClock.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.lblClock.BackColor = System.Drawing.Color.Transparent;

            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");

            // pnlNotifSlide
            this.pnlNotifSlide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNotifSlide.Width = 300;
            this.pnlNotifSlide.Visible = false;
            this.pnlNotifSlide.Name = "pnlNotifSlide";
            this.pnlNotifSlide.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.pnlNotifSlide.Controls.Add(this.dgvNotifications);
            this.pnlNotifSlide.Controls.Add(this.btnMarkAllRead);

            // dgvNotifications
            this.dgvNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvNotifications.Height = 400;
            this.dgvNotifications.Name = "dgvNotifications";
            this.dgvNotifications.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.dgvNotifications.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030");
            this.dgvNotifications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotifications.ReadOnly = true;
            this.dgvNotifications.RowHeadersVisible = false;
            this.dgvNotifications.AllowUserToAddRows = false;

            // btnMarkAllRead
            this.btnMarkAllRead.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMarkAllRead.Height = 36;
            this.btnMarkAllRead.Name = "btnMarkAllRead";
            this.btnMarkAllRead.Text = "Mark All Read";
            this.btnMarkAllRead.Click += new System.EventHandler(this.btnMarkAllRead_Click);

            // timerClock
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);

            // frmMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Name = "frmMain";
            this.Text = "EduNova - School Management System";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlNotifSlide);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);

            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlSidebarBottom.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlNotifSlide.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
