using System;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.ClassesSections
{
    public partial class frmClasses : Form
    {
        private readonly ClassSectionService _svc = new ClassSectionService();
        private DataTable _classSections;
        private DataTable _gradeClasses;
        private DataTable _sections;
        public frmClasses() { InitializeComponent(); Load += frmClasses_Load; Theme.StyleDataGridView(dgvClasses); Theme.StyleDataGridView(dgvSections); }
        private void frmClasses_Load(object sender, EventArgs e) { LoadClasses(); SetupClassesGrid(); SetupSectionsGrid(); }
        private void SetupClassesGrid()
        {
            dgvClasses.Columns.Clear();
            dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClassName", HeaderText = "Class Name", Width = 150, DataPropertyName = "ClassName" });
            dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDesc", HeaderText = "Description", Width = 150, DataPropertyName = "Description" });
            dgvClasses.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSectionCount", HeaderText = "Sections", Width = 80, DataPropertyName = "SectionCount" });
        }
        private void SetupSectionsGrid()
        {
            dgvSections.Columns.Clear();
            dgvSections.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSecName", HeaderText = "Section", Width = 100, DataPropertyName = "SectionName" });
            dgvSections.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTeacher", HeaderText = "Class Teacher", Width = 150, DataPropertyName = "TeacherName" });
            dgvSections.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMax", HeaderText = "Max Students", Width = 100, DataPropertyName = "MaxStudents" });
            dgvSections.Columns.Add(new DataGridViewTextBoxColumn { Name = "colActive", HeaderText = "Active", Width = 60, DataPropertyName = "IsActive" });
        }
        private void LoadClasses()
        {
            _gradeClasses = _svc.GetClasses();
            _classSections = _svc.GetAll();
            _sections = _svc.GetSections();
            dgvClasses.DataSource = _gradeClasses;
            dgvSections.DataSource = null;
        }
        private void dgvClasses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow == null || dgvClasses.CurrentRow.DataBoundItem == null) return;
            var row = (DataRowView)dgvClasses.CurrentRow.DataBoundItem;
            int gradeClassId = Convert.ToInt32(row["GradeClassId"]);
            var dv = new DataView(_classSections) { RowFilter = $"GradeClassId = {gradeClassId}" };
            dgvSections.DataSource = dv;
        }
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Class Name:", "Add Class", "");
            string desc = Microsoft.VisualBasic.Interaction.InputBox("Description:", "Add Class", "");
            if (!string.IsNullOrWhiteSpace(name)) { _svc.InsertClass(name, desc); LoadClasses(); }
        }
        private void btnEditClass_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow == null || dgvClasses.CurrentRow.DataBoundItem == null) return;
            var row = (DataRowView)dgvClasses.CurrentRow.DataBoundItem;
            int classId = Convert.ToInt32(row["GradeClassId"]);
            string currentName = row["ClassName"].ToString();
            string currentDesc = row["Description"].ToString();
            string name = Microsoft.VisualBasic.Interaction.InputBox("Class Name:", "Edit Class", currentName);
            string desc = Microsoft.VisualBasic.Interaction.InputBox("Description:", "Edit Class", currentDesc);
            if (!string.IsNullOrWhiteSpace(name))
            {
                _svc.UpdateClass(classId, name, desc);
                LoadClasses();
            }
        }
        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow == null || dgvClasses.CurrentRow.DataBoundItem == null) return;
            var row = (DataRowView)dgvClasses.CurrentRow.DataBoundItem;
            int classId = Convert.ToInt32(row["GradeClassId"]);
            if (MessageBox.Show("Delete this class?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            _svc.DeleteClass(classId);
            LoadClasses();
        }
        private void btnAddSection_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow == null || dgvClasses.CurrentRow.DataBoundItem == null) return;
            var row = (DataRowView)dgvClasses.CurrentRow.DataBoundItem;
            int gradeClassId = Convert.ToInt32(row["GradeClassId"]);
            string secName = Microsoft.VisualBasic.Interaction.InputBox("Section Name (e.g. A, B):", "Add Section", "A");
            if (string.IsNullOrWhiteSpace(secName)) return;
            int maxStudents = 40;
            string maxStr = Microsoft.VisualBasic.Interaction.InputBox("Max Students:", "Add Section", "40");
            if (!int.TryParse(maxStr, out maxStudents)) maxStudents = 40;

            int sectionId = 0;
            foreach (DataRow s in _sections.Rows)
            {
                if (string.Equals(s["SectionName"].ToString(), secName, StringComparison.OrdinalIgnoreCase))
                {
                    sectionId = Convert.ToInt32(s["SectionId"]);
                    break;
                }
            }
            if (sectionId == 0)
            {
                MessageBox.Show("Section not found. Add it in the database first.");
                return;
            }
            _svc.InsertSection(gradeClassId, sectionId, maxStudents);
            LoadClasses();
        }
        private void btnDeleteSection_Click(object sender, EventArgs e)
        {
            if (dgvSections.CurrentRow == null || dgvSections.CurrentRow.DataBoundItem == null) return;
            var row = (DataRowView)dgvSections.CurrentRow.DataBoundItem;
            int classSectionId = Convert.ToInt32(row["ClassSectionId"]);
            if (MessageBox.Show("Delete this section?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            _svc.DeleteSection(classSectionId);
            LoadClasses();
        }
    }
}
