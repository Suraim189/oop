using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Library
{
    public partial class frmLibraryBooks : Form
    {
        private readonly LibraryService _service = new LibraryService();
        private DataTable _allData;

        public frmLibraryBooks()
        {
            InitializeComponent();
            Load += frmLibraryBooks_Load;
            Theme.StyleDataGridView(dgvMain);
            txtSearch.KeyUp += txtSearch_KeyUp;
        }

        private void frmLibraryBooks_Load(object sender, EventArgs e) { LoadData(); }

        private void LoadData()
        {
            try { _allData = _service.GetAll(); dgvMain.DataSource = _allData; lblCount.Text = $"Total: {_allData.Rows.Count}"; SetupColumns(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void SetupColumns()
        {
            dgvMain.Columns.Clear();
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTitle", HeaderText = "Title", DataPropertyName = "Title", Width = 200 });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colISBN", HeaderText = "ISBN", DataPropertyName = "ISBN", Width = 110 });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAuthor", HeaderText = "Author", DataPropertyName = "Author", Width = 140 });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCategory", HeaderText = "Category", DataPropertyName = "Category", Width = 110 });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCopies", HeaderText = "Available", DataPropertyName = "Copies", Width = 80 });
            dgvMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Status", DataPropertyName = "Status", Width = 80 });
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
