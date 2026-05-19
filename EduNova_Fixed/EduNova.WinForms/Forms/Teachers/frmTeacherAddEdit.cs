using System;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.Domain.Entities;
using EduNova.Domain.Enums;

namespace EduNova.WinForms.Forms.Teachers
{
    public partial class frmTeacherAddEdit : Form
    {
        private readonly int _teacherId;
        private readonly TeacherService _svc = new TeacherService();
        private readonly SubjectService _subSvc = new SubjectService();

        public frmTeacherAddEdit(int teacherId)
        {
            _teacherId = teacherId;
            InitializeComponent();
            Load += frmTeacherAddEdit_Load;
        }

        private void frmTeacherAddEdit_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Add("Male"); cmbGender.Items.Add("Female"); cmbGender.Items.Add("Other");
            cmbGender.SelectedIndex = 0;
            var subjects = _subSvc.GetAll();
            foreach (DataRow r in subjects.Rows)
                clbSubjects.Items.Add(r["SubjectName"].ToString(), false);

            if (_teacherId > 0)
            {
                var row = _svc.GetById(_teacherId);
                if (row != null)
                {
                    txtEmpCode.Text = row["EmployeeCode"].ToString();
                    txtFirstName.Text = row["FirstName"].ToString();
                    txtLastName.Text = row["LastName"].ToString();
                    dtpDOB.Value = row["DateOfBirth"] != DBNull.Value ? Convert.ToDateTime(row["DateOfBirth"]) : DateTime.Now.AddYears(-30);
                    cmbGender.SelectedItem = row["GenderText"].ToString();
                    txtPhone.Text = row["Phone"].ToString();
                    txtEmail.Text = row["Email"].ToString();
                    txtAddress.Text = row["Address"].ToString();
                    txtQualification.Text = row["Qualification"].ToString();
                    dtpJoining.Value = Convert.ToDateTime(row["JoiningDate"]);
                    numSalary.Value = Convert.ToDecimal(row["Salary"]);
                }
                var ts = _svc.GetSubjectsForTeacher(_teacherId);
                foreach (DataRow r in ts.Rows)
                {
                    string subName = r["SubjectName"].ToString();
                    int idx = clbSubjects.Items.IndexOf(subName);
                    if (idx >= 0) clbSubjects.SetItemChecked(idx, true);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valid = true;
            if (string.IsNullOrWhiteSpace(txtEmpCode.Text)) { errorProvider1.SetError(txtEmpCode, "Required"); valid = false; }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text)) { errorProvider1.SetError(txtFirstName, "Required"); valid = false; }
            if (string.IsNullOrWhiteSpace(txtLastName.Text)) { errorProvider1.SetError(txtLastName, "Required"); valid = false; }
            if (!valid) return;

            var t = new Teacher
            {
                TeacherId = _teacherId, EmployeeCode = txtEmpCode.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(), LastName = txtLastName.Text.Trim(),
                DateOfBirth = dtpDOB.Value, Gender = (Gender)cmbGender.SelectedIndex + 1,
                Phone = txtPhone.Text.Trim(), Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(), Qualification = txtQualification.Text.Trim(),
                JoiningDate = dtpJoining.Value, Salary = numSalary.Value, IsActive = true
            };
            try
            {
                if (_teacherId == 0) _svc.Insert(t); else _svc.Update(t);
                MessageBox.Show("Teacher saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK; Close();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancel_Click(object sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
    }
}
