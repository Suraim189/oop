namespace EduNova.WinForms.Forms.Timetable
{
    partial class frmTimetableClassView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbClass; private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Button btnLoad; private System.Windows.Forms.DataGridView dgvTimetable;
        private System.Windows.Forms.Panel pnlTop;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbClass = new System.Windows.Forms.ComboBox(); this.cmbClass.Location = new System.Drawing.Point(12, 17); this.cmbClass.Size = new System.Drawing.Size(200, 25); this.cmbClass.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.cmbClass.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.cmbClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDay = new System.Windows.Forms.ComboBox(); this.cmbDay.Location = new System.Drawing.Point(220, 17); this.cmbDay.Size = new System.Drawing.Size(120, 25); this.cmbDay.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.cmbDay.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8"); this.cmbDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.cmbDay.Items.AddRange(new object[]{"Monday","Tuesday","Wednesday","Thursday","Friday"}); this.cmbDay.SelectedIndex = 0;
            // btnLoad
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLoad.Location = new System.Drawing.Point(350, 14);
            this.btnLoad.Size = new System.Drawing.Size(100, 34);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Text = "Load";
            this.btnLoad.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnLoad.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnLoad.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.pnlTop = new System.Windows.Forms.Panel(); this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top; this.pnlTop.Height = 60; this.pnlTop.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.pnlTop.Controls.Add(this.cmbClass); this.pnlTop.Controls.Add(this.cmbDay); this.pnlTop.Controls.Add(this.btnLoad);
            this.dgvTimetable = new System.Windows.Forms.DataGridView(); this.dgvTimetable.Dock = System.Windows.Forms.DockStyle.Fill; this.dgvTimetable.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14"); this.dgvTimetable.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030"); this.dgvTimetable.BorderStyle = System.Windows.Forms.BorderStyle.None; this.dgvTimetable.AutoGenerateColumns = false; this.dgvTimetable.ReadOnly = true; this.dgvTimetable.RowHeadersVisible = false; this.dgvTimetable.AllowUserToAddRows = false; this.dgvTimetable.EnableHeadersVisualStyles = false; this.dgvTimetable.ColumnHeadersHeight = 38; this.dgvTimetable.RowTemplate.Height = 34;

            this.SuspendLayout();
            this.Controls.Add(this.dgvTimetable); this.Controls.Add(this.pnlTop);

            // frmTimetableClassView
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmTimetableClassView";
            this.Text = "EduNova - Class Timetable";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}