using System;
using EduNova.Domain.Enums;
using EduNova.Domain.Interfaces;

namespace EduNova.Domain.Entities
{
    public class FeeVoucher : IValidatable
    {
        public int VoucherId { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string ClassSection { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime DueDate { get; set; }
        public VoucherStatus Status { get; set; }

        public System.Collections.Generic.List<string> Validate()
        {
            var errors = new System.Collections.Generic.List<string>();
            if (StudentId <= 0)
                errors.Add("Student is required.");
            if (string.IsNullOrWhiteSpace(Month))
                errors.Add("Month is required.");
            if (Year <= 0)
                errors.Add("Valid year is required.");
            if (TotalAmount < 0)
                errors.Add("Total amount cannot be negative.");
            return errors;
        }
    }
}