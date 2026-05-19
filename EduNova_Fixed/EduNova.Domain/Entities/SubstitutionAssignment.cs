using System;
using EduNova.Domain.Enums;

namespace EduNova.Domain.Entities
{
    public class SubstitutionAssignment
    {
        public int SubstitutionId { get; set; }
        public int TimetableEntryId { get; set; }
        public int OriginalTeacherId { get; set; }
        public int? SubstituteTeacherId { get; set; }
        public DateTime LeaveDate { get; set; }
        public SubstitutionStatus Status { get; set; }
        public string OriginalTeacherName { get; set; }
        public string SubstituteTeacherName { get; set; }
        public string ClassName { get; set; }
        public string SubjectName { get; set; }
        public string PeriodTime { get; set; }
    }
}