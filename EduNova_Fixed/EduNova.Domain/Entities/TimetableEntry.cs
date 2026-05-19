using EduNova.Domain.Interfaces;

namespace EduNova.Domain.Entities
{
    public class TimetableEntry : IValidatable
    {
        public int TimetableEntryId { get; set; }
        public int ClassSectionId { get; set; }
        public int TimeSlotId { get; set; }
        public int SubjectId { get; set; }
        public int? TeacherId { get; set; }
        public int DayOfWeek { get; set; }
        public string Room { get; set; }
        public string SubjectName { get; set; }
        public string TeacherName { get; set; }
        public string ClassName { get; set; }
        public string PeriodTime { get; set; }

        public System.Collections.Generic.List<string> Validate()
        {
            var errors = new System.Collections.Generic.List<string>();
            if (ClassSectionId <= 0)
                errors.Add("Class section is required.");
            if (TimeSlotId <= 0)
                errors.Add("Time slot is required.");
            if (SubjectId <= 0)
                errors.Add("Subject is required.");
            if (DayOfWeek < 1 || DayOfWeek > 7)
                errors.Add("Valid day of week is required.");
            return errors;
        }
    }
}