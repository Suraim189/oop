namespace EduNova.WinForms.Forms.AdminSecurity
{
    partial class frmUsers
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel pnlBottom;

        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // lblTitle
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Size = new System.Drawing.Size(350, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Users";
            this.lblTitle.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            // txtSearch
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtSearch.Location = new System.Drawing.Point(380, 17);
            this.txtSearch.Size = new System.Drawing.Size(280, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218");
            this.txtSearch.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtSearch.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // btnAdd
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdd.Location = new System.Drawing.Point(690, 14);
            this.btnAdd.Size = new System.Drawing.Size(140, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "+ Add";
            this.btnAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnAdd.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnAdd.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // btnExportCSV
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnExportCSV.Location = new System.Drawing.Point(850, 14);
            this.btnExportCSV.Size = new System.Drawing.Size(100, 34);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Text = "Export";
            this.btnExportCSV.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A3A25");
            this.btnExportCSV.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnExportCSV.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.FlatAppearance.BorderSize = 0;
            this.btnExportCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // pnlTop
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 60;
            this.pnlTop.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.btnAdd);
            this.pnlTop.Controls.Add(this.btnExportCSV);
            // dgvMain
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvMain.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030");
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.AutoGenerateColumns = false; this.dgvMain.ReadOnly = true;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.RowHeadersVisible = false; this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.EnableHeadersVisualStyles = false; this.dgvMain.ColumnHeadersHeight = 38;
            this.dgvMain.RowTemplate.Height = 34;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // lblCount
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCount.Text = "Total: 0";
            this.lblCount.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9f);
            this.lblCount.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            // pnlBottom
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom; this.pnlBottom.Height = 30;
            this.pnlBottom.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.pnlBottom.Controls.Add(this.lblCount);

            this.SuspendLayout();
            this.Controls.Add(this.dgvMain); this.Controls.Add(this.pnlTop); this.Controls.Add(this.pnlBottom);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 640);
            this.Name = "frmUsers";
            this.Text = "EduNova - Users";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}