using System;
using EduNova.Domain.Enums;

namespace EduNova.Domain.Entities
{
    public class TeacherLeaveRequest
    {
        public int LeaveRequestId { get; set; }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public DateTime LeaveDate { get; set; }
        public string Reason { get; set; }
        public LeaveStatus Status { get; set; }
        public DateTime RequestedAt { get; set; }
    }
}