namespace EduNova.WinForms.Forms.Timetable
{
    partial class frmReplaceTeacherWizard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblOldTeacher; private System.Windows.Forms.ComboBox cmbOldTeacher;
        private System.Windows.Forms.Label lblNewTeacher; private System.Windows.Forms.ComboBox cmbNewTeacher;
        private System.Windows.Forms.Button btnPreview; private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.Label lblTitle2;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // lblTitle2
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle2.Location = new System.Drawing.Point(20, 12);
            this.lblTitle2.Size = new System.Drawing.Size(300, 22);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Text = "Replace Teacher Wizard";
            this.lblTitle2.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.lblTitle2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblTitle2.BackColor = System.Drawing.Color.Transparent;
            // lblOldTeacher
            this.lblOldTeacher = new System.Windows.Forms.Label();
            this.lblOldTeacher.Location = new System.Drawing.Point(20, 40);
            this.lblOldTeacher.Size = new System.Drawing.Size(150, 20);
            this.lblOldTeacher.Name = "lblOldTeacher";
            this.lblOldTeacher.Text = "Old Teacher";
            this.lblOldTeacher.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblOldTeacher.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblOldTeacher.BackColor = System.Drawing.Color.Transparent;
            this.cmbOldTeacher = new System.Windows.Forms.ComboBox(); this.cmbOldTeacher.Location = new System.Drawing.Point(20, 62); this.cmbOldTeacher.Size = new System.Drawing.Size(300, 25); this.cmbOldTeacher.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.cmbOldTeacher.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.cmbOldTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // lblNewTeacher
            this.lblNewTeacher = new System.Windows.Forms.Label();
            this.lblNewTeacher.Location = new System.Drawing.Point(20, 92);
            this.lblNewTeacher.Size = new System.Drawing.Size(150, 20);
            this.lblNewTeacher.Name = "lblNewTeacher";
            this.lblNewTeacher.Text = "New Teacher";
            this.lblNewTeacher.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblNewTeacher.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblNewTeacher.BackColor = System.Drawing.Color.Transparent;
            this.cmbNewTeacher = new System.Windows.Forms.ComboBox(); this.cmbNewTeacher.Location = new System.Drawing.Point(20, 114); this.cmbNewTeacher.Size = new System.Drawing.Size(300, 25); this.cmbNewTeacher.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.cmbNewTeacher.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.cmbNewTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // btnPreview
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPreview.Location = new System.Drawing.Point(20, 150);
            this.btnPreview.Size = new System.Drawing.Size(160, 36);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Text = "Preview Changes";
            this.btnPreview.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnPreview.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnPreview.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.FlatAppearance.BorderSize = 0;
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // btnReplace
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplace.Location = new System.Drawing.Point(190, 150);
            this.btnReplace.Size = new System.Drawing.Size(160, 36);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Text = "Replace";
            this.btnReplace.BackColor = System.Drawing.ColorTranslator.FromHtml("#7B2D2D");
            this.btnReplace.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFB3B3");
            this.btnReplace.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplace.FlatAppearance.BorderSize = 0;
            this.btnReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            this.dgvPreview = new System.Windows.Forms.DataGridView(); this.dgvPreview.Location = new System.Drawing.Point(20, 200); this.dgvPreview.Size = new System.Drawing.Size(640, 260);
            this.dgvPreview.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.dgvPreview.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030"); this.dgvPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPreview.AutoGenerateColumns = false; this.dgvPreview.ReadOnly = true; this.dgvPreview.RowHeadersVisible = false; this.dgvPreview.AllowUserToAddRows = false; this.dgvPreview.EnableHeadersVisualStyles = false; this.dgvPreview.ColumnHeadersHeight = 38; this.dgvPreview.RowTemplate.Height = 34;

            this.SuspendLayout();
            this.Controls.Add(this.lblTitle2); this.Controls.Add(this.lblOldTeacher); this.Controls.Add(this.cmbOldTeacher);
            this.Controls.Add(this.lblNewTeacher); this.Controls.Add(this.cmbNewTeacher);
            this.Controls.Add(this.btnPreview); this.Controls.Add(this.btnReplace); this.Controls.Add(this.dgvPreview);

            // frmReplaceTeacherWizard
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmReplaceTeacherWizard";
            this.Text = "EduNova - Replace Teacher";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}