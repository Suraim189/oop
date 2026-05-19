namespace EduNova.WinForms.Forms.Teachers
{
    partial class frmTeacherAddEdit
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSection1;
        private System.Windows.Forms.Label lblEmpCode; private System.Windows.Forms.TextBox txtEmpCode;
        private System.Windows.Forms.Label lblFirstName; private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName; private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblDOB; private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblGender; private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblPhone; private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail; private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress; private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblQualification; private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.Label lblJoiningDate; private System.Windows.Forms.DateTimePicker dtpJoining;
        private System.Windows.Forms.Label lblSalary; private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.Label lblSubjects; private System.Windows.Forms.CheckedListBox clbSubjects;
        private System.Windows.Forms.Button btnSave; private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // lblSection1
            this.lblSection1 = new System.Windows.Forms.Label();
            this.lblSection1.Location = new System.Drawing.Point(20, 12);
            this.lblSection1.Size = new System.Drawing.Size(200, 22);
            this.lblSection1.Name = "lblSection1";
            this.lblSection1.Text = "Teacher Information";
            this.lblSection1.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.lblSection1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblSection1.BackColor = System.Drawing.Color.Transparent;
            // lblEmpCode
            this.lblEmpCode = new System.Windows.Forms.Label();
            this.lblEmpCode.Location = new System.Drawing.Point(20, 40);
            this.lblEmpCode.Size = new System.Drawing.Size(150, 20);
            this.lblEmpCode.Name = "lblEmpCode";
            this.lblEmpCode.Text = "Employee Code *";
            this.lblEmpCode.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblEmpCode.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblEmpCode.BackColor = System.Drawing.Color.Transparent;
            // txtEmpCode
            this.txtEmpCode = new System.Windows.Forms.TextBox();
            this.txtEmpCode.Location = new System.Drawing.Point(20, 62);
            this.txtEmpCode.Size = new System.Drawing.Size(250, 25);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtEmpCode.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtEmpCode.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtEmpCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblFirstName
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblFirstName.Location = new System.Drawing.Point(300, 40);
            this.lblFirstName.Size = new System.Drawing.Size(150, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Text = "First Name *";
            this.lblFirstName.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblFirstName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            // txtFirstName
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtFirstName.Location = new System.Drawing.Point(300, 62);
            this.txtFirstName.Size = new System.Drawing.Size(250, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtFirstName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtFirstName.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblLastName
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblLastName.Location = new System.Drawing.Point(20, 92);
            this.lblLastName.Size = new System.Drawing.Size(150, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Text = "Last Name *";
            this.lblLastName.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblLastName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            // txtLastName
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtLastName.Location = new System.Drawing.Point(20, 114);
            this.txtLastName.Size = new System.Drawing.Size(250, 25);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtLastName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtLastName.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblDOB
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblDOB.Location = new System.Drawing.Point(300, 92);
            this.lblDOB.Size = new System.Drawing.Size(150, 20);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Text = "Date of Birth";
            this.lblDOB.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblDOB.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            // dtpDOB
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.dtpDOB.Location = new System.Drawing.Point(300, 114);
            this.dtpDOB.Size = new System.Drawing.Size(250, 25);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.CalendarForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.dtpDOB.CalendarMonthBackground = System.Drawing.ColorTranslator.FromHtml("#132218");
            // lblGender
            this.lblGender = new System.Windows.Forms.Label();
            this.lblGender.Location = new System.Drawing.Point(20, 144);
            this.lblGender.Size = new System.Drawing.Size(150, 20);
            this.lblGender.Name = "lblGender";
            this.lblGender.Text = "Gender";
            this.lblGender.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblGender.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            // cmbGender
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbGender.Location = new System.Drawing.Point(20, 166);
            this.cmbGender.Size = new System.Drawing.Size(250, 25);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.cmbGender.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.cmbGender.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // lblPhone
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPhone.Location = new System.Drawing.Point(300, 144);
            this.lblPhone.Size = new System.Drawing.Size(150, 20);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Text = "Phone";
            this.lblPhone.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblPhone.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            // txtPhone
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPhone.Location = new System.Drawing.Point(300, 166);
            this.txtPhone.Size = new System.Drawing.Size(250, 25);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtPhone.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtPhone.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblEmail
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmail.Location = new System.Drawing.Point(20, 196);
            this.lblEmail.Size = new System.Drawing.Size(150, 20);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "Email";
            this.lblEmail.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            // txtEmail
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEmail.Location = new System.Drawing.Point(20, 218);
            this.txtEmail.Size = new System.Drawing.Size(250, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtEmail.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblAddress
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAddress.Location = new System.Drawing.Point(300, 196);
            this.lblAddress.Size = new System.Drawing.Size(150, 20);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Text = "Address";
            this.lblAddress.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblAddress.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            // txtAddress
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAddress.Location = new System.Drawing.Point(300, 218);
            this.txtAddress.Size = new System.Drawing.Size(250, 25);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtAddress.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtAddress.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblQualification
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblQualification.Location = new System.Drawing.Point(20, 248);
            this.lblQualification.Size = new System.Drawing.Size(150, 20);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Text = "Qualification";
            this.lblQualification.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblQualification.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblQualification.BackColor = System.Drawing.Color.Transparent;
            // txtQualification
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.txtQualification.Location = new System.Drawing.Point(20, 270);
            this.txtQualification.Size = new System.Drawing.Size(250, 25);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtQualification.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtQualification.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtQualification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblJoiningDate
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.lblJoiningDate.Location = new System.Drawing.Point(300, 248);
            this.lblJoiningDate.Size = new System.Drawing.Size(150, 20);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Text = "Joining Date";
            this.lblJoiningDate.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblJoiningDate.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblJoiningDate.BackColor = System.Drawing.Color.Transparent;
            // dtpJoining
            this.dtpJoining = new System.Windows.Forms.DateTimePicker();
            this.dtpJoining.Location = new System.Drawing.Point(300, 270);
            this.dtpJoining.Size = new System.Drawing.Size(250, 25);
            this.dtpJoining.Name = "dtpJoining";
            this.dtpJoining.CalendarForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.dtpJoining.CalendarMonthBackground = System.Drawing.ColorTranslator.FromHtml("#132218");
            // lblSalary
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblSalary.Location = new System.Drawing.Point(20, 300);
            this.lblSalary.Size = new System.Drawing.Size(150, 20);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Text = "Salary";
            this.lblSalary.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblSalary.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblSalary.BackColor = System.Drawing.Color.Transparent;
            // numSalary
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.numSalary.Location = new System.Drawing.Point(20, 322);
            this.numSalary.Size = new System.Drawing.Size(250, 25);
            this.numSalary.Name = "numSalary";
            this.numSalary.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.numSalary.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.numSalary.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f);
            this.numSalary.Maximum = 1000000;
            this.numSalary.Minimum = 0;
            // lblSubjects
            this.lblSubjects = new System.Windows.Forms.Label();
            this.lblSubjects.Location = new System.Drawing.Point(300, 300);
            this.lblSubjects.Size = new System.Drawing.Size(150, 20);
            this.lblSubjects.Name = "lblSubjects";
            this.lblSubjects.Text = "Subjects";
            this.lblSubjects.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblSubjects.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblSubjects.BackColor = System.Drawing.Color.Transparent;
            // clbSubjects
            this.clbSubjects = new System.Windows.Forms.CheckedListBox();
            this.clbSubjects.Location = new System.Drawing.Point(300, 322);
            this.clbSubjects.Size = new System.Drawing.Size(250, 100);
            this.clbSubjects.Name = "clbSubjects";
            this.clbSubjects.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.clbSubjects.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.clbSubjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // btnSave
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSave.Location = new System.Drawing.Point(120, 440);
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Save";
            this.btnSave.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnSave.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnSave.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // btnCancel
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancel.Location = new System.Drawing.Point(260, 440);
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A3A25");
            this.btnCancel.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnCancel.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            this.SuspendLayout();
            this.Controls.Add(this.lblSection1);
            this.Controls.Add(this.lblEmpCode); this.Controls.Add(this.txtEmpCode);
            this.Controls.Add(this.lblFirstName); this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName); this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblDOB); this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblGender); this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblPhone); this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail); this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAddress); this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblQualification); this.Controls.Add(this.txtQualification);
            this.Controls.Add(this.lblJoiningDate); this.Controls.Add(this.dtpJoining);
            this.Controls.Add(this.lblSalary); this.Controls.Add(this.numSalary);
            this.Controls.Add(this.lblSubjects); this.Controls.Add(this.clbSubjects);
            this.Controls.Add(this.btnSave); this.Controls.Add(this.btnCancel);

            // frmTeacherAddEdit
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmTeacherAddEdit";
            this.Text = "EduNova - Add/Edit Teacher";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}