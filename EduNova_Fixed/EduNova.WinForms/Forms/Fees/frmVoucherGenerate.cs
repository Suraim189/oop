using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Fees
{
    public partial class frmVoucherGenerate : Form
    {
        private readonly FeeService _svc = new FeeService();
        private readonly ClassSectionService _csSvc = new ClassSectionService();
        private DataTable _vouchers;
        public frmVoucherGenerate() { InitializeComponent(); Load += frmVoucherGenerate_Load; Theme.StyleDataGridView(dgvMain); SetupGrid(); }
        private void SetupGrid()
        {
            dgvMain.Columns.Clear();
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStudent", HeaderText = "Student", Width = 140, DataPropertyName = "StudentName" });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClass", HeaderText = "Class", Width = 120, DataPropertyName = "ClassSectionId" });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMonth", HeaderText = "Month", Width = 70, DataPropertyName = "Month" });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colYear", HeaderText = "Year", Width = 50, DataPropertyName = "Year" });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAmount", HeaderText = "Amount", Width = 90, DataPropertyName = "TotalAmount" });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDue", HeaderText = "Due Date", Width = 90, DataPropertyName = "DueDate" });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Status", Width = 70, DataPropertyName = "StatusName" });
        }
        private void frmVoucherGenerate_Load(object sender, EventArgs e) { try { var cl = _csSvc.GetAll(); cmbClassSection.DataSource = cl; cmbClassSection.DisplayMember = "DisplayName"; cmbClassSection.ValueMember = "ClassSectionId"; } catch { } }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMonth.SelectedItem == null)
                    return;
                int? classId = cmbClassSection.SelectedValue == null ? (int?)null : Convert.ToInt32(cmbClassSection.SelectedValue);
                string monthName = cmbMonth.SelectedItem.ToString();
                int year = (int)numYear.Value;
                int month = DateTime.ParseExact(monthName, "MMMM", CultureInfo.InvariantCulture).Month;
                int dueDay = Math.Min(10, DateTime.DaysInMonth(year, month));
                var dueDate = new DateTime(year, month, dueDay);
                int count = _svc.GenerateVouchers(classId, monthName, year, dueDate);
                _vouchers = _svc.GetVouchers();
                dgvMain.DataSource = _vouchers;
                lblCount.Text = $"Generated: {count} vouchers";
                MessageBox.Show($"{count} vouchers generated!", "Success");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

    }
}
