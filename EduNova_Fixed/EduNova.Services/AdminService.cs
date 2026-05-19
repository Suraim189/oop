using System;
using System.Collections.Generic;
using System.Data;
using EduNova.Data.Repositories;

namespace EduNova.Services
{
    public class AdminService
    {
        public DataTable GetAll() => GetAllUsers();
        public DataTable GetAllUsers() => AdminRepository.GetAllUsers();
        public DataTable GetAllRoles() => AdminRepository.GetAllRoles();
        public DataTable GetAllPermissionCodes() => AdminRepository.GetAllPermissionCodes();
        public DataTable GetRolePermissions(int roleId) => AdminRepository.GetRolePermissions(roleId);
        public int SetRolePermissions(int roleId, IEnumerable<string> permissionCodes)
        {
            string csv = permissionCodes == null ? string.Empty : string.Join(",", permissionCodes);
            return AdminRepository.SetRolePermissions(roleId, csv);
        }
        public List<string> GetUserPermissions(int userId)
        {
            var dt = AdminRepository.GetUserPermissions(userId);
            var result = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                var code = row["PermissionCode"]?.ToString();
                if (!string.IsNullOrWhiteSpace(code))
                    result.Add(code);
            }
            return result;
        }
        public int SaveUser(int userId, string username, string displayName, int roleId, bool isActive, string password)
        {
            if (userId > 0)
            {
                int result = AdminRepository.UpdateUser(userId, username, displayName, roleId, isActive);
                if (!string.IsNullOrWhiteSpace(password))
                {
                    var hash = AdminRepository.HashPassword(password);
                    AdminRepository.UpdateUserPassword(userId, hash);
                }
                return result;
            }
            else
            {
                var hash = AdminRepository.HashPassword(password);
                return AdminRepository.InsertUser(username, displayName, hash, roleId, isActive);
            }
        }
        public int DeleteUser(int id) => AdminRepository.DeleteUser(id);
        public DataTable GetAuditLogs(DateTime? fromDate, DateTime? toDate, int? userId, string action)
            => AdminRepository.GetAuditLogs(fromDate, toDate, userId, action);
        public void LogAction(string username, string action, string module, string entity, string details)
            => AdminRepository.InsertAuditLog(username, action, module, entity, details);
        public DataTable GetDashboardCounts() => AdminRepository.GetDashboardCounts();
    }
}
