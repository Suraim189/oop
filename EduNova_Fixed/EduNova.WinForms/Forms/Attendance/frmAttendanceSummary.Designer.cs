namespace EduNova.WinForms.Forms.Attendance
{
    partial class frmAttendanceSummary
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExportCSV;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // lblTitle
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Attendance Summary";
            this.lblTitle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            // pnlTop
            this.pnlTop = new System.Windows.Forms.Panel(); this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top; this.pnlTop.Height = 60;
            this.pnlTop.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.pnlTop.Controls.Add(this.lblTitle);
            // dgvMain
            this.dgvMain = new System.Windows.Forms.DataGridView(); this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Name = "dgvMain"; this.dgvMain.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvMain.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030"); this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.AutoGenerateColumns = false; this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false; this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.EnableHeadersVisualStyles = false; this.dgvMain.ColumnHeadersHeight = 38;
            this.dgvMain.RowTemplate.Height = 34;
            // lblCount
            this.lblCount = new System.Windows.Forms.Label(); this.lblCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCount.Text = "Total: 0"; this.lblCount.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9f);
            this.lblCount.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            // pnlBottom
            this.pnlBottom = new System.Windows.Forms.Panel(); this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom; this.pnlBottom.Height = 30;
            this.pnlBottom.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.pnlBottom.Controls.Add(this.lblCount);
            this.cmbClass = new System.Windows.Forms.ComboBox(); this.cmbClass.Location = new System.Drawing.Point(400, 17); this.cmbClass.Size = new System.Drawing.Size(140, 25); this.cmbClass.Name = "cmbClass"; this.cmbClass.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.cmbClass.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dtpFrom = new System.Windows.Forms.DateTimePicker(); this.dtpFrom.Location = new System.Drawing.Point(550, 17); this.dtpFrom.Size = new System.Drawing.Size(120, 25); this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo = new System.Windows.Forms.DateTimePicker(); this.dtpTo.Location = new System.Drawing.Point(680, 17); this.dtpTo.Size = new System.Drawing.Size(120, 25); this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pnlTop.Controls.Add(this.cmbClass); this.pnlTop.Controls.Add(this.dtpFrom); this.pnlTop.Controls.Add(this.dtpTo);
            this.pnlTop.Controls.Add(this.btnLoad);            // btnLoad
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLoad.Location = new System.Drawing.Point(810, 14);
            this.btnLoad.Size = new System.Drawing.Size(80, 34);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Text = "Load";
            this.btnLoad.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnLoad.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnLoad.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // btnExportCSV
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnExportCSV.Location = new System.Drawing.Point(900, 14);
            this.btnExportCSV.Size = new System.Drawing.Size(80, 34);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Text = "Export";
            this.btnExportCSV.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A3A25");
            this.btnExportCSV.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnExportCSV.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.FlatAppearance.BorderSize = 0;
            this.btnExportCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);

            this.SuspendLayout();
            this.Controls.Add(this.dgvMain); this.Controls.Add(this.pnlTop); this.Controls.Add(this.pnlBottom);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "frmAttendanceSummary";
            this.Text = "EduNova - Attendance Summary";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}