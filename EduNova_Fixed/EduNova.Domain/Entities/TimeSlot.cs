using System;
using EduNova.Domain.Enums;

namespace EduNova.Domain.Entities
{
    public class TimeSlot
    {
        public int TimeSlotId { get; set; }
        public int PeriodNo { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public SlotType SlotType { get; set; }
        public int ConfigId { get; set; }
    }
}