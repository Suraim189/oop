using System;
using System.Data;
using EduNova.Data.Repositories;

namespace EduNova.Services
{
    public class NotificationService
    {
        public int CreateNotification(string title, string message, int type, int? targetUserId)
            => NotificationRepository.CreateNotification(title, message, type, targetUserId);
        public DataTable GetUnread(int? userId) => NotificationRepository.GetUnread(userId);
        public int MarkAsRead(int id) => NotificationRepository.MarkAsRead(id);
        public int MarkAllRead(int? userId)
        {
            if (!userId.HasValue)
                return 0;
            var dt = GetUnread(userId);
            int count = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["NotificationId"] == DBNull.Value)
                    continue;
                count += MarkAsRead(Convert.ToInt32(row["NotificationId"]));
            }
            return count;
        }
    }
}
