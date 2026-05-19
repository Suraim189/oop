using System;
using System.Collections.Generic;
using EduNova.Domain.Interfaces;

namespace EduNova.Domain.Entities
{
    public class Student : Person, IValidatable, ISoftDeletable
    {
        public int StudentId { get; set; }
        public string AdmissionNo { get; set; }
        public DateTime AdmissionDate { get; set; }
        public int? Age { get; set; }
        public string RollNo { get; set; }
        public bool IsActive { get; set; }
        public StudentProfile Profile { get; set; }
        public Guardian Guardian { get; set; }
        public List<Enrollment> Enrollments { get; set; }

        public List<string> Validate()
        {
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(FirstName))
                errors.Add("First name is required.");
            if (string.IsNullOrWhiteSpace(LastName))
                errors.Add("Last name is required.");
            if (string.IsNullOrWhiteSpace(AdmissionNo))
                errors.Add("Admission number is required.");
            if (DateOfBirth == null)
                errors.Add("Date of birth is required.");
            return errors;
        }
    }
}