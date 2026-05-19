namespace EduNova.WinForms.Forms.Dashboard
{
    partial class DashboardPanel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label lblTotalStudentsTitle;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblTotalTeachers;
        private System.Windows.Forms.Label lblTotalTeachersTitle;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblAttendance;
        private System.Windows.Forms.Label lblAttendanceTitle;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblFeeDue;
        private System.Windows.Forms.Label lblFeeDueTitle;
        private System.Windows.Forms.Label lblSubstitutions;
        private System.Windows.Forms.Label lblSubstitutionsTitle;
        private System.Windows.Forms.DataGridView dgvTodaySubstitutions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Panel CreateStatCard(string name, int x, out System.Windows.Forms.Label lblVal, out System.Windows.Forms.Label lblTitle)
        {
            var pnl = new System.Windows.Forms.Panel();
            pnl.Location = new System.Drawing.Point(x, 10);
            pnl.Size = new System.Drawing.Size(210, 90);
            pnl.Name = name;
            pnl.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A2E20");
            pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            lblVal = new System.Windows.Forms.Label();
            lblVal.Location = new System.Drawing.Point(12, 12);
            lblVal.Size = new System.Drawing.Size(186, 36);
            lblVal.Name = name + "Val";
            lblVal.Text = "0";
            lblVal.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 20f, System.Drawing.FontStyle.Bold);
            lblVal.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            lblVal.BackColor = System.Drawing.Color.Transparent;
            pnl.Controls.Add(lblVal);

            lblTitle = new System.Windows.Forms.Label();
            lblTitle.Location = new System.Drawing.Point(12, 52);
            lblTitle.Size = new System.Drawing.Size(186, 24);
            lblTitle.Name = name + "Title";
            lblTitle.Text = name;
            lblTitle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9f, System.Drawing.FontStyle.Regular);
            lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            pnl.Controls.Add(lblTitle);

            return pnl;
        }

        private void InitializeComponent()
        {
            this.pnlStats = new System.Windows.Forms.Panel();
            this.dgvTodaySubstitutions = new System.Windows.Forms.DataGridView();
            this.pnlCard1 = CreateStatCard("pnlCard1", 12, out this.lblTotalStudents, out this.lblTotalStudentsTitle);
            this.pnlCard2 = CreateStatCard("pnlCard2", 242, out this.lblTotalTeachers, out this.lblTotalTeachersTitle);
            this.pnlCard3 = CreateStatCard("pnlCard3", 472, out this.lblAttendance, out this.lblAttendanceTitle);
            this.pnlCard4 = CreateStatCard("pnlCard4", 702, out this.lblFeeDue, out this.lblFeeDueTitle);
            this.pnlCard5 = CreateStatCard("pnlCard5", 932, out this.lblSubstitutions, out this.lblSubstitutionsTitle);

            this.SuspendLayout();

            // pnlStats
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Height = 120;
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.pnlStats.Controls.Add(this.pnlCard1);
            this.pnlStats.Controls.Add(this.pnlCard2);
            this.pnlStats.Controls.Add(this.pnlCard3);
            this.pnlStats.Controls.Add(this.pnlCard4);
            this.pnlStats.Controls.Add(this.pnlCard5);

            // lblTotalStudentsTitle
            this.lblTotalStudentsTitle.Text = "Total Students";
            this.lblTotalTeachersTitle.Text = "Total Teachers";
            this.lblAttendanceTitle.Text = "Today Attendance %";
            this.lblFeeDueTitle.Text = "Fee Due Count";
            this.lblSubstitutionsTitle.Text = "Substitutions";

            // dgvTodaySubstitutions
            this.dgvTodaySubstitutions.Location = new System.Drawing.Point(12, 140);
            this.dgvTodaySubstitutions.Size = new System.Drawing.Size(1130, 380);
            this.dgvTodaySubstitutions.Name = "dgvTodaySubstitutions";
            this.dgvTodaySubstitutions.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvTodaySubstitutions.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030");
            this.dgvTodaySubstitutions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTodaySubstitutions.AutoGenerateColumns = false;
            this.dgvTodaySubstitutions.ReadOnly = true;
            this.dgvTodaySubstitutions.RowHeadersVisible = false;
            this.dgvTodaySubstitutions.AllowUserToAddRows = false;
            this.dgvTodaySubstitutions.EnableHeadersVisualStyles = false;
            this.dgvTodaySubstitutions.ColumnHeadersHeight = 38;
            this.dgvTodaySubstitutions.RowTemplate.Height = 34;

            // DashboardPanel
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(980, 600);
            this.Name = "DashboardPanel";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.dgvTodaySubstitutions);

            this.pnlStats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlCard5;
    }
}
