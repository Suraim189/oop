using System;
using EduNova.Domain.Enums;

namespace EduNova.Domain.Entities
{
    public class AttendanceRecord
    {
        public int AttendanceId { get; set; }
        public int StudentId { get; set; }
        public int ClassSectionId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public AttendanceStatus Status { get; set; }
        public int MarkedBy { get; set; }
        public string StudentName { get; set; }
        public string RollNo { get; set; }
    }
}