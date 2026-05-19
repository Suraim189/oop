using System;
using System.Data;

namespace EduNova.Data.Repositories
{
    public class NotificationRepository
    {
        public static int CreateNotification(string title, string message, int notificationType, int? targetUserId)
        {
            return SqlHelper.ExecuteNonQuery("sp_CreateNotification",
                SqlHelper.Param("@Title", title),
                SqlHelper.Param("@Message", message),
                SqlHelper.Param("@NotificationType", notificationType),
                SqlHelper.Param("@TargetUserId", (object)targetUserId ?? DBNull.Value));
        }

        public static DataTable GetUnread(int? userId)
        {
            return SqlHelper.ExecuteDataTable("sp_GetUnreadNotifications",
                SqlHelper.Param("@UserId", (object)userId ?? DBNull.Value));
        }

        public static int MarkAsRead(int notificationId)
        {
            return SqlHelper.ExecuteNonQuery("sp_MarkNotificationRead",
                SqlHelper.Param("@NotificationId", notificationId));
        }
    }
}
