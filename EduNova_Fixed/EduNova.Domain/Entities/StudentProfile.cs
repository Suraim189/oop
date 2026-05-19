namespace EduNova.Domain.Entities
{
    public class StudentProfile
    {
        public int ProfileId { get; set; }
        public int StudentId { get; set; }
        public string BloodGroup { get; set; }
        public string MedicalConditions { get; set; }
        public string PreviousSchool { get; set; }
        public string PhotoPath { get; set; }
    }
}