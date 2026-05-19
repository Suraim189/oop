using System;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.Domain.Entities;
using EduNova.Domain.Enums;

namespace EduNova.WinForms.Forms.Students
{
    public partial class frmStudentAddEdit : Form
    {
        private readonly int _studentId;
        private readonly StudentService _studentService = new StudentService();
        private readonly ClassSectionService _classService = new ClassSectionService();

        public frmStudentAddEdit(int studentId)
        {
            _studentId = studentId;
            InitializeComponent();
            Load += frmStudentAddEdit_Load;
        }

        private void frmStudentAddEdit_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
            cmbGender.SelectedIndex = 0;

            var dt = _classService.GetAll();
            cmbClassSection.DataSource = dt;
            cmbClassSection.DisplayMember = "DisplayName";
            cmbClassSection.ValueMember = "ClassSectionId";

            if (_studentId > 0)
            {
                var row = _studentService.GetById(_studentId);
                if (row != null)
                {
                    txtFirstName.Text = row["FirstName"].ToString();
                    txtLastName.Text = row["LastName"].ToString();
                    dtpDOB.Value = row["DateOfBirth"] != DBNull.Value ? Convert.ToDateTime(row["DateOfBirth"]) : DateTime.Now.AddYears(-10);
                    cmbGender.SelectedItem = row["GenderText"].ToString();
                    txtPhone.Text = row["Phone"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtAddress.Text = row["Address"].ToString();
                    txtAdmissionNo.Text = row["AdmissionNo"].ToString();
                    dtpAdmissionDate.Value = Convert.ToDateTime(row["AdmissionDate"]);
                    txtGuardianName.Text = row["GuardianName"].ToString();
                    txtGuardianRelation.Text = row["GuardianRelation"].ToString();
                    txtGuardianPhone.Text = row["GuardianPhone"].ToString();
                    txtGuardianCNIC.Text = row["GuardianCNIC"].ToString();
                    txtGuardianOccupation.Text = row["GuardianOccupation"].ToString();
                    txtBloodGroup.Text = row["BloodGroup"].ToString();
                    txtMedical.Text = row["MedicalConditions"].ToString();
                    txtPrevSchool.Text = row["PreviousSchool"].ToString();
                    if (row["CurrentClassSectionId"] != DBNull.Value)
                        cmbClassSection.SelectedValue = Convert.ToInt32(row["CurrentClassSectionId"]);
                }
            }
            else
            {
                dtpDOB.Value = DateTime.Now.AddYears(-10);
                dtpAdmissionDate.Value = DateTime.Now;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valid = true;
            if (string.IsNullOrWhiteSpace(txtFirstName.Text)) { errorProvider1.SetError(txtFirstName, "Required"); valid = false; }
            if (string.IsNullOrWhiteSpace(txtLastName.Text)) { errorProvider1.SetError(txtLastName, "Required"); valid = false; }
            if (string.IsNullOrWhiteSpace(txtAdmissionNo.Text)) { errorProvider1.SetError(txtAdmissionNo, "Required"); valid = false; }
            if (!valid) return;

            var s = new Student
            {
                StudentId = _studentId,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                DateOfBirth = dtpDOB.Value,
                Gender = (Gender)cmbGender.SelectedIndex + 1,
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                AdmissionNo = txtAdmissionNo.Text.Trim(),
                AdmissionDate = dtpAdmissionDate.Value,
                Profile = new StudentProfile
                {
                    BloodGroup = txtBloodGroup.Text.Trim(),
                    MedicalConditions = txtMedical.Text.Trim(),
                    PreviousSchool = txtPrevSchool.Text.Trim()
                },
                Guardian = new Guardian
                {
                    Name = txtGuardianName.Text.Trim(),
                    Relation = txtGuardianRelation.Text.Trim(),
                    Phone = txtGuardianPhone.Text.Trim(),
                    CNIC = txtGuardianCNIC.Text.Trim(),
                    Occupation = txtGuardianOccupation.Text.Trim()
                },
                Enrollments = new System.Collections.Generic.List<Enrollment>
                {
                    new Enrollment { ClassSectionId = (int)cmbClassSection.SelectedValue, EnrollmentDate = DateTime.Now, AcademicYear = DateTime.Now.Year.ToString(), IsActive = true }
                }
            };

            try
            {
                if (_studentId == 0)
                    _studentService.Insert(s);
                else
                    _studentService.Update(s);
                MessageBox.Show("Student saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
