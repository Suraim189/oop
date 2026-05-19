namespace EduNova.Domain.Entities
{
    public class Mark
    {
        public int MarksId { get; set; }
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string RollNo { get; set; }
        public int ObtainedMarks { get; set; }
        public string Grade { get; set; }
    }
}