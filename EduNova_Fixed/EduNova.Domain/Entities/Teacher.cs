using System;
using System.Collections.Generic;
using EduNova.Domain.Interfaces;

namespace EduNova.Domain.Entities
{
    public class Teacher : Person, IValidatable, ISoftDeletable
    {
        public int TeacherId { get; set; }
        public string EmployeeCode { get; set; }
        public string Qualification { get; set; }
        public DateTime JoiningDate { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public List<Subject> Subjects { get; set; }

        public List<string> Validate()
        {
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(FirstName))
                errors.Add("First name is required.");
            if (string.IsNullOrWhiteSpace(LastName))
                errors.Add("Last name is required.");
            if (string.IsNullOrWhiteSpace(EmployeeCode))
                errors.Add("Employee code is required.");
            return errors;
        }
    }
}