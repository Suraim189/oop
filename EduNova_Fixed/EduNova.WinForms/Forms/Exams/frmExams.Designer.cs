namespace EduNova.WinForms.Forms.Exams
{
    partial class frmExams
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.ComboBox cmbExamType; private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbSubject; private System.Windows.Forms.DateTimePicker dtpExamDate;
        private System.Windows.Forms.NumericUpDown numTotalMarks; private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.Button btnSaveExam; private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Label lblTitle;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // lblTitle
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Size = new System.Drawing.Size(350, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Exam Management";
            this.lblTitle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            // btnExportCSV
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnExportCSV.Location = new System.Drawing.Point(850, 14);
            this.btnExportCSV.Size = new System.Drawing.Size(100, 34);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Text = "Export";
            this.btnExportCSV.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A3A25");
            this.btnExportCSV.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnExportCSV.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.FlatAppearance.BorderSize = 0;
            this.btnExportCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // pnlTop
            this.pnlTop = new System.Windows.Forms.Panel(); this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top; this.pnlTop.Height = 60;
            this.pnlTop.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.pnlTop.Controls.Add(this.lblTitle); this.pnlTop.Controls.Add(this.btnExportCSV);
            // dgvExams
            this.dgvExams = new System.Windows.Forms.DataGridView(); this.dgvExams.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvExams.Width = 580; this.dgvExams.Name = "dgvExams";
            this.dgvExams.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvExams.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030"); this.dgvExams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExams.AutoGenerateColumns = false; this.dgvExams.ReadOnly = true;
            this.dgvExams.RowHeadersVisible = false; this.dgvExams.AllowUserToAddRows = false;
            this.dgvExams.EnableHeadersVisualStyles = false; this.dgvExams.ColumnHeadersHeight = 38;
            this.dgvExams.RowTemplate.Height = 34;
            // pnlRight
            this.pnlRight = new System.Windows.Forms.Panel(); this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Width = 360; this.pnlRight.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.pnlRight.Padding = new System.Windows.Forms.Padding(12);
            // txtExamName
            this.txtExamName = new System.Windows.Forms.TextBox(); this.txtExamName.Location = new System.Drawing.Point(12, 12);
            this.txtExamName.Size = new System.Drawing.Size(336, 25); this.txtExamName.Name = "txtExamName";
            this.txtExamName.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A2E20"); this.txtExamName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtExamName.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f); this.txtExamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // cmbExamType
            this.cmbExamType = new System.Windows.Forms.ComboBox(); this.cmbExamType.Location = new System.Drawing.Point(12, 44);
            this.cmbExamType.Size = new System.Drawing.Size(336, 25); this.cmbExamType.Name = "cmbExamType";
            this.cmbExamType.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A2E20"); this.cmbExamType.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.cmbExamType.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.cmbExamType.Items.AddRange(new object[]{"Monthly","HalfBook","FullBook"}); this.cmbExamType.SelectedIndex = 0;
            // cmbClass
            this.cmbClass = new System.Windows.Forms.ComboBox(); this.cmbClass.Location = new System.Drawing.Point(12, 76);
            this.cmbClass.Size = new System.Drawing.Size(336, 25); this.cmbClass.Name = "cmbClass";
            this.cmbClass.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A2E20"); this.cmbClass.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // cmbSubject
            this.cmbSubject = new System.Windows.Forms.ComboBox(); this.cmbSubject.Location = new System.Drawing.Point(12, 108);
            this.cmbSubject.Size = new System.Drawing.Size(336, 25); this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A2E20"); this.cmbSubject.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.cmbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // dtpExamDate
            this.dtpExamDate = new System.Windows.Forms.DateTimePicker(); this.dtpExamDate.Location = new System.Drawing.Point(12, 140);
            this.dtpExamDate.Size = new System.Drawing.Size(336, 25); this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.CalendarForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.dtpExamDate.CalendarMonthBackground = System.Drawing.ColorTranslator.FromHtml("#1A2E20");
            // numTotalMarks
            this.numTotalMarks = new System.Windows.Forms.NumericUpDown(); this.numTotalMarks.Location = new System.Drawing.Point(12, 172);
            this.numTotalMarks.Size = new System.Drawing.Size(336, 25); this.numTotalMarks.Name = "numTotalMarks";
            this.numTotalMarks.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A2E20"); this.numTotalMarks.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.numTotalMarks.Maximum = 1000; this.numTotalMarks.Minimum = 0; this.numTotalMarks.Value = 100;
            // btnSaveExam
            this.btnSaveExam = new System.Windows.Forms.Button(); this.btnSaveExam.Text = "Save Exam";
            this.btnSaveExam.Location = new System.Drawing.Point(12, 210); this.btnSaveExam.Size = new System.Drawing.Size(160, 36);
            this.btnSaveExam.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C"); this.btnSaveExam.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnSaveExam.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold); this.btnSaveExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveExam.FlatAppearance.BorderSize = 0; this.btnSaveExam.Click += new System.EventHandler(this.btnSaveExam_Click);
            // btnDeleteExam
            this.btnDeleteExam = new System.Windows.Forms.Button(); this.btnDeleteExam.Text = "Delete";
            this.btnDeleteExam.Location = new System.Drawing.Point(180, 210); this.btnDeleteExam.Size = new System.Drawing.Size(160, 36);
            this.btnDeleteExam.BackColor = System.Drawing.ColorTranslator.FromHtml("#7B2D2D"); this.btnDeleteExam.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFB3B3");
            this.btnDeleteExam.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold); this.btnDeleteExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteExam.FlatAppearance.BorderSize = 0; this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteExam_Click);
            this.pnlRight.Controls.Add(this.txtExamName); this.pnlRight.Controls.Add(this.cmbExamType);
            this.pnlRight.Controls.Add(this.cmbClass); this.pnlRight.Controls.Add(this.cmbSubject);
            this.pnlRight.Controls.Add(this.dtpExamDate); this.pnlRight.Controls.Add(this.numTotalMarks);
            this.pnlRight.Controls.Add(this.btnSaveExam); this.pnlRight.Controls.Add(this.btnDeleteExam);
            // lblCount
            this.lblCount = new System.Windows.Forms.Label(); this.lblCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCount.Text = "Total: 0"; this.lblCount.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9f);
            this.lblCount.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            // pnlBottom
            this.pnlBottom = new System.Windows.Forms.Panel(); this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom; this.pnlBottom.Height = 30;
            this.pnlBottom.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.pnlBottom.Controls.Add(this.lblCount);

            this.SuspendLayout();
            this.Controls.Add(this.dgvExams); this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlTop); this.Controls.Add(this.pnlBottom);

            // frmExams
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmExams";
            this.Text = "EduNova - Exams";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}