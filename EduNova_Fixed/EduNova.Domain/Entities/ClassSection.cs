namespace EduNova.Domain.Entities
{
    public class ClassSection
    {
        public int ClassSectionId { get; set; }
        public int GradeClassId { get; set; }
        public int SectionId { get; set; }
        public string DisplayName { get; set; }
        public int? ClassTeacherId { get; set; }
        public int MaxStudents { get; set; }
        public bool IsActive { get; set; }
        public string GradeClassName { get; set; }
        public string SectionName { get; set; }
        public string TeacherName { get; set; }
    }
}