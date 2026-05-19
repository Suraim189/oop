using System;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Exams
{
    public partial class frmResultCard : Form
    {
        private readonly ExamService _svc = new ExamService();
        private readonly StudentService _stuSvc = new StudentService();
        private readonly ClassSectionService _csSvc = new ClassSectionService();

        public frmResultCard()
        {
            InitializeComponent();
            Load += frmResultCard_Load;
            Theme.StyleDataGridView(dgvResults);
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvResults.Columns.Clear();
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSubject", HeaderText = "Subject", Width = 200, DataPropertyName = "SubjectName" });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "Total Marks", Width = 120, DataPropertyName = "TotalMarks" });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "colObtained", HeaderText = "Obtained", Width = 120, DataPropertyName = "ObtainedMarks" });
            dgvResults.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGrade", HeaderText = "Grade", Width = 120, DataPropertyName = "Grade" });
        }

        private void frmResultCard_Load(object sender, EventArgs e)
        {
            try
            {
                var ex = _svc.GetAll();
                cmbExam.DataSource = ex;
                cmbExam.DisplayMember = "ExamName";
                cmbExam.ValueMember = "ExamId";
                var st = _stuSvc.GetAll();
                cmbStudent.DataSource = st;
                cmbStudent.DisplayMember = "FullName";
                cmbStudent.ValueMember = "StudentId";
            }
            catch { }
        }

        private void btnLoadResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbExam.SelectedValue == null || cmbStudent.SelectedValue == null)
                    return;
                int examId = (int)cmbExam.SelectedValue;
                int studentId = (int)cmbStudent.SelectedValue;
                var ds = _svc.GetResultReport(examId, studentId);
                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No result data found.");
                    return;
                }
                var info = ds.Tables[0].Rows[0];
                lblStudentName.Text = info["StudentName"].ToString();
                lblClass.Text = info["ClassSection"].ToString();
                lblExamName.Text = info["ExamName"].ToString();
                lblDate.Text = Convert.ToDateTime(info["ExamDate"]).ToString("dd MMM yyyy");

                var marks = ds.Tables.Count > 1 ? ds.Tables[1] : new DataTable();
                dgvResults.DataSource = marks;
                int totalObtained = 0, totalMarks = 0;
                foreach (DataRow r in marks.Rows)
                {
                    totalObtained += Convert.ToInt32(r["ObtainedMarks"]);
                    totalMarks += Convert.ToInt32(r["TotalMarks"]);
                }
                decimal pct = totalMarks > 0 ? (decimal)totalObtained / totalMarks * 100 : 0;
                lblOverallGrade.Text = "Grade: " + ExamService.CalculateGrade(totalObtained, totalMarks);
                lblPercentage.Text = $"Percentage: {pct:F1}%";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnPrint_Click(object sender, EventArgs e) { MessageBox.Show("Print preview would open here!"); }
    }
}
