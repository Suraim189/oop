namespace EduNova.Domain.DTOs
{
    public class ExamResultDTO
    {
        public string SubjectName { get; set; }
        public int TotalMarks { get; set; }
        public int ObtainedMarks { get; set; }
        public string Grade { get; set; }
    }
}