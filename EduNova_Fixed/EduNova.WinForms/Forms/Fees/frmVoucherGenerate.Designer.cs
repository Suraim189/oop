namespace EduNova.WinForms.Forms.Fees
{
    partial class frmVoucherGenerate
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ComboBox cmbClassSection; private System.Windows.Forms.ComboBox cmbMonth; private System.Windows.Forms.NumericUpDown numYear; private System.Windows.Forms.Button btnGenerate; private System.Windows.Forms.Label lblResult;
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
            this.lblTitle.Text = "Generate Vouchers";
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
            this.cmbClassSection = new System.Windows.Forms.ComboBox(); this.cmbClassSection.Location = new System.Drawing.Point(12, 17); this.cmbClassSection.Size = new System.Drawing.Size(180, 25); this.cmbClassSection.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.cmbClassSection.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.cmbClassSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMonth = new System.Windows.Forms.ComboBox(); this.cmbMonth.Location = new System.Drawing.Point(200, 17); this.cmbMonth.Size = new System.Drawing.Size(120, 25); this.cmbMonth.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.cmbMonth.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.cmbMonth.Items.AddRange(new object[]{"January","February","March","April","May","June","July","August","September","October","November","December"}); this.cmbMonth.SelectedIndex = 0;
            this.numYear = new System.Windows.Forms.NumericUpDown(); this.numYear.Location = new System.Drawing.Point(330, 17); this.numYear.Size = new System.Drawing.Size(80, 25); this.numYear.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.numYear.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.numYear.Maximum = 2100; this.numYear.Minimum = 2020; this.numYear.Value = 2026;
            this.pnlTop.Controls.Add(this.cmbClassSection); this.pnlTop.Controls.Add(this.cmbMonth); this.pnlTop.Controls.Add(this.numYear);
            this.pnlTop.Controls.Add(this.btnGenerate);            // btnGenerate
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnGenerate.Location = new System.Drawing.Point(420, 14);
            this.btnGenerate.Size = new System.Drawing.Size(120, 34);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnGenerate.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnGenerate.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            this.SuspendLayout();
            this.Controls.Add(this.dgvMain); this.Controls.Add(this.pnlTop); this.Controls.Add(this.pnlBottom);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Name = "frmVoucherGenerate";
            this.Text = "EduNova - Generate Vouchers";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}