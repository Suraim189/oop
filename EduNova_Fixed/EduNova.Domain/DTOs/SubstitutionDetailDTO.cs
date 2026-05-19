namespace EduNova.Domain.DTOs
{
    public class SubstitutionDetailDTO
    {
        public int SubstitutionId { get; set; }
        public string PeriodName { get; set; }
        public string ClassName { get; set; }
        public string SubjectName { get; set; }
        public string OriginalTeacher { get; set; }
        public string SubstituteTeacher { get; set; }
        public string Status { get; set; }
    }
}