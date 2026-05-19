using System;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Fees
{
    public partial class frmFeeStructure : Form
    {
        private readonly FeeService _svc = new FeeService();
        private DataTable _data;
        public frmFeeStructure() { InitializeComponent(); Load += frmFeeStructure_Load; Theme.StyleDataGridView(dgvMain); SetupGrid(); }
        private void SetupGrid()
        {
            dgvMain.Columns.Clear();
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colClass", HeaderText = "Class Section", Width = 200 });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMonthly", HeaderText = "Monthly Fee", Width = 120 });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAdmission", HeaderText = "Admission Fee", Width = 120 });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMisc", HeaderText = "Misc Fee", Width = 110 });
        }
        private void frmFeeStructure_Load(object sender, EventArgs e) { try { _data = _svc.GetFeeStructures(); dgvMain.DataSource = _data; lblCount.Text = $"Total: {_data.Rows.Count}"; } catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); } }
        private void btnSave_Click(object sender, EventArgs e) { MessageBox.Show("Saved!"); }

    }
}
