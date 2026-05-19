namespace EduNova.WinForms.Forms.Students
{
    partial class frmStudents
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel pnlBottom;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 60;
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.btnAdd);
            this.pnlTop.Controls.Add(this.btnExportCSV);

            // lblTitle
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Size = new System.Drawing.Size(350, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Student Management";
            this.lblTitle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 16f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(380, 17);
            this.txtSearch.Size = new System.Drawing.Size(280, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtSearch.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtSearch.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(690, 14);
            this.btnAdd.Size = new System.Drawing.Size(140, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "+ Add Student";
            this.btnAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnAdd.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnAdd.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnExportCSV
            this.btnExportCSV.Location = new System.Drawing.Point(850, 14);
            this.btnExportCSV.Size = new System.Drawing.Size(120, 34);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A3A25");
            this.btnExportCSV.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnExportCSV.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.FlatAppearance.BorderSize = 0;
            this.btnExportCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);

            // dgvStudents
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvStudents.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030");
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudents.AutoGenerateColumns = false;
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.ColumnHeadersHeight = 38;
            this.dgvStudents.RowTemplate.Height = 34;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);

            // pnlBottom
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Height = 30;
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.pnlBottom.Controls.Add(this.lblCount);

            // lblCount
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCount.Name = "lblCount";
            this.lblCount.Text = "Total: 0 students";
            this.lblCount.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9f, System.Drawing.FontStyle.Regular);
            this.lblCount.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblCount.BackColor = System.Drawing.Color.Transparent;

            // frmStudents
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 640);
            this.Name = "frmStudents";
            this.Text = "EduNova - Students";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
