namespace EduNova.WinForms.Forms.Exams
{
    partial class frmMarksEntry
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ComboBox cmbExam; private System.Windows.Forms.Button btnLoadStudents; private System.Windows.Forms.Label lblExamInfo; private System.Windows.Forms.Button btnSaveMarks;
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
            this.lblTitle.Text = "Marks Entry";
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
            this.cmbExam = new System.Windows.Forms.ComboBox(); this.cmbExam.Location = new System.Drawing.Point(12, 17); this.cmbExam.Size = new System.Drawing.Size(250, 25); this.cmbExam.Name = "cmbExam"; this.cmbExam.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.cmbExam.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.cmbExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadStudents = new System.Windows.Forms.Button(); this.btnLoadStudents.Text = "Load Students"; this.btnLoadStudents.Location = new System.Drawing.Point(270, 14); this.btnLoadStudents.Size = new System.Drawing.Size(130, 34); this.btnLoadStudents.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C"); this.btnLoadStudents.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.btnLoadStudents.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold); this.btnLoadStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLoadStudents.FlatAppearance.BorderSize = 0; this.btnLoadStudents.Click += new System.EventHandler(this.btnLoadStudents_Click);
            this.lblExamInfo = new System.Windows.Forms.Label(); this.lblExamInfo.Location = new System.Drawing.Point(420, 20); this.lblExamInfo.Size = new System.Drawing.Size(350, 22); this.lblExamInfo.Name = "lblExamInfo"; this.lblExamInfo.Text = ""; this.lblExamInfo.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9f, System.Drawing.FontStyle.Bold); this.lblExamInfo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.pnlTop.Controls.Add(this.cmbExam); this.pnlTop.Controls.Add(this.btnLoadStudents); this.pnlTop.Controls.Add(this.lblExamInfo);
            this.btnSaveMarks = new System.Windows.Forms.Button(); this.btnSaveMarks.Text = "Save Marks"; this.btnSaveMarks.Dock = System.Windows.Forms.DockStyle.Bottom; this.btnSaveMarks.Height = 40; this.btnSaveMarks.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C"); this.btnSaveMarks.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.btnSaveMarks.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold); this.btnSaveMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSaveMarks.FlatAppearance.BorderSize = 0; this.btnSaveMarks.Click += new System.EventHandler(this.btnSaveMarks_Click);

            this.SuspendLayout();
            this.Controls.Add(this.dgvMain); this.Controls.Add(this.pnlTop); this.Controls.Add(this.btnSaveMarks); this.Controls.Add(this.pnlBottom);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Name = "frmMarksEntry";
            this.Text = "EduNova - Marks Entry";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}