using System;
using EduNova.Domain.Enums;

namespace EduNova.Domain.Entities
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public ExamType ExamType { get; set; }
        public int ClassSectionId { get; set; }
        public string ClassSectionName { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public DateTime ExamDate { get; set; }
        public int TotalMarks { get; set; }
        public bool IsActive { get; set; }
    }
}