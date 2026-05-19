namespace EduNova.Domain.Entities
{
    public class NotificationPreference
    {
        public int PreferenceId { get; set; }
        public int UserId { get; set; }
        public string NotificationType { get; set; }
        public bool IsEnabled { get; set; }
    }
}