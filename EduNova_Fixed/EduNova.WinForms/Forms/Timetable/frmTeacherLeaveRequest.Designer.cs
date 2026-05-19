namespace EduNova.WinForms.Forms.Timetable
{
    partial class frmTeacherLeaveRequest
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.DateTimePicker dtpLeaveDate;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnSubmitLeave;
        private System.Windows.Forms.DataGridView dgvLeaveRequests;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;


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
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Teacher Leave & Substitution";
            this.lblTitle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            // cmbTeacher
            this.cmbTeacher = new System.Windows.Forms.ComboBox(); this.cmbTeacher.Location = new System.Drawing.Point(12, 60); this.cmbTeacher.Size = new System.Drawing.Size(200, 25); this.cmbTeacher.Name = "cmbTeacher"; this.cmbTeacher.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.cmbTeacher.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.cmbTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // dtpLeaveDate
            this.dtpLeaveDate = new System.Windows.Forms.DateTimePicker(); this.dtpLeaveDate.Location = new System.Drawing.Point(220, 60); this.dtpLeaveDate.Size = new System.Drawing.Size(140, 25); this.dtpLeaveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // txtReason
            this.txtReason = new System.Windows.Forms.TextBox(); this.txtReason.Location = new System.Drawing.Point(370, 60); this.txtReason.Size = new System.Drawing.Size(260, 25); this.txtReason.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.txtReason.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.txtReason.Text = "Reason";
            // btnSubmitLeave
            this.btnSubmitLeave = new System.Windows.Forms.Button(); this.btnSubmitLeave.Text = "Submit Leave";
            this.btnSubmitLeave.Location = new System.Drawing.Point(640, 56); this.btnSubmitLeave.Size = new System.Drawing.Size(130, 34);
            this.btnSubmitLeave.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C"); this.btnSubmitLeave.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnSubmitLeave.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold); this.btnSubmitLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitLeave.FlatAppearance.BorderSize = 0; this.btnSubmitLeave.Click += new System.EventHandler(this.btnSubmitLeave_Click);
            // pnlTop
            this.pnlTop = new System.Windows.Forms.Panel(); this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top; this.pnlTop.Height = 100;
            this.pnlTop.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.pnlTop.Controls.Add(this.lblTitle); this.pnlTop.Controls.Add(this.cmbTeacher); this.pnlTop.Controls.Add(this.dtpLeaveDate);
            this.pnlTop.Controls.Add(this.txtReason); this.pnlTop.Controls.Add(this.btnSubmitLeave);
            // dgvLeaveRequests
            this.dgvLeaveRequests = new System.Windows.Forms.DataGridView(); this.dgvLeaveRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeaveRequests.Name = "dgvLeaveRequests"; this.dgvLeaveRequests.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvLeaveRequests.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030"); this.dgvLeaveRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLeaveRequests.AutoGenerateColumns = false; this.dgvLeaveRequests.ReadOnly = true;
            this.dgvLeaveRequests.RowHeadersVisible = false; this.dgvLeaveRequests.AllowUserToAddRows = false;
            this.dgvLeaveRequests.EnableHeadersVisualStyles = false; this.dgvLeaveRequests.ColumnHeadersHeight = 38;
            this.dgvLeaveRequests.RowTemplate.Height = 34;

            this.SuspendLayout();
            this.Controls.Add(this.dgvLeaveRequests); this.Controls.Add(this.pnlTop);

            // frmTeacherLeaveRequest
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmTeacherLeaveRequest";
            this.Text = "EduNova - Leave Requests";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}