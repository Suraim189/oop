using EduNova.Domain.Enums;

namespace EduNova.Domain.Entities
{
    public class LibraryBook
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
        public BookStatus Status { get; set; }
    }
}