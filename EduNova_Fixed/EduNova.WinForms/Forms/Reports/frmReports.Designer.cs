namespace EduNova.WinForms.Forms.Reports
{
    partial class frmReports
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabFeeDue; private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.TabPage tabExamResults; private System.Windows.Forms.TabPage tabSubstitutions;
        private System.Windows.Forms.DataGridView dgvFeeDue; private System.Windows.Forms.DataGridView dgvAttendanceRpt;
        private System.Windows.Forms.DataGridView dgvExamResults; private System.Windows.Forms.DataGridView dgvSubstitutions;
        private System.Windows.Forms.ComboBox cmbRptClass; private System.Windows.Forms.Button btnLoadRpt;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // tabControl
            this.tabControl = new System.Windows.Forms.TabControl(); this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Name = "tabControl"; this.tabControl.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            // tabFeeDue
            this.tabFeeDue = new System.Windows.Forms.TabPage("Fee Due");
            this.dgvFeeDue = new System.Windows.Forms.DataGridView(); this.dgvFeeDue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFeeDue.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvFeeDue.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030"); this.dgvFeeDue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFeeDue.AutoGenerateColumns = false; this.dgvFeeDue.ReadOnly = true;
            this.dgvFeeDue.RowHeadersVisible = false; this.dgvFeeDue.AllowUserToAddRows = false;
            this.dgvFeeDue.EnableHeadersVisualStyles = false; this.dgvFeeDue.ColumnHeadersHeight = 38;
            this.dgvFeeDue.RowTemplate.Height = 34;
            this.tabFeeDue.Controls.Add(this.dgvFeeDue);
            // tabAttendance
            this.tabAttendance = new System.Windows.Forms.TabPage("Attendance");
            this.dgvAttendanceRpt = new System.Windows.Forms.DataGridView(); this.dgvAttendanceRpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttendanceRpt.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvAttendanceRpt.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030"); this.dgvAttendanceRpt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendanceRpt.AutoGenerateColumns = false; this.dgvAttendanceRpt.ReadOnly = true;
            this.dgvAttendanceRpt.RowHeadersVisible = false; this.dgvAttendanceRpt.AllowUserToAddRows = false;
            this.dgvAttendanceRpt.EnableHeadersVisualStyles = false; this.dgvAttendanceRpt.ColumnHeadersHeight = 38;
            this.dgvAttendanceRpt.RowTemplate.Height = 34;
            this.tabAttendance.Controls.Add(this.dgvAttendanceRpt);
            // tabExamResults
            this.tabExamResults = new System.Windows.Forms.TabPage("Exam Results");
            this.dgvExamResults = new System.Windows.Forms.DataGridView(); this.dgvExamResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExamResults.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvExamResults.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030"); this.dgvExamResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExamResults.AutoGenerateColumns = false; this.dgvExamResults.ReadOnly = true;
            this.dgvExamResults.RowHeadersVisible = false; this.dgvExamResults.AllowUserToAddRows = false;
            this.dgvExamResults.EnableHeadersVisualStyles = false; this.dgvExamResults.ColumnHeadersHeight = 38;
            this.dgvExamResults.RowTemplate.Height = 34;
            this.tabExamResults.Controls.Add(this.dgvExamResults);
            // tabSubstitutions
            this.tabSubstitutions = new System.Windows.Forms.TabPage("Substitutions");
            this.dgvSubstitutions = new System.Windows.Forms.DataGridView(); this.dgvSubstitutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubstitutions.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvSubstitutions.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030"); this.dgvSubstitutions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubstitutions.AutoGenerateColumns = false; this.dgvSubstitutions.ReadOnly = true;
            this.dgvSubstitutions.RowHeadersVisible = false; this.dgvSubstitutions.AllowUserToAddRows = false;
            this.dgvSubstitutions.EnableHeadersVisualStyles = false; this.dgvSubstitutions.ColumnHeadersHeight = 38;
            this.dgvSubstitutions.RowTemplate.Height = 34;
            this.tabSubstitutions.Controls.Add(this.dgvSubstitutions);
            this.tabControl.TabPages.Add(this.tabFeeDue); this.tabControl.TabPages.Add(this.tabAttendance);
            this.tabControl.TabPages.Add(this.tabExamResults); this.tabControl.TabPages.Add(this.tabSubstitutions);

            this.SuspendLayout();
            this.Controls.Add(this.tabControl);

            // frmReports
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmReports";
            this.Text = "EduNova - Reports";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}