using System;

namespace EduNova.Domain.DTOs
{
    public class LoginResultDTO
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string RoleName { get; set; }
        public int RoleId { get; set; }
        public DateTime? LastLogin { get; set; }
    }
}