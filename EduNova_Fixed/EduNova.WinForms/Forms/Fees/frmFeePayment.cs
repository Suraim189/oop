using System;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Fees
{
    public partial class frmFeePayment : Form
    {
        private readonly FeeService _svc = new FeeService();
        private DataTable _vouchers;

        public frmFeePayment()
        {
            InitializeComponent();
            Load += frmFeePayment_Load;
            Theme.StyleDataGridView(dgvPendingVouchers);
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvPendingVouchers.Columns.Clear();
            dgvPendingVouchers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStudent", HeaderText = "Student", Width = 160, DataPropertyName = "StudentName" });
            dgvPendingVouchers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAdmission", HeaderText = "Admission #", Width = 100, DataPropertyName = "AdmissionNo" });
            dgvPendingVouchers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMonth", HeaderText = "Month", Width = 80, DataPropertyName = "Month" });
            dgvPendingVouchers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colYear", HeaderText = "Year", Width = 60, DataPropertyName = "Year" });
            dgvPendingVouchers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAmount", HeaderText = "Amount", Width = 110, DataPropertyName = "TotalAmount" });
            dgvPendingVouchers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDue", HeaderText = "Due Date", Width = 100, DataPropertyName = "DueDate" });
            dgvPendingVouchers.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Status", Width = 80, DataPropertyName = "StatusName" });
        }

        private void frmFeePayment_Load(object sender, EventArgs e)
        {
            try
            {
                _vouchers = _svc.GetVouchers();
                dgvPendingVouchers.DataSource = _vouchers;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void txtSearchStudent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            btnSearch_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                _vouchers = _svc.SearchStudentVouchers(txtSearchStudent.Text.Trim());
                dgvPendingVouchers.DataSource = _vouchers;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void dgvPendingVouchers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPendingVouchers.CurrentRow == null) return;
            var r = dgvPendingVouchers.CurrentRow;
            // @ symbol lagane se tum multiple lines use kar sakte ho
            lblSelectedVoucher.Text = $@"Student: {r.Cells["colStudent"].Value}
            Month: {r.Cells["colMonth"].Value} {r.Cells["colYear"].Value}
            Amount: {r.Cells["colAmount"].Value}";
            // Ye line as it is neechay rahegi
            if (decimal.TryParse(r.Cells["colAmount"].Value?.ToString(), out var amount))
                numPaidAmount.Value = amount;
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            try
            {
                int voucherId = Convert.ToInt32(_vouchers.Rows[dgvPendingVouchers.CurrentRow.Index]["VoucherId"]);
                _svc.PayVoucher(voucherId, numPaidAmount.Value, cmbPaymentMethod.SelectedIndex + 1, AppState.CurrentUser?.UserId ?? 1);
                MessageBox.Show("Payment recorded!", "Success"); btnSearch_Click(sender, e);
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}
