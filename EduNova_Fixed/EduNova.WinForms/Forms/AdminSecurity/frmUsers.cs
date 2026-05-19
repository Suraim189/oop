using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.AdminSecurity
{
    public partial class frmUsers : Form
    {
        private readonly AdminService _service = new AdminService();
        private DataTable _allData;

        public frmUsers()
        {
            InitializeComponent();
            Load += frmUsers_Load;
            Theme.StyleDataGridView(dgvMain);
            txtSearch.KeyUp += txtSearch_KeyUp;
        }

        private void frmUsers_Load(object sender, EventArgs e) { LoadData(); }

        private void LoadData()
        {
            try { _allData = _service.GetAll(); dgvMain.DataSource = _allData; lblCount.Text = $"Total: {_allData.Rows.Count}"; SetupColumns(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void SetupColumns()
        {
            dgvMain.Columns.Clear();
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colUsername", HeaderText = "Username", DataPropertyName = "Username", Width = 130 });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDisplay", HeaderText = "Display Name", DataPropertyName = "Display", Width = 160 });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRole", HeaderText = "Role", DataPropertyName = "Role", Width = 100 });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colActive", HeaderText = "Active", DataPropertyName = "Active", Width = 70 });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCreated", HeaderText = "Created At", DataPropertyName = "Created", Width = 130 });
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string kw = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(kw)) { dgvMain.DataSource = _allData; return; }
            var dv = _allData.DefaultView; dv.RowFilter = $"* LIKE \'%{kw}%\'";
            dgvMain.DataSource = dv.ToTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add functionality coming soon!");
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog { Filter = "CSV|*.csv" };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (var sw = new StreamWriter(sfd.FileName))
            {
                for (int i = 0; i < dgvMain.Columns.Count - 2; i++) sw.Write(dgvMain.Columns[i].HeaderText + ",");
                sw.WriteLine();
                foreach (DataGridViewRow row in dgvMain.Rows)
                {
                    for (int i = 0; i < dgvMain.Columns.Count - 2; i++) sw.Write(row.Cells[i].Value + ",");
                    sw.WriteLine();
                }
            }
            MessageBox.Show("Exported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
