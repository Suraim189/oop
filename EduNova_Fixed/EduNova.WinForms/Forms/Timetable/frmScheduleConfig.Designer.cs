namespace EduNova.WinForms.Forms.Timetable
{
    partial class frmScheduleConfig
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSection1;
        private System.Windows.Forms.DateTimePicker dtpEffective;
        private System.Windows.Forms.Label lblStart; private System.Windows.Forms.DateTimePicker dtpSchoolStart;
        private System.Windows.Forms.Label lblEnd; private System.Windows.Forms.DateTimePicker dtpSchoolEnd;
        private System.Windows.Forms.Label lblLecture; private System.Windows.Forms.NumericUpDown numLectureMin;
        private System.Windows.Forms.Label lblBreak; private System.Windows.Forms.NumericUpDown numBreakMin;
        private System.Windows.Forms.Label lblBreakAfter; private System.Windows.Forms.NumericUpDown numBreakAfter;
        private System.Windows.Forms.Button btnSaveConfig; private System.Windows.Forms.Button btnRegenerate;
        private System.Windows.Forms.DataGridView dgvTimeSlots;
        private System.Windows.Forms.Label lblEffective;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            // lblSection1
            this.lblSection1 = new System.Windows.Forms.Label();
            this.lblSection1.Location = new System.Drawing.Point(20, 12);
            this.lblSection1.Size = new System.Drawing.Size(300, 22);
            this.lblSection1.Name = "lblSection1";
            this.lblSection1.Text = "School Schedule Configuration";
            this.lblSection1.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.lblSection1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.lblSection1.BackColor = System.Drawing.Color.Transparent;
            // lblEffective
            this.lblEffective = new System.Windows.Forms.Label();
            this.lblEffective.Location = new System.Drawing.Point(20, 40);
            this.lblEffective.Size = new System.Drawing.Size(150, 20);
            this.lblEffective.Name = "lblEffective";
            this.lblEffective.Text = "Effective From";
            this.lblEffective.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblEffective.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblEffective.BackColor = System.Drawing.Color.Transparent;
            // dtpEffective
            this.dtpEffective = new System.Windows.Forms.DateTimePicker();
            this.dtpEffective.Location = new System.Drawing.Point(20, 62);
            this.dtpEffective.Size = new System.Drawing.Size(250, 25);
            this.dtpEffective.Name = "dtpEffective";
            this.dtpEffective.CalendarForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.dtpEffective.CalendarMonthBackground = System.Drawing.ColorTranslator.FromHtml("#132218");
            // lblStart
            this.lblStart = new System.Windows.Forms.Label();
            this.lblStart.Location = new System.Drawing.Point(300, 40);
            this.lblStart.Size = new System.Drawing.Size(150, 20);
            this.lblStart.Name = "lblStart";
            this.lblStart.Text = "School Start";
            this.lblStart.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblStart.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            // dtpSchoolStart
            this.dtpSchoolStart = new System.Windows.Forms.DateTimePicker();
            this.dtpSchoolStart.Location = new System.Drawing.Point(300, 62);
            this.dtpSchoolStart.Size = new System.Drawing.Size(250, 25);
            this.dtpSchoolStart.Name = "dtpSchoolStart";
            this.dtpSchoolStart.CalendarForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.dtpSchoolStart.CalendarMonthBackground = System.Drawing.ColorTranslator.FromHtml("#132218");
            // lblEnd
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblEnd.Location = new System.Drawing.Point(20, 92);
            this.lblEnd.Size = new System.Drawing.Size(150, 20);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Text = "School End";
            this.lblEnd.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblEnd.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            // dtpSchoolEnd
            this.dtpSchoolEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpSchoolEnd.Location = new System.Drawing.Point(20, 114);
            this.dtpSchoolEnd.Size = new System.Drawing.Size(250, 25);
            this.dtpSchoolEnd.Name = "dtpSchoolEnd";
            this.dtpSchoolEnd.CalendarForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.dtpSchoolEnd.CalendarMonthBackground = System.Drawing.ColorTranslator.FromHtml("#132218");
            // lblLecture
            this.lblLecture = new System.Windows.Forms.Label();
            this.lblLecture.Location = new System.Drawing.Point(300, 92);
            this.lblLecture.Size = new System.Drawing.Size(150, 20);
            this.lblLecture.Name = "lblLecture";
            this.lblLecture.Text = "Lecture Duration (min)";
            this.lblLecture.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblLecture.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblLecture.BackColor = System.Drawing.Color.Transparent;
            // numLectureMin
            this.numLectureMin = new System.Windows.Forms.NumericUpDown();
            this.numLectureMin.Location = new System.Drawing.Point(300, 114); this.numLectureMin.Size = new System.Drawing.Size(200, 25);
            this.numLectureMin.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.numLectureMin.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.numLectureMin.Maximum = 120; this.numLectureMin.Minimum = 15; this.numLectureMin.Value = 40;
            // lblBreak
            this.lblBreak = new System.Windows.Forms.Label();
            this.lblBreak.Location = new System.Drawing.Point(20, 144);
            this.lblBreak.Size = new System.Drawing.Size(150, 20);
            this.lblBreak.Name = "lblBreak";
            this.lblBreak.Text = "Break Duration (min)";
            this.lblBreak.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblBreak.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblBreak.BackColor = System.Drawing.Color.Transparent;
            // numBreakMin
            this.numBreakMin = new System.Windows.Forms.NumericUpDown();
            this.numBreakMin.Location = new System.Drawing.Point(20, 166); this.numBreakMin.Size = new System.Drawing.Size(200, 25);
            this.numBreakMin.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.numBreakMin.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.numBreakMin.Maximum = 60; this.numBreakMin.Minimum = 5; this.numBreakMin.Value = 15;
            // lblBreakAfter
            this.lblBreakAfter = new System.Windows.Forms.Label();
            this.lblBreakAfter.Location = new System.Drawing.Point(300, 144);
            this.lblBreakAfter.Size = new System.Drawing.Size(150, 20);
            this.lblBreakAfter.Name = "lblBreakAfter";
            this.lblBreakAfter.Text = "Break After Period";
            this.lblBreakAfter.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Regular);
            this.lblBreakAfter.ForeColor = System.Drawing.ColorTranslator.FromHtml("#A8B8A0");
            this.lblBreakAfter.BackColor = System.Drawing.Color.Transparent;
            // numBreakAfter
            this.numBreakAfter = new System.Windows.Forms.NumericUpDown();
            this.numBreakAfter.Location = new System.Drawing.Point(300, 166); this.numBreakAfter.Size = new System.Drawing.Size(200, 25);
            this.numBreakAfter.BackColor = System.Drawing.ColorTranslator.FromHtml("#132218"); this.numBreakAfter.ForeColor = System.Drawing.ColorTranslator.FromHtml("#F0F0E8");
            this.numBreakAfter.Maximum = 10; this.numBreakAfter.Minimum = 1; this.numBreakAfter.Value = 3;
            // btnSaveConfig
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnSaveConfig.Location = new System.Drawing.Point(20, 200);
            this.btnSaveConfig.Size = new System.Drawing.Size(200, 36);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Text = "Save Configuration";
            this.btnSaveConfig.BackColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnSaveConfig.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.btnSaveConfig.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfig.FlatAppearance.BorderSize = 0;
            this.btnSaveConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // btnRegenerate
            this.btnRegenerate = new System.Windows.Forms.Button();
            this.btnRegenerate.Location = new System.Drawing.Point(240, 200);
            this.btnRegenerate.Size = new System.Drawing.Size(200, 36);
            this.btnRegenerate.Name = "btnRegenerate";
            this.btnRegenerate.Text = "Regenerate Time Slots";
            this.btnRegenerate.BackColor = System.Drawing.ColorTranslator.FromHtml("#1A3A25");
            this.btnRegenerate.ForeColor = System.Drawing.ColorTranslator.FromHtml("#C9A84C");
            this.btnRegenerate.Font = new System.Drawing.Font(new System.Drawing.FontFamily("Segoe UI"), 9.5f, System.Drawing.FontStyle.Bold);
            this.btnRegenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegenerate.FlatAppearance.BorderSize = 0;
            this.btnRegenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegenerate.Click += new System.EventHandler(this.btnRegenerate_Click);
            // dgvTimeSlots
            this.dgvTimeSlots = new System.Windows.Forms.DataGridView();
            this.dgvTimeSlots.Location = new System.Drawing.Point(20, 250); this.dgvTimeSlots.Size = new System.Drawing.Size(700, 300);
            this.dgvTimeSlots.Name = "dgvTimeSlots"; this.dgvTimeSlots.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.dgvTimeSlots.GridColor = System.Drawing.ColorTranslator.FromHtml("#2A4030"); this.dgvTimeSlots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTimeSlots.AutoGenerateColumns = false; this.dgvTimeSlots.ReadOnly = true;
            this.dgvTimeSlots.RowHeadersVisible = false; this.dgvTimeSlots.AllowUserToAddRows = false;
            this.dgvTimeSlots.EnableHeadersVisualStyles = false; this.dgvTimeSlots.ColumnHeadersHeight = 38;
            this.dgvTimeSlots.RowTemplate.Height = 34;

            this.SuspendLayout();
            this.Controls.Add(this.lblSection1);
            this.Controls.Add(this.lblEffective); this.Controls.Add(this.dtpEffective);
            this.Controls.Add(this.lblStart); this.Controls.Add(this.dtpSchoolStart);
            this.Controls.Add(this.lblEnd); this.Controls.Add(this.dtpSchoolEnd);
            this.Controls.Add(this.lblLecture); this.Controls.Add(this.numLectureMin);
            this.Controls.Add(this.lblBreak); this.Controls.Add(this.numBreakMin);
            this.Controls.Add(this.lblBreakAfter); this.Controls.Add(this.numBreakAfter);
            this.Controls.Add(this.btnSaveConfig); this.Controls.Add(this.btnRegenerate);
            this.Controls.Add(this.dgvTimeSlots);

            // frmScheduleConfig
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 580);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "frmScheduleConfig";
            this.Text = "EduNova - Schedule Config";
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#0D1B14");
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}