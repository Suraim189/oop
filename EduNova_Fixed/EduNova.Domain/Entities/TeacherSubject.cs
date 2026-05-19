namespace EduNova.Domain.Entities
{
    public class TeacherSubject
    {
        public int TeacherSubjectId { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
    }
}