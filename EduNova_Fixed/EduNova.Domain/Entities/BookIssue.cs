using System;

namespace EduNova.Domain.Entities
{
    public class BookIssue
    {
        public int IssueId { get; set; }
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime IssuedOn { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnedOn { get; set; }
        public decimal Fine { get; set; }
        public bool IsReturned { get; set; }
    }
}