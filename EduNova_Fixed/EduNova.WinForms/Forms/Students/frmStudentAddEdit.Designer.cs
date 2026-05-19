namespace EduNova.WinForms.Forms.Students
{
    partial class frmStudentAddEdit
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSection1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAdmissionNo;
        private System.Windows.Forms.TextBox txtAdmissionNo;
        private System.Windows.Forms.Label lblAdmissionDate;
        private System.Windows.Forms.DateTimePicker dtpAdmissionDate;
        private System.Windows.Forms.Label lblSection2;
        private System.Windows.Forms.Label lblGuardianName;
        private System.Windows.Forms.TextBox txtGuardianName;
        private System.Windows.Forms.Label lblGuardianRelation;
        private System.Windows.Forms.TextBox txtGuardianRelation;
        private System.Windows.Forms.Label lblGuardianPhone;
        private System.Windows.Forms.TextBox txtGuardianPhone;
        private System.Windows.Forms.Label lblGuardianCNIC;
        private System.Windows.Forms.TextBox txtGuardianCNIC;
        private System.Windows.Forms.Label lblGuardianOccupation;
        private System.Windows.Forms.TextBox txtGuardianOccupation;
        private System.Windows.Forms.Label lblSection3;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.Label lblMedical;
        private System.Windows.Forms.TextBox txtMedical;
        private System.Windows.Forms.Label lblPrevSchool;
        private System.Windows.Forms.TextBox txtPrevSchool;
        private System.Windows.Forms.Label lblClassSection;
        private System.Windows.Forms.ComboBox cmbClassSection;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
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
            this.lblSection1.Text = "Personal Information";
            this.lblSection1.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.lblSection1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblSection1.BackColor = System.Drawing.Color.Transparent;
            // lblFirstName
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblFirstName.Location = new System.Drawing.Point(20, 40);
            this.lblFirstName.Size = new System.Drawing.Size(150, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Text = "First Name *";
            this.lblFirstName.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblFirstName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            // txtFirstName
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtFirstName.Location = new System.Drawing.Point(20, 62);
            this.txtFirstName.Size = new System.Drawing.Size(250, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtFirstName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtFirstName.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblLastName
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblLastName.Location = new System.Drawing.Point(300, 40);
            this.lblLastName.Size = new System.Drawing.Size(150, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Text = "Last Name *";
            this.lblLastName.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblLastName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            // txtLastName
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtLastName.Location = new System.Drawing.Point(300, 62);
            this.txtLastName.Size = new System.Drawing.Size(250, 25);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtLastName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtLastName.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblDOB
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblDOB.Location = new System.Drawing.Point(20, 92);
            this.lblDOB.Size = new System.Drawing.Size(150, 20);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Text = "Date of Birth";
            this.lblDOB.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblDOB.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            // dtpDOB
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.dtpDOB.Location = new System.Drawing.Point(20, 114);
            this.dtpDOB.Size = new System.Drawing.Size(250, 25);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.CalendarForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.dtpDOB.CalendarMonthBackground = System.Drawing.ColorTranslator.FromHtml("#132218");
            // lblGender
            this.lblGender = new System.Windows.Forms.Label();
            this.lblGender.Location = new System.Drawing.Point(300, 92);
            this.lblGender.Size = new System.Drawing.Size(150, 20);
            this.lblGender.Name = "lblGender";
            this.lblGender.Text = "Gender";
            this.lblGender.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblGender.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            // cmbGender
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbGender.Location = new System.Drawing.Point(300, 114);
            this.cmbGender.Size = new System.Drawing.Size(250, 25);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.cmbGender.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.cmbGender.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // lblPhone
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPhone.Location = new System.Drawing.Point(20, 144);
            this.lblPhone.Size = new System.Drawing.Size(150, 20);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Text = "Phone";
            this.lblPhone.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblPhone.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            // txtPhone
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPhone.Location = new System.Drawing.Point(20, 166);
            this.txtPhone.Size = new System.Drawing.Size(250, 25);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtPhone.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtPhone.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblEmail
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmail.Location = new System.Drawing.Point(300, 144);
            this.lblEmail.Size = new System.Drawing.Size(150, 20);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "Email";
            this.lblEmail.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            // txtEmail
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEmail.Location = new System.Drawing.Point(300, 166);
            this.txtEmail.Size = new System.Drawing.Size(250, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtEmail.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblAddress
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAddress.Location = new System.Drawing.Point(20, 196);
            this.lblAddress.Size = new System.Drawing.Size(150, 20);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Text = "Address";
            this.lblAddress.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblAddress.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            // txtAddress
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAddress.Location = new System.Drawing.Point(20, 218);
            this.txtAddress.Size = new System.Drawing.Size(530, 25);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtAddress.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtAddress.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblAdmissionNo
            this.lblAdmissionNo = new System.Windows.Forms.Label();
            this.lblAdmissionNo.Location = new System.Drawing.Point(20, 248);
            this.lblAdmissionNo.Size = new System.Drawing.Size(150, 20);
            this.lblAdmissionNo.Name = "lblAdmissionNo";
            this.lblAdmissionNo.Text = "Admission No *";
            this.lblAdmissionNo.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblAdmissionNo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblAdmissionNo.BackColor = System.Drawing.Color.Transparent;
            // txtAdmissionNo
            this.txtAdmissionNo = new System.Windows.Forms.TextBox();
            this.txtAdmissionNo.Location = new System.Drawing.Point(20, 270);
            this.txtAdmissionNo.Size = new System.Drawing.Size(250, 25);
            this.txtAdmissionNo.Name = "txtAdmissionNo";
            this.txtAdmissionNo.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtAdmissionNo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtAdmissionNo.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtAdmissionNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblAdmissionDate
            this.lblAdmissionDate = new System.Windows.Forms.Label();
            this.lblAdmissionDate.Location = new System.Drawing.Point(300, 248);
            this.lblAdmissionDate.Size = new System.Drawing.Size(150, 20);
            this.lblAdmissionDate.Name = "lblAdmissionDate";
            this.lblAdmissionDate.Text = "Admission Date";
            this.lblAdmissionDate.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblAdmissionDate.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblAdmissionDate.BackColor = System.Drawing.Color.Transparent;
            // dtpAdmissionDate
            this.dtpAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.dtpAdmissionDate.Location = new System.Drawing.Point(300, 270);
            this.dtpAdmissionDate.Size = new System.Drawing.Size(250, 25);
            this.dtpAdmissionDate.Name = "dtpAdmissionDate";
            this.dtpAdmissionDate.CalendarForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.dtpAdmissionDate.CalendarMonthBackground = System.Drawing.ColorTranslator.FromHtml("#132218");
            // lblSection2
            this.lblSection2 = new System.Windows.Forms.Label();
            this.lblSection2.Location = new System.Drawing.Point(20, 300);
            this.lblSection2.Size = new System.Drawing.Size(200, 22);
            this.lblSection2.Name = "lblSection2";
            this.lblSection2.Text = "Guardian Information";
            this.lblSection2.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.lblSection2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblSection2.BackColor = System.Drawing.Color.Transparent;
            // lblGuardianName
            this.lblGuardianName = new System.Windows.Forms.Label();
            this.lblGuardianName.Location = new System.Drawing.Point(20, 328);
            this.lblGuardianName.Size = new System.Drawing.Size(150, 20);
            this.lblGuardianName.Name = "lblGuardianName";
            this.lblGuardianName.Text = "Guardian Name";
            this.lblGuardianName.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblGuardianName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblGuardianName.BackColor = System.Drawing.Color.Transparent;
            // txtGuardianName
            this.txtGuardianName = new System.Windows.Forms.TextBox();
            this.txtGuardianName.Location = new System.Drawing.Point(20, 350);
            this.txtGuardianName.Size = new System.Drawing.Size(250, 25);
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtGuardianName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtGuardianName.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtGuardianName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblGuardianRelation
            this.lblGuardianRelation = new System.Windows.Forms.Label();
            this.lblGuardianRelation.Location = new System.Drawing.Point(300, 328);
            this.lblGuardianRelation.Size = new System.Drawing.Size(150, 20);
            this.lblGuardianRelation.Name = "lblGuardianRelation";
            this.lblGuardianRelation.Text = "Relation";
            this.lblGuardianRelation.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblGuardianRelation.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblGuardianRelation.BackColor = System.Drawing.Color.Transparent;
            // txtGuardianRelation
            this.txtGuardianRelation = new System.Windows.Forms.TextBox();
            this.txtGuardianRelation.Location = new System.Drawing.Point(300, 350);
            this.txtGuardianRelation.Size = new System.Drawing.Size(250, 25);
            this.txtGuardianRelation.Name = "txtGuardianRelation";
            this.txtGuardianRelation.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtGuardianRelation.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtGuardianRelation.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtGuardianRelation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblGuardianPhone
            this.lblGuardianPhone = new System.Windows.Forms.Label();
            this.lblGuardianPhone.Location = new System.Drawing.Point(20, 378);
            this.lblGuardianPhone.Size = new System.Drawing.Size(150, 20);
            this.lblGuardianPhone.Name = "lblGuardianPhone";
            this.lblGuardianPhone.Text = "Guardian Phone";
            this.lblGuardianPhone.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblGuardianPhone.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblGuardianPhone.BackColor = System.Drawing.Color.Transparent;
            // txtGuardianPhone
            this.txtGuardianPhone = new System.Windows.Forms.TextBox();
            this.txtGuardianPhone.Location = new System.Drawing.Point(20, 400);
            this.txtGuardianPhone.Size = new System.Drawing.Size(250, 25);
            this.txtGuardianPhone.Name = "txtGuardianPhone";
            this.txtGuardianPhone.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtGuardianPhone.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtGuardianPhone.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtGuardianPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblGuardianCNIC
            this.lblGuardianCNIC = new System.Windows.Forms.Label();
            this.lblGuardianCNIC.Location = new System.Drawing.Point(300, 378);
            this.lblGuardianCNIC.Size = new System.Drawing.Size(150, 20);
            this.lblGuardianCNIC.Name = "lblGuardianCNIC";
            this.lblGuardianCNIC.Text = "Guardian CNIC";
            this.lblGuardianCNIC.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblGuardianCNIC.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblGuardianCNIC.BackColor = System.Drawing.Color.Transparent;
            // txtGuardianCNIC
            this.txtGuardianCNIC = new System.Windows.Forms.TextBox();
            this.txtGuardianCNIC.Location = new System.Drawing.Point(300, 400);
            this.txtGuardianCNIC.Size = new System.Drawing.Size(250, 25);
            this.txtGuardianCNIC.Name = "txtGuardianCNIC";
            this.txtGuardianCNIC.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtGuardianCNIC.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtGuardianCNIC.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtGuardianCNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblGuardianOccupation
            this.lblGuardianOccupation = new System.Windows.Forms.Label();
            this.lblGuardianOccupation.Location = new System.Drawing.Point(20, 428);
            this.lblGuardianOccupation.Size = new System.Drawing.Size(150, 20);
            this.lblGuardianOccupation.Name = "lblGuardianOccupation";
            this.lblGuardianOccupation.Text = "Occupation";
            this.lblGuardianOccupation.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblGuardianOccupation.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblGuardianOccupation.BackColor = System.Drawing.Color.Transparent;
            // txtGuardianOccupation
            this.txtGuardianOccupation = new System.Windows.Forms.TextBox();
            this.txtGuardianOccupation.Location = new System.Drawing.Point(20, 450);
            this.txtGuardianOccupation.Size = new System.Drawing.Size(250, 25);
            this.txtGuardianOccupation.Name = "txtGuardianOccupation";
            this.txtGuardianOccupation.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtGuardianOccupation.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtGuardianOccupation.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtGuardianOccupation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblSection3
            this.lblSection3 = new System.Windows.Forms.Label();
            this.lblSection3.Location = new System.Drawing.Point(20, 480);
            this.lblSection3.Size = new System.Drawing.Size(200, 22);
            this.lblSection3.Name = "lblSection3";
            this.lblSection3.Text = "Additional Info";
            this.lblSection3.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.lblSection3.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblSection3.BackColor = System.Drawing.Color.Transparent;
            // lblBloodGroup
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.lblBloodGroup.Location = new System.Drawing.Point(20, 508);
            this.lblBloodGroup.Size = new System.Drawing.Size(150, 20);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Text = "Blood Group";
            this.lblBloodGroup.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblBloodGroup.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblBloodGroup.BackColor = System.Drawing.Color.Transparent;
            // txtBloodGroup
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.txtBloodGroup.Location = new System.Drawing.Point(20, 530);
            this.txtBloodGroup.Size = new System.Drawing.Size(250, 25);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtBloodGroup.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtBloodGroup.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtBloodGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblMedical
            this.lblMedical = new System.Windows.Forms.Label();
            this.lblMedical.Location = new System.Drawing.Point(300, 508);
            this.lblMedical.Size = new System.Drawing.Size(150, 20);
            this.lblMedical.Name = "lblMedical";
            this.lblMedical.Text = "Medical Conditions";
            this.lblMedical.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblMedical.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblMedical.BackColor = System.Drawing.Color.Transparent;
            // txtMedical
            this.txtMedical = new System.Windows.Forms.TextBox();
            this.txtMedical.Location = new System.Drawing.Point(300, 530);
            this.txtMedical.Size = new System.Drawing.Size(250, 25);
            this.txtMedical.Name = "txtMedical";
            this.txtMedical.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtMedical.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtMedical.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtMedical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblPrevSchool
            this.lblPrevSchool = new System.Windows.Forms.Label();
            this.lblPrevSchool.Location = new System.Drawing.Point(20, 558);
            this.lblPrevSchool.Size = new System.Drawing.Size(150, 20);
            this.lblPrevSchool.Name = "lblPrevSchool";
            this.lblPrevSchool.Text = "Previous School";
            this.lblPrevSchool.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblPrevSchool.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblPrevSchool.BackColor = System.Drawing.Color.Transparent;
            // txtPrevSchool
            this.txtPrevSchool = new System.Windows.Forms.TextBox();
            this.txtPrevSchool.Location = new System.Drawing.Point(20, 580);
            this.txtPrevSchool.Size = new System.Drawing.Size(250, 25);
            this.txtPrevSchool.Name = "txtPrevSchool";
            this.txtPrevSchool.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtPrevSchool.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtPrevSchool.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtPrevSchool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // lblClassSection
            this.lblClassSection = new System.Windows.Forms.Label();
            this.lblClassSection.Location = new System.Drawing.Point(300, 558);
            this.lblClassSection.Size = new System.Drawing.Size(150, 20);
            this.lblClassSection.Name = "lblClassSection";
            this.lblClassSection.Text = "Class Section *";
            this.lblClassSection.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblClassSection.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblClassSection.BackColor = System.Drawing.Color.Transparent;
            // cmbClassSection
            this.cmbClassSection = new System.Windows.Forms.ComboBox();
            this.cmbClassSection.Location = new System.Drawing.Point(300, 580);
            this.cmbClassSection.Size = new System.Drawing.Size(250, 25);
            this.cmbClassSection.Name = "cmbClassSection";
            this.cmbClassSection.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.cmbClassSection.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.cmbClassSection.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.cmbClassSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // btnSave
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSave.Location = new System.Drawing.Point(120, 618);
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
            this.btnCancel.Location = new System.Drawing.Point(260, 618);
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
            // errorProvider1
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            this.SuspendLayout();
            this.Controls.Add(this.lblSection1);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAdmissionNo);
            this.Controls.Add(this.txtAdmissionNo);
            this.Controls.Add(this.lblAdmissionDate);
            this.Controls.Add(this.dtpAdmissionDate);
            this.Controls.Add(this.lblSection2);
            this.Controls.Add(this.lblGuardianName);
            this.Controls.Add(this.txtGuardianName);
            this.Controls.Add(this.lblGuardianRelation);
            this.Controls.Add(this.txtGuardianRelation);
            this.Controls.Add(this.lblGuardianPhone);
            this.Controls.Add(this.txtGuardianPhone);
            this.Controls.Add(this.lblGuardianCNIC);
            this.Controls.Add(this.txtGuardianCNIC);
            this.Controls.Add(this.lblGuardianOccupation);
            this.Controls.Add(this.txtGuardianOccupation);
            this.Controls.Add(this.lblSection3);
            this.Controls.Add(this.lblBloodGroup);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.lblMedical);
            this.Controls.Add(this.txtMedical);
            this.Controls.Add(this.lblPrevSchool);
            this.Controls.Add(this.txtPrevSchool);
            this.Controls.Add(this.lblClassSection);
            this.Controls.Add(this.cmbClassSection);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            // frmStudentAddEdit
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 690);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmStudentAddEdit";
            this.Text = "EduNova - Add/Edit Student";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}