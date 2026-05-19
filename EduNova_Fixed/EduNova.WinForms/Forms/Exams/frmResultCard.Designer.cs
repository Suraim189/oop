namespace EduNova.WinForms.Forms.Exams
{
    partial class frmResultCard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ComboBox cmbExam; private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Button btnLoadResult; private System.Windows.Forms.Label lblResultTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblStudentName; private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblExamName; private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblOverallGrade; private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Button btnPrint;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // lblResultTitle
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.lblResultTitle.Location = new System.Drawing.Point(12, 12);
            this.lblResultTitle.Size = new System.Drawing.Size(400, 30);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Text = "Student Result Card";
            this.lblResultTitle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.lblResultTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblResultTitle.BackColor = System.Drawing.Color.Transparent;
            // cmbExam
            this.cmbExam = new System.Windows.Forms.ComboBox(); this.cmbExam.Location = new System.Drawing.Point(12, 50); this.cmbExam.Size = new System.Drawing.Size(220, 25);
            this.cmbExam.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.cmbExam.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.cmbExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // cmbStudent
            this.cmbStudent = new System.Windows.Forms.ComboBox(); this.cmbStudent.Location = new System.Drawing.Point(240, 50); this.cmbStudent.Size = new System.Drawing.Size(220, 25);
            this.cmbStudent.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.cmbStudent.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.cmbStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // btnLoadResult
            this.btnLoadResult = new System.Windows.Forms.Button(); this.btnLoadResult.Text = "Load Result";
            this.btnLoadResult.Location = new System.Drawing.Point(470, 46); this.btnLoadResult.Size = new System.Drawing.Size(120, 34);
            this.btnLoadResult.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C"); this.btnLoadResult.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnLoadResult.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold); this.btnLoadResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadResult.FlatAppearance.BorderSize = 0; this.btnLoadResult.Click += new System.EventHandler(this.btnLoadResult_Click);
            // pnlTop
            this.pnlTop = new System.Windows.Forms.Panel(); this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top; this.pnlTop.Height = 100;
            this.pnlTop.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.pnlTop.Controls.Add(this.lblResultTitle); this.pnlTop.Controls.Add(this.cmbExam); this.pnlTop.Controls.Add(this.cmbStudent); this.pnlTop.Controls.Add(this.btnLoadResult);
            // pnlCard
            this.pnlCard = new System.Windows.Forms.Panel(); this.pnlCard.Location = new System.Drawing.Point(50, 110); this.pnlCard.Size = new System.Drawing.Size(600, 400);
            this.pnlCard.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A2E20"); this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblStudentName
            this.lblStudentName = new System.Windows.Forms.Label(); this.lblStudentName.Location = new System.Drawing.Point(20, 16);
            this.lblStudentName.Size = new System.Drawing.Size(560, 32); this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Text = "Student Name"; this.lblStudentName.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 14f, System.Drawing.FontStyle.Bold);
            this.lblStudentName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C"); this.lblStudentName.BackColor = System.Drawing.Color.Transparent; this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblClass
            this.lblClass = new System.Windows.Forms.Label(); this.lblClass.Location = new System.Drawing.Point(20, 52);
            this.lblClass.Size = new System.Drawing.Size(560, 22); this.lblClass.Name = "lblClass";
            this.lblClass.Text = "Class"; this.lblClass.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10f);
            this.lblClass.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0"); this.lblClass.BackColor = System.Drawing.Color.Transparent; this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblExamName
            this.lblExamName = new System.Windows.Forms.Label(); this.lblExamName.Location = new System.Drawing.Point(20, 80);
            this.lblExamName.Size = new System.Drawing.Size(280, 22); this.lblExamName.Name = "lblExamName";
            this.lblExamName.Text = "Exam"; this.lblExamName.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10f);
            this.lblExamName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.lblExamName.BackColor = System.Drawing.Color.Transparent;
            // lblDate
            this.lblDate = new System.Windows.Forms.Label(); this.lblDate.Location = new System.Drawing.Point(300, 80);
            this.lblDate.Size = new System.Drawing.Size(280, 22); this.lblDate.Name = "lblDate";
            this.lblDate.Text = "Date"; this.lblDate.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10f);
            this.lblDate.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.lblDate.BackColor = System.Drawing.Color.Transparent; this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // dgvResults
            this.dgvResults = new System.Windows.Forms.DataGridView(); this.dgvResults.Location = new System.Drawing.Point(20, 110);
            this.dgvResults.Size = new System.Drawing.Size(560, 200);
            this.dgvResults.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#1A2E20"); this.dgvResults.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030");
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvResults.AutoGenerateColumns = false; this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false; this.dgvResults.AllowUserToAddRows = false; this.dgvResults.EnableHeadersVisualStyles = false;
            // lblOverallGrade
            this.lblOverallGrade = new System.Windows.Forms.Label(); this.lblOverallGrade.Location = new System.Drawing.Point(20, 320);
            this.lblOverallGrade.Size = new System.Drawing.Size(280, 32); this.lblOverallGrade.Name = "lblOverallGrade";
            this.lblOverallGrade.Text = "Grade: -"; this.lblOverallGrade.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 16f, System.Drawing.FontStyle.Bold);
            this.lblOverallGrade.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2ECC71"); this.lblOverallGrade.BackColor = System.Drawing.Color.Transparent;
            // lblPercentage
            this.lblPercentage = new System.Windows.Forms.Label(); this.lblPercentage.Location = new System.Drawing.Point(300, 320);
            this.lblPercentage.Size = new System.Drawing.Size(280, 32); this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Text = "Percentage: 0%"; this.lblPercentage.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 16f, System.Drawing.FontStyle.Bold);
            this.lblPercentage.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C"); this.lblPercentage.BackColor = System.Drawing.Color.Transparent; this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // btnPrint
            this.btnPrint = new System.Windows.Forms.Button(); this.btnPrint.Text = "Print";
            this.btnPrint.Location = new System.Drawing.Point(20, 360); this.btnPrint.Size = new System.Drawing.Size(560, 28);
            this.btnPrint.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A3A25"); this.btnPrint.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnPrint.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold); this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.FlatAppearance.BorderSize = 0; this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.pnlCard.Controls.Add(this.lblStudentName); this.pnlCard.Controls.Add(this.lblClass);
            this.pnlCard.Controls.Add(this.lblExamName); this.pnlCard.Controls.Add(this.lblDate);
            this.pnlCard.Controls.Add(this.dgvResults); this.pnlCard.Controls.Add(this.lblOverallGrade);
            this.pnlCard.Controls.Add(this.lblPercentage); this.pnlCard.Controls.Add(this.btnPrint);

            this.SuspendLayout();
            this.Controls.Add(this.pnlCard); this.Controls.Add(this.pnlTop);

            // frmResultCard
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 560);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmResultCard";
            this.Text = "EduNova - Result Card";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}