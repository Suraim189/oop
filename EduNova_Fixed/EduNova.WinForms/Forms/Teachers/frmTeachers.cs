using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Teachers
{
    public partial class frmTeachers : Form
    {
        private readonly TeacherService _service = new TeacherService();
        private DataTable _allTeachers;

        public frmTeachers()
        {
            InitializeComponent();
            Load += frmTeachers_Load;
            Theme.StyleDataGridView(dgvTeachers);
            SetupColumns();
            txtSearch.KeyUp += txtSearch_KeyUp;
        }

        private void SetupColumns()
        {
            dgvTeachers.Columns.Clear();
            dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colEmpCode", HeaderText = "Emp Code", Width = 90 });
            dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Full Name", Width = 170 });
            dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPhone", HeaderText = "Phone", Width = 110 });
            dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colQual", HeaderText = "Qualification", Width = 140 });
            dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colJoining", HeaderText = "Joining Date", Width = 110 });
            dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSubjects", HeaderText = "Subjects", Width = 160 });
            dgvTeachers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Status", Width = 80 });
            dgvTeachers.Columns.Add(new DataGridViewButtonColumn { Name = "colEdit", HeaderText = "Edit", Text = "Edit", UseColumnTextForButtonValue = true, Width = 60 });
            dgvTeachers.Columns.Add(new DataGridViewButtonColumn { Name = "colDelete", HeaderText = "Delete", Text = "Delete", UseColumnTextForButtonValue = true, Width = 60 });
        }

        private void frmTeachers_Load(object sender, EventArgs e) { LoadData(); }
        private void LoadData()
        {
            try { _allTeachers = _service.GetAll(); dgvTeachers.DataSource = _allTeachers; lblCount.Text = $"Total: {_allTeachers.Rows.Count} teachers"; }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string kw = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(kw)) { dgvTeachers.DataSource = _allTeachers; return; }
            var dv = _allTeachers.DefaultView;
            dv.RowFilter = $"EmployeeCode LIKE \'%{kw}%\' OR FullName LIKE \'%{kw}%\'";
            dgvTeachers.DataSource = dv.ToTable();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmTeacherAddEdit(0);
            if (frm.ShowDialog() == DialogResult.OK) LoadData();
        }
        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(_allTeachers.Rows[e.RowIndex]["TeacherId"]);
            if (dgvTeachers.Columns[e.ColumnIndex].Name == "colEdit")
            { var frm = new frmTeacherAddEdit(id); if (frm.ShowDialog() == DialogResult.OK) LoadData(); }
            else if (dgvTeachers.Columns[e.ColumnIndex].Name == "colDelete")
            { if (MessageBox.Show("Delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes) { _service.Delete(id); LoadData(); } }
        }
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "Teachers.csv" };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (var sw = new StreamWriter(sfd.FileName)) { sw.WriteLine("EmpCode,FullName,Phone,Qualification,JoiningDate,Status"); foreach (DataRow r in _allTeachers.Rows) sw.WriteLine($"{r["EmployeeCode"]},{r["FullName"]},{r["Phone"]},{r["Qualification"]},{r["JoiningDate"]},{r["Status"]}"); }
            MessageBox.Show("Exported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
