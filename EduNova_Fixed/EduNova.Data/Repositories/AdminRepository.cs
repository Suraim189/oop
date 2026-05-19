using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using EduNova.Domain.DTOs;
using EduNova.Domain.Entities;

namespace EduNova.Data.Repositories
{
    public class AdminRepository
    {
        public static LoginResultDTO ValidateLogin(string username, string passwordHash)
        {
            var dt = SqlHelper.ExecuteDataTable("sp_LoginUser",
                SqlHelper.Param("@Username", username),
                SqlHelper.Param("@PasswordHash", passwordHash));
            if (dt.Rows.Count == 0) return null;
            var row = dt.Rows[0];
            return new LoginResultDTO
            {
                UserId = Convert.ToInt32(row["UserId"]),
                Username = row["Username"].ToString(),
                DisplayName = row["DisplayName"].ToString(),
                RoleName = row["RoleName"].ToString(),
                RoleId = Convert.ToInt32(row["RoleId"]),
                LastLogin = row["LastLogin"] as DateTime?
            };
        }

        public static string HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                var sb = new StringBuilder();
                foreach (var b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        public static DataTable GetAllUsers()
        {
            return SqlHelper.ExecuteDataTable("sp_GetAllUsers");
        }

        public static DataTable GetAllRoles()
        {
            return SqlHelper.ExecuteDataTable("sp_GetAllRoles");
        }

        public static DataTable GetAllPermissionCodes()
        {
            return SqlHelper.ExecuteDataTable("sp_GetAllPermissionCodes");
        }

        public static DataTable GetRolePermissions(int roleId)
        {
            return SqlHelper.ExecuteDataTable("sp_GetRolePermissions",
                SqlHelper.Param("@RoleId", roleId));
        }

        public static int SetRolePermissions(int roleId, string permissionCodes)
        {
            return SqlHelper.ExecuteNonQuery("sp_SetRolePermissions",
                SqlHelper.Param("@RoleId", roleId),
                SqlHelper.Param("@PermissionCodes", permissionCodes));
        }

        public static DataTable GetUserPermissions(int userId)
        {
            return SqlHelper.ExecuteDataTable("sp_GetUserPermissions",
                SqlHelper.Param("@UserId", userId));
        }

        public static int InsertUser(string username, string displayName, string passwordHash, int roleId, bool isActive)
        {
            return SqlHelper.ExecuteNonQuery("sp_InsertUser",
                SqlHelper.Param("@Username", username),
                SqlHelper.Param("@DisplayName", displayName),
                SqlHelper.Param("@PasswordHash", passwordHash),
                SqlHelper.Param("@RoleId", roleId),
                SqlHelper.Param("@IsActive", isActive));
        }

        public static int UpdateUser(int userId, string username, string displayName, int roleId, bool isActive)
        {
            return SqlHelper.ExecuteNonQuery("sp_UpdateUser",
                SqlHelper.Param("@UserId", userId),
                SqlHelper.Param("@Username", username),
                SqlHelper.Param("@DisplayName", displayName),
                SqlHelper.Param("@RoleId", roleId),
                SqlHelper.Param("@IsActive", isActive));
        }

        public static int UpdateUserPassword(int userId, string passwordHash)
        {
            return SqlHelper.ExecuteNonQuery("sp_UpdateUserPassword",
                SqlHelper.Param("@UserId", userId),
                SqlHelper.Param("@PasswordHash", passwordHash));
        }

        public static int DeleteUser(int userId)
        {
            return SqlHelper.ExecuteNonQuery("sp_DeleteUser",
                SqlHelper.Param("@UserId", userId));
        }

        public static DataTable GetAuditLogs(DateTime? fromDate, DateTime? toDate, int? userId, string action)
        {
            return SqlHelper.ExecuteDataTable("sp_GetAuditLogs",
                SqlHelper.Param("@FromDate", (object)fromDate ?? DBNull.Value),
                SqlHelper.Param("@ToDate", (object)toDate ?? DBNull.Value),
                SqlHelper.Param("@UserId", (object)userId ?? DBNull.Value),
                SqlHelper.Param("@Action", (object)action ?? DBNull.Value));
        }

        public static int InsertAuditLog(string username, string action, string module, string entity, string details)
        {
            return SqlHelper.ExecuteNonQuery("sp_InsertAuditLog",
                SqlHelper.Param("@Username", username),
                SqlHelper.Param("@Action", action),
                SqlHelper.Param("@Module", module),
                SqlHelper.Param("@Entity", entity),
                SqlHelper.Param("@Details", details));
        }

        public static DataTable GetDashboardCounts()
        {
            return SqlHelper.ExecuteDataTable("sp_GetDashboardCounts");
        }
    }
}
