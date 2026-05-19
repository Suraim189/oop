namespace EduNova.Domain.Entities
{
    public class LibraryFinePolicy
    {
        public int PolicyId { get; set; }
        public decimal FinePerDay { get; set; }
        public int GraceDays { get; set; }
    }
}