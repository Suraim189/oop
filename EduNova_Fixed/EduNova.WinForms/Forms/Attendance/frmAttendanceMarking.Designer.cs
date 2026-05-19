namespace EduNova.WinForms.Forms.Attendance
{
    partial class frmAttendanceMarking
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbClassSection;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnLoadStudents;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnSaveAttendance;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Panel pnlTop;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // btnLoadStudents
            this.btnLoadStudents = new System.Windows.Forms.Button();
            this.btnLoadStudents.Location = new System.Drawing.Point(460, 14);
            this.btnLoadStudents.Size = new System.Drawing.Size(130, 34);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.Text = "Load Students";
            this.btnLoadStudents.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnLoadStudents.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnLoadStudents.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnLoadStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadStudents.FlatAppearance.BorderSize = 0;
            this.btnLoadStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadStudents.Click += new System.EventHandler(this.btnLoadStudents_Click);
            // cmbClassSection
            this.cmbClassSection = new System.Windows.Forms.ComboBox();
            this.cmbClassSection.Location = new System.Drawing.Point(12, 17); this.cmbClassSection.Size = new System.Drawing.Size(200, 25);
            this.cmbClassSection.Name = "cmbClassSection"; this.cmbClassSection.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.cmbClassSection.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.cmbClassSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // dtpDate
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDate.Location = new System.Drawing.Point(230, 17); this.dtpDate.Size = new System.Drawing.Size(150, 25);
            this.dtpDate.Name = "dtpDate"; this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.CalendarForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.dtpDate.CalendarMonthBackground = System.Drawing.ColorTranslator.FromHtml("#132218");
            // pnlTop
            this.pnlTop = new System.Windows.Forms.Panel(); this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top; this.pnlTop.Height = 60;
            this.pnlTop.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.pnlTop.Controls.Add(this.cmbClassSection); this.pnlTop.Controls.Add(this.dtpDate); this.pnlTop.Controls.Add(this.btnLoadStudents);
            // dgvAttendance
            this.dgvAttendance = new System.Windows.Forms.DataGridView(); this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttendance.Name = "dgvAttendance"; this.dgvAttendance.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvAttendance.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030"); this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendance.AutoGenerateColumns = false; this.dgvAttendance.ReadOnly = false;
            this.dgvAttendance.RowHeadersVisible = false; this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.EnableHeadersVisualStyles = false; this.dgvAttendance.ColumnHeadersHeight = 38;
            this.dgvAttendance.RowTemplate.Height = 34;
            // pnlBottom
            this.pnlBottom = new System.Windows.Forms.Panel(); this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom; this.pnlBottom.Height = 50;
            this.pnlBottom.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            // btnSaveAttendance
            this.btnSaveAttendance = new System.Windows.Forms.Button(); this.btnSaveAttendance.Text = "Save Attendance";
            this.btnSaveAttendance.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C"); this.btnSaveAttendance.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnSaveAttendance.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold); this.btnSaveAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAttendance.FlatAppearance.BorderSize = 0; this.btnSaveAttendance.Height = 36; this.btnSaveAttendance.Location = new System.Drawing.Point(12, 7); this.btnSaveAttendance.Width = 160;
            this.btnSaveAttendance.Click += new System.EventHandler(this.btnSaveAttendance_Click);
            // lblSummary
            this.lblSummary = new System.Windows.Forms.Label(); this.lblSummary.Location = new System.Drawing.Point(200, 14); this.lblSummary.Size = new System.Drawing.Size(500, 22);
            this.lblSummary.Name = "lblSummary"; this.lblSummary.Text = "Present: 0 | Absent: 0 | Late: 0 | Leave: 0";
            this.lblSummary.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f); this.lblSummary.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.pnlBottom.Controls.Add(this.btnSaveAttendance); this.pnlBottom.Controls.Add(this.lblSummary);

            this.SuspendLayout();
            this.Controls.Add(this.dgvAttendance); this.Controls.Add(this.pnlTop); this.Controls.Add(this.pnlBottom);

            // frmAttendanceMarking
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmAttendanceMarking";
            this.Text = "EduNova - Attendance Marking";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}