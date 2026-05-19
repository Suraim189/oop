using System;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;
using EduNova.Domain.Enums;

namespace EduNova.WinForms.Forms.Exams
{
    public partial class frmExams : Form
    {
        private readonly ExamService _svc = new ExamService();
        private readonly ClassSectionService _csSvc = new ClassSectionService();
        private readonly SubjectService _subSvc = new SubjectService();
        private DataTable _allExams;

        public frmExams()
        {
            InitializeComponent();
            Load += frmExams_Load;
            Theme.StyleDataGridView(dgvExams);
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvExams.Columns.Clear();
            dgvExams.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Exam Name", Width = 150, DataPropertyName = "ExamName" });
            dgvExams.Columns.Add(new DataGridViewTextBoxColumn { Name = "colType", HeaderText = "Type", Width = 100, DataPropertyName = "ExamType" });
            dgvExams.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClass", HeaderText = "Class", Width = 130, DataPropertyName = "ClassSection" });
            dgvExams.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSubject", HeaderText = "Subject", Width = 130, DataPropertyName = "SubjectName" });
            dgvExams.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDate", HeaderText = "Date", Width = 100, DataPropertyName = "ExamDate" });
        }

        private void frmExams_Load(object sender, EventArgs e)
        {
            try
            {
                _allExams = _svc.GetAll(); dgvExams.DataSource = _allExams; lblCount.Text = $"Total: {_allExams.Rows.Count}";
                var cl = _csSvc.GetAll(); cmbClass.DataSource = cl; cmbClass.DisplayMember = "DisplayName"; cmbClass.ValueMember = "ClassSectionId";
                var sb = _subSvc.GetAll(); cmbSubject.DataSource = sb; cmbSubject.DisplayMember = "SubjectName"; cmbSubject.ValueMember = "SubjectId";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            try
            {
                var et = (ExamType)(cmbExamType.SelectedIndex + 1);
                _svc.CreateExam(txtExamName.Text, et, (int)cmbClass.SelectedValue, (int)cmbSubject.SelectedValue, dtpExamDate.Value, (int)numTotalMarks.Value);
                _allExams = _svc.GetAll(); dgvExams.DataSource = _allExams; lblCount.Text = $"Total: {_allExams.Rows.Count}";
                MessageBox.Show("Exam saved!", "Success");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnDeleteExam_Click(object sender, EventArgs e)
        {
            if (dgvExams.CurrentRow == null || dgvExams.CurrentRow.DataBoundItem == null)
                return;
            var row = (DataRowView)dgvExams.CurrentRow.DataBoundItem;
            int examId = Convert.ToInt32(row["ExamId"]);
            if (MessageBox.Show("Delete this exam?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            try
            {
                _svc.DeleteExam(examId);
                _allExams = _svc.GetAll();
                dgvExams.DataSource = _allExams;
                lblCount.Text = $"Total: {_allExams.Rows.Count}";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            CsvExporter.ExportDataTable(_allExams, "exams.csv");
        }
    }
}
