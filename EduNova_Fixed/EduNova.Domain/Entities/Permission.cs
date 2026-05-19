namespace EduNova.Domain.Entities
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string PermissionCode { get; set; }
        public string Description { get; set; }
        public string Module { get; set; }
    }
}