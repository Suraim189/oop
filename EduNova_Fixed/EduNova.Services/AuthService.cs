using EduNova.Data.Repositories;
using EduNova.Domain.DTOs;

namespace EduNova.Services
{
    public class AuthService
    {
        public LoginResultDTO Login(string username, string password)
        {
            string passwordHash = AdminRepository.HashPassword(password);
            return AdminRepository.ValidateLogin(username, passwordHash);
        }

        public string HashPassword(string password)
        {
            return AdminRepository.HashPassword(password);
        }
    }
}
