using System;

namespace EduNova.Domain.Entities
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ClassSectionId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string AcademicYear { get; set; }
        public bool IsActive { get; set; }
    }
}