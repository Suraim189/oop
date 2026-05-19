namespace EduNova.WinForms.Forms.Fees
{
    partial class frmFeeStructure
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnSave;
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
            this.lblTitle.Size = new System.Drawing.Size(400, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Fee Structure";
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
            // btnSave
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSave.Location = new System.Drawing.Point(650, 14);
            this.btnSave.Size = new System.Drawing.Size(130, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Save Structure";
            this.btnSave.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnSave.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnSave.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.SuspendLayout();
            this.Controls.Add(this.dgvMain); this.Controls.Add(this.pnlTop); this.Controls.Add(this.pnlBottom);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Name = "frmFeeStructure";
            this.Text = "EduNova - Fee Structure";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}