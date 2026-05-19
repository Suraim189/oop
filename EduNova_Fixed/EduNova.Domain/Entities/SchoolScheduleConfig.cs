using System;

namespace EduNova.Domain.Entities
{
    public class SchoolScheduleConfig
    {
        public int ConfigId { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public TimeSpan SchoolStart { get; set; }
        public TimeSpan SchoolEnd { get; set; }
        public int LectureDuration { get; set; }
        public int BreakDuration { get; set; }
        public int BreakAfterPeriod { get; set; }
    }
}