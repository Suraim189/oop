using System;
using System.Data;
using EduNova.Data.Repositories;

namespace EduNova.Services
{
    public class AttendanceService
    {
        public DataTable GetStudentsForAttendance(int classSectionId, DateTime date)
            => AttendanceRepository.GetStudentsForAttendance(classSectionId, date);
        public int SaveAttendance(int studentId, int classSectionId, DateTime date, int status, int markedBy)
            => AttendanceRepository.SaveAttendance(studentId, classSectionId, date, status, markedBy);
        public DataTable GetSummary(int classSectionId, DateTime fromDate, DateTime toDate)
            => AttendanceRepository.GetSummary(classSectionId, fromDate, toDate);
    }
}
