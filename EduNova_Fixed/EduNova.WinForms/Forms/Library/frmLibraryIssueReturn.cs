using System;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;

namespace EduNova.WinForms.Forms.Library
{
    public partial class frmLibraryIssueReturn : Form
    {
        private readonly LibraryService _svc = new LibraryService();
        private DataTable _issued;
        public frmLibraryIssueReturn() { InitializeComponent(); Load += frmLibraryIssueReturn_Load; Theme.StyleDataGridView(dgvMain); Theme.StyleDataGridView(dgvIssuedBooks); SetupGrid(); }
        private void SetupGrid()
        {
            dgvIssuedBooks.Columns.Clear();
            dgvIssuedBooks.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStudent", HeaderText = "Student", Width = 160 });
            dgvIssuedBooks.Columns.Add(new DataGridViewTextBoxColumn { Name = "colBook", HeaderText = "Book", Width = 180 });
            dgvIssuedBooks.Columns.Add(new DataGridViewTextBoxColumn { Name = "colIssued", HeaderText = "Issued On", Width = 100 });
            dgvIssuedBooks.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDue", HeaderText = "Due Date", Width = 100 });
            dgvIssuedBooks.Columns.Add(new DataGridViewTextBoxColumn { Name = "colFine", HeaderText = "Fine", Width = 90 });
        }
        private void frmLibraryIssueReturn_Load(object sender, EventArgs e) { LoadIssued(); }
        private void LoadIssued() { try { _issued = _svc.GetIssuedBooks(); dgvIssuedBooks.DataSource = _issued; } catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); } }
        private void btnIssueBook_Click(object sender, EventArgs e) { try { MessageBox.Show("Issue functionality!"); } catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); } }
        private void btnReturnSelected_Click(object sender, EventArgs e) { try { if (dgvIssuedBooks.CurrentRow == null) return; int issueId = Convert.ToInt32(_issued.Rows[dgvIssuedBooks.CurrentRow.Index]["IssueId"]); _svc.ReturnBook(issueId); MessageBox.Show("Book returned!"); LoadIssued(); } catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); } }

    }
}
