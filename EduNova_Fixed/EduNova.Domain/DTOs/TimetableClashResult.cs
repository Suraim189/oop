namespace EduNova.Domain.DTOs
{
    public class TimetableClashResult
    {
        public bool HasClash { get; set; }
        public string ClashMessage { get; set; }
        public int TimetableEntryId { get; set; }
    }
}