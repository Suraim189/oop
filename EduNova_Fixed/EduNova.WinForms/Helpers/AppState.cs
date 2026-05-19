using System;
using System.Collections.Generic;
using EduNova.Domain.DTOs;
using EduNova.Services;

namespace EduNova.WinForms.Helpers
{
    public static class AppState
    {
        public static LoginResultDTO CurrentUser { get; private set; }
        private static HashSet<string> _permissions = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public static void SetUser(LoginResultDTO user)
        {
            CurrentUser = user;
            _permissions.Clear();
            if (user == null)
                return;
            try
            {
                var permissions = new AdminService().GetUserPermissions(user.UserId);
                _permissions = new HashSet<string>(permissions ?? new List<string>(), StringComparer.OrdinalIgnoreCase);
            }
            catch
            {
                _permissions.Clear();
            }
        }

        public static void ClearUser()
        {
            CurrentUser = null;
            _permissions.Clear();
        }

        public static bool IsLoggedIn => CurrentUser != null;

        public static bool HasPermission(string permissionCode)
        {
            if (CurrentUser == null || string.IsNullOrWhiteSpace(permissionCode))
                return false;
            if (_permissions.Contains(permissionCode))
                return true;
            return _permissions.Count == 0 && IsAdminRole(CurrentUser);
        }

        private static bool IsAdminRole(LoginResultDTO user)
        {
            var roleName = user?.RoleName ?? string.Empty;
            return user != null && (user.RoleId == 1 || roleName.IndexOf("admin", StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
