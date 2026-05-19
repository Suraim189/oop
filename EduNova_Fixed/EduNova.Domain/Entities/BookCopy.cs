namespace EduNova.Domain.Entities
{
    public class BookCopy
    {
        public int CopyId { get; set; }
        public int BookId { get; set; }
        public string CopyNumber { get; set; }
        public bool IsAvailable { get; set; }
    }
}