using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Students
{
    public partial class frmStudents : Form
    {
        private readonly StudentService _service = new StudentService();
        private DataTable _allStudents;

        public frmStudents()
        {
            InitializeComponent();
            Load += frmStudents_Load;
            Theme.StyleDataGridView(dgvStudents);
            SetupColumns();
        }

        private void SetupColumns()
        {
            dgvStudents.Columns.Clear();
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAdmNo", HeaderText = "Adm No", DataPropertyName = "AdmissionNo", Width = 90 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Full Name", DataPropertyName = "FullName", Width = 180 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClass", HeaderText = "Class", DataPropertyName = "ClassSection", Width = 100 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGender", HeaderText = "Gender", DataPropertyName = "GenderText", Width = 70 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDOB", HeaderText = "Date of Birth", DataPropertyName = "DateOfBirth", Width = 110 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPhone", HeaderText = "Phone", DataPropertyName = "Phone", Width = 110 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGuardian", HeaderText = "Guardian", DataPropertyName = "GuardianName", Width = 130 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Status", DataPropertyName = "StatusText", Width = 80 });
            dgvStudents.Columns.Add(new DataGridViewButtonColumn { Name = "colEdit", HeaderText = "Edit", Text = "Edit", UseColumnTextForButtonValue = true, Width = 60 });
            dgvStudents.Columns.Add(new DataGridViewButtonColumn { Name = "colDelete", HeaderText = "Delete", Text = "Delete", UseColumnTextForButtonValue = true, Width = 60 });
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _allStudents = _service.GetAll();
                dgvStudents.DataSource = _allStudents;
                lblCount.Text = $"Total: {_allStudents.Rows.Count} students";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string kw = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(kw))
            {
                dgvStudents.DataSource = _allStudents;
                return;
            }
            var dv = _allStudents.DefaultView;
            dv.RowFilter = $"AdmissionNo LIKE \'%{kw}%\' OR FullName LIKE \'%{kw}%\' OR GuardianName LIKE \'%{kw}%\'";
            dgvStudents.DataSource = dv.ToTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmStudentAddEdit(0);
            if (frm.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int studentId = Convert.ToInt32(dgvStudents.Rows[e.RowIndex].Cells["colAdmNo"].Value);
            if (dgvStudents.Columns[e.ColumnIndex].Name == "colEdit")
            {
                var frm = new frmStudentAddEdit(studentId);
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
            else if (dgvStudents.Columns[e.ColumnIndex].Name == "colDelete")
            {
                if (MessageBox.Show("Delete this student?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _service.Delete(studentId);
                    LoadData();
                }
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog { Filter = "CSV files (*.csv)|*.csv", FileName = "Students.csv" };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (var sw = new StreamWriter(sfd.FileName))
            {
                sw.WriteLine("AdmissionNo,FullName,Class,Gender,DateOfBirth,Phone,Guardian,Status");
                foreach (DataRow r in _allStudents.Rows)
                {
                    sw.WriteLine($"{r["AdmissionNo"]},{r["FullName"]},{r["ClassSection"]},{r["GenderText"]},{r["DateOfBirth"]},{r["Phone"]},{r["GuardianName"]},{r["StatusText"]}");
                }
            }
            MessageBox.Show("Exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
