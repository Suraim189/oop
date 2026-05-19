namespace EduNova.Domain.Entities
{
    public class Guardian
    {
        public int GuardianId { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Relation { get; set; }
        public string Phone { get; set; }
        public string Occupation { get; set; }
        public string CNIC { get; set; }
    }
}