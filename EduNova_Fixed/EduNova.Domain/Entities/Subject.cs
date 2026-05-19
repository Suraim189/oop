namespace EduNova.Domain.Entities
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectCode { get; set; }
        public int DomainId { get; set; }
        public string DomainName { get; set; }
        public bool IsActive { get; set; }
    }
}