using System;

namespace EduNova.Domain.Entities
{
    public class AuditLog
    {
        public int LogId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Username { get; set; }
        public string Action { get; set; }
        public string Module { get; set; }
        public string Entity { get; set; }
        public string Details { get; set; }
    }
}