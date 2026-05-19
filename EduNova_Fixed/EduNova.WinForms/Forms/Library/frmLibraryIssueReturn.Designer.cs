using System;

namespace EduNova.WinForms.Forms.Library
{
    partial class frmLibraryIssueReturn
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TabControl tabControl; private System.Windows.Forms.TabPage tabIssue; private System.Windows.Forms.TabPage tabReturn; private System.Windows.Forms.TextBox txtSearchStudent; private System.Windows.Forms.TextBox txtSearchBook; private System.Windows.Forms.DateTimePicker dtpDueDate; private System.Windows.Forms.Button btnIssueBook; private System.Windows.Forms.DataGridView dgvIssuedBooks; private System.Windows.Forms.Button btnReturnSelected;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // lblTitle
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Issue/Return Books";
            this.lblTitle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            // pnlTop
            this.pnlTop = new System.Windows.Forms.Panel(); this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top; this.pnlTop.Height = 60;
            this.pnlTop.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.pnlTop.Controls.Add(this.lblTitle);
            // dgvMain
            this.dgvMain = new System.Windows.Forms.DataGridView(); this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Name = "dgvMain"; this.dgvMain.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvMain.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030"); this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.AutoGenerateColumns = false; this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false; this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.EnableHeadersVisualStyles = false; this.dgvMain.ColumnHeadersHeight = 38;
            this.dgvMain.RowTemplate.Height = 34;
            // lblCount
            this.lblCount = new System.Windows.Forms.Label(); this.lblCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCount.Text = "Total: 0"; this.lblCount.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9f);
            this.lblCount.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            // pnlBottom
            this.pnlBottom = new System.Windows.Forms.Panel(); this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom; this.pnlBottom.Height = 30;
            this.pnlBottom.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.pnlBottom.Controls.Add(this.lblCount);
            this.tabControl = new System.Windows.Forms.TabControl(); this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabIssue = new System.Windows.Forms.TabPage("Issue Book"); this.tabReturn = new System.Windows.Forms.TabPage("Return Book");
            this.txtSearchStudent = new System.Windows.Forms.TextBox(); this.txtSearchStudent.Location = new System.Drawing.Point(12, 12); this.txtSearchStudent.Size = new System.Drawing.Size(250, 25); this.txtSearchStudent.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.txtSearchStudent.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.txtSearchStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBook = new System.Windows.Forms.TextBox(); this.txtSearchBook.Location = new System.Drawing.Point(12, 44); this.txtSearchBook.Size = new System.Drawing.Size(250, 25); this.txtSearchBook.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.txtSearchBook.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.txtSearchBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker(); this.dtpDueDate.Location = new System.Drawing.Point(12, 76); this.dtpDueDate.Size = new System.Drawing.Size(250, 25); this.dtpDueDate.Value = DateTime.Now.AddDays(14);
            this.btnIssueBook = new System.Windows.Forms.Button(); this.btnIssueBook.Text = "Issue Book"; this.btnIssueBook.Location = new System.Drawing.Point(12, 112); this.btnIssueBook.Size = new System.Drawing.Size(160, 36); this.btnIssueBook.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C"); this.btnIssueBook.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.btnIssueBook.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold); this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnIssueBook.FlatAppearance.BorderSize = 0; this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            this.tabIssue.Controls.Add(this.txtSearchStudent); this.tabIssue.Controls.Add(this.txtSearchBook); this.tabIssue.Controls.Add(this.dtpDueDate); this.tabIssue.Controls.Add(this.btnIssueBook);
            this.dgvIssuedBooks = new System.Windows.Forms.DataGridView(); this.dgvIssuedBooks.Dock = System.Windows.Forms.DockStyle.Top; this.dgvIssuedBooks.Height = 420;
            this.dgvIssuedBooks.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.dgvIssuedBooks.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030");
            this.dgvIssuedBooks.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvIssuedBooks.AutoGenerateColumns = false; this.dgvIssuedBooks.ReadOnly = true;
            this.dgvIssuedBooks.RowHeadersVisible = false; this.dgvIssuedBooks.AllowUserToAddRows = false; this.dgvIssuedBooks.EnableHeadersVisualStyles = false;
            this.btnReturnSelected = new System.Windows.Forms.Button(); this.btnReturnSelected.Text = "Return Selected"; this.btnReturnSelected.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReturnSelected.Height = 40; this.btnReturnSelected.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C"); this.btnReturnSelected.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.btnReturnSelected.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold); this.btnReturnSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnReturnSelected.FlatAppearance.BorderSize = 0; this.btnReturnSelected.Click += new System.EventHandler(this.btnReturnSelected_Click);
            this.tabReturn.Controls.Add(this.dgvIssuedBooks); this.tabReturn.Controls.Add(this.btnReturnSelected);
            this.tabControl.TabPages.Add(this.tabIssue); this.tabControl.TabPages.Add(this.tabReturn);
            this.Controls.Add(this.tabControl);

            this.SuspendLayout();
            this.Controls.Add(this.tabControl);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "frmLibraryIssueReturn";
            this.Text = "EduNova - Issue/Return Books";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}