namespace EduNova.Domain.DTOs
{
    public class DashboardCountsDTO
    {
        public int TotalStudents { get; set; }
        public int TotalTeachers { get; set; }
        public decimal TodayAttendancePercent { get; set; }
        public int FeeDueCount { get; set; }
        public int TodaySubstitutions { get; set; }
    }
}