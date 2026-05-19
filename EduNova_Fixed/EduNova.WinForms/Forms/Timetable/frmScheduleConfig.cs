using System;
using System.Data;
using System.Windows.Forms;
using EduNova.Services;
using EduNova.WinForms.Helpers;
using EduNova.Domain.Entities;

namespace EduNova.WinForms.Forms.Timetable
{
    public partial class frmScheduleConfig : Form
    {
        private readonly TimetableService _svc = new TimetableService();
        private DataTable _timeSlots;

        public frmScheduleConfig()
        {
            InitializeComponent();
            Load += frmScheduleConfig_Load;
            Theme.StyleDataGridView(dgvTimeSlots);
            SetupGrid();
        }

        private void SetupGrid()
        {
            dgvTimeSlots.Columns.Clear();
            dgvTimeSlots.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPeriod", HeaderText = "Period No", Width = 80 });
            dgvTimeSlots.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStart", HeaderText = "Start Time", Width = 120 });
            dgvTimeSlots.Columns.Add(new DataGridViewTextBoxColumn { Name = "colEnd", HeaderText = "End Time", Width = 120 });
            dgvTimeSlots.Columns.Add(new DataGridViewTextBoxColumn { Name = "colType", HeaderText = "Slot Type", Width = 100 });
        }

        private void frmScheduleConfig_Load(object sender, EventArgs e)
        {
            try
            {
                var config = _svc.GetScheduleConfig();
                if (config.Rows.Count > 0)
                {
                    var row = config.Rows[0];
                    dtpEffective.Value = Convert.ToDateTime(row["EffectiveFrom"]);
                    dtpSchoolStart.Value = DateTime.Now.Date + (TimeSpan)row["SchoolStart"];
                    dtpSchoolEnd.Value = DateTime.Now.Date + (TimeSpan)row["SchoolEnd"];
                    numLectureMin.Value = Convert.ToInt32(row["LectureDuration"]);
                    numBreakMin.Value = Convert.ToInt32(row["BreakDuration"]);
                    numBreakAfter.Value = Convert.ToInt32(row["BreakAfterPeriod"]);
                }
                _timeSlots = _svc.RegenerateTimeSlots(1);
                dgvTimeSlots.DataSource = _timeSlots;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                var config = new SchoolScheduleConfig
                {
                    EffectiveFrom = dtpEffective.Value,
                    SchoolStart = dtpSchoolStart.Value.TimeOfDay,
                    SchoolEnd = dtpSchoolEnd.Value.TimeOfDay,
                    LectureDuration = (int)numLectureMin.Value,
                    BreakDuration = (int)numBreakMin.Value,
                    BreakAfterPeriod = (int)numBreakAfter.Value
                };
                _svc.SaveScheduleConfig(config);
                MessageBox.Show("Configuration saved!", "Success");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnRegenerate_Click(object sender, EventArgs e)
        {
            try { _timeSlots = _svc.RegenerateTimeSlots(1); dgvTimeSlots.DataSource = _timeSlots; }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}
