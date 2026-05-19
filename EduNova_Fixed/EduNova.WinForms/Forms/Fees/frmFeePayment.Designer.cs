namespace EduNova.WinForms.Forms.Fees
{
    partial class frmFeePayment
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPendingVouchers;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblSelectedVoucher;
        private System.Windows.Forms.NumericUpDown numPaidAmount;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Button btnPayNow;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // pnlLeft
            this.pnlLeft = new System.Windows.Forms.Panel(); this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Width = 500; this.pnlLeft.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(12);
            // txtSearchStudent
            this.txtSearchStudent = new System.Windows.Forms.TextBox(); this.txtSearchStudent.Location = new System.Drawing.Point(12, 12);
            this.txtSearchStudent.Size = new System.Drawing.Size(340, 25); this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.txtSearchStudent.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.txtSearchStudent.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f); this.txtSearchStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchStudent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchStudent_KeyUp);
            // btnSearch
            this.btnSearch = new System.Windows.Forms.Button(); this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(360, 12); this.btnSearch.Size = new System.Drawing.Size(120, 25);
            this.btnSearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C"); this.btnSearch.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnSearch.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9f, System.Drawing.FontStyle.Bold); this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0; this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // dgvPendingVouchers
            this.dgvPendingVouchers = new System.Windows.Forms.DataGridView();
            this.dgvPendingVouchers.Location = new System.Drawing.Point(12, 48); this.dgvPendingVouchers.Size = new System.Drawing.Size(470, 520);
            this.dgvPendingVouchers.Name = "dgvPendingVouchers";
            this.dgvPendingVouchers.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvPendingVouchers.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030"); this.dgvPendingVouchers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPendingVouchers.AutoGenerateColumns = false; this.dgvPendingVouchers.ReadOnly = true;
            this.dgvPendingVouchers.RowHeadersVisible = false; this.dgvPendingVouchers.AllowUserToAddRows = false;
            this.dgvPendingVouchers.EnableHeadersVisualStyles = false; this.dgvPendingVouchers.ColumnHeadersHeight = 38;
            this.dgvPendingVouchers.RowTemplate.Height = 34;
            this.dgvPendingVouchers.SelectionChanged += new System.EventHandler(this.dgvPendingVouchers_SelectionChanged);
            this.pnlLeft.Controls.Add(this.txtSearchStudent); this.pnlLeft.Controls.Add(this.btnSearch);
            this.pnlLeft.Controls.Add(this.dgvPendingVouchers);
            // pnlRight
            this.pnlRight = new System.Windows.Forms.Panel(); this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.pnlRight.Padding = new System.Windows.Forms.Padding(20);
            // lblSelectedVoucher
            this.lblSelectedVoucher = new System.Windows.Forms.Label(); this.lblSelectedVoucher.Location = new System.Drawing.Point(20, 20);
            this.lblSelectedVoucher.Size = new System.Drawing.Size(400, 80); this.lblSelectedVoucher.Name = "lblSelectedVoucher";
            this.lblSelectedVoucher.Text = "Select a voucher to pay"; this.lblSelectedVoucher.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 10f);
            this.lblSelectedVoucher.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.lblSelectedVoucher.BackColor = System.Drawing.Color.Transparent;
            // numPaidAmount
            this.numPaidAmount = new System.Windows.Forms.NumericUpDown(); this.numPaidAmount.Location = new System.Drawing.Point(20, 120);
            this.numPaidAmount.Size = new System.Drawing.Size(400, 25); this.numPaidAmount.Name = "numPaidAmount";
            this.numPaidAmount.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A2E20"); this.numPaidAmount.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.numPaidAmount.Maximum = 1000000; this.numPaidAmount.Minimum = 0;
            // cmbPaymentMethod
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox(); this.cmbPaymentMethod.Location = new System.Drawing.Point(20, 160);
            this.cmbPaymentMethod.Size = new System.Drawing.Size(400, 25); this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A2E20"); this.cmbPaymentMethod.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.cmbPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPaymentMethod.Items.AddRange(new object[]{"Cash","Bank Transfer","Online"}); this.cmbPaymentMethod.SelectedIndex = 0;
            // btnPayNow
            this.btnPayNow = new System.Windows.Forms.Button(); this.btnPayNow.Text = "Mark as Paid";
            this.btnPayNow.Location = new System.Drawing.Point(20, 200); this.btnPayNow.Size = new System.Drawing.Size(400, 48);
            this.btnPayNow.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C"); this.btnPayNow.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnPayNow.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold); this.btnPayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayNow.FlatAppearance.BorderSize = 0; this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            this.pnlRight.Controls.Add(this.lblSelectedVoucher); this.pnlRight.Controls.Add(this.numPaidAmount);
            this.pnlRight.Controls.Add(this.cmbPaymentMethod); this.pnlRight.Controls.Add(this.btnPayNow);

            this.SuspendLayout();
            this.Controls.Add(this.pnlRight); this.Controls.Add(this.pnlLeft);

            // frmFeePayment
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmFeePayment";
            this.Text = "EduNova - Fee Payment";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}