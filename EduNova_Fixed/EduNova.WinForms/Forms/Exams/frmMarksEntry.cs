using System;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Exams
{
    public partial class frmMarksEntry : Form
    {
        private readonly ExamService _svc = new ExamService();
        private DataTable _students;
        private int _examId;
        private int _totalMarks;
        public frmMarksEntry() { InitializeComponent(); Load += frmMarksEntry_Load; Theme.StyleDataGridView(dgvMain); SetupGrid(); }
        private void SetupGrid()
        {
            dgvMain.Columns.Clear();
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Student Name", Width = 200, ReadOnly = true });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRoll", HeaderText = "Roll No", Width = 80, ReadOnly = true });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colObtained", HeaderText = "Obtained Marks", Width = 150, ReadOnly = false });
        }
        private void frmMarksEntry_Load(object sender, EventArgs e) { try { var exams = _svc.GetAll(); cmbExam.DataSource = exams; cmbExam.DisplayMember = "ExamName"; cmbExam.ValueMember = "ExamId"; } catch { } }
        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            try { _examId = (int)cmbExam.SelectedValue; var dt = _svc.GetStudentsForMarks(_examId); _totalMarks = Convert.ToInt32(((DataTable)cmbExam.DataSource).Rows[cmbExam.SelectedIndex]["TotalMarks"]); lblExamInfo.Text = $"Total Marks: {_totalMarks}"; dgvMain.DataSource = dt; _students = dt; lblCount.Text = $"Students: {dt.Rows.Count}"; }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
        private void btnSaveMarks_Click(object sender, EventArgs e)
        {
            try { foreach (DataGridViewRow row in dgvMain.Rows) { int studentId = Convert.ToInt32(_students.Rows[row.Index]["StudentId"]); int obtained = Convert.ToInt32(row.Cells["colObtained"].Value ?? 0); _svc.SaveMarks(_examId, studentId, obtained); } MessageBox.Show("Marks saved!", "Success"); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

    }
}
