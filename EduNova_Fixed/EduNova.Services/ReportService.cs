using System;
using System.Data;
using EduNova.Data.Repositories;

namespace EduNova.Services
{
    public class ReportService
    {
        public DataTable GetFeeDueReport(int? classSectionId) => ReportRepository.GetFeeDueReport(classSectionId);
        public DataTable GetAttendanceReport(int classSectionId, DateTime fromDate, DateTime toDate)
            => ReportRepository.GetAttendanceReport(classSectionId, fromDate, toDate);
        public DataTable GetExamResultsReport(int examId, int classSectionId)
            => ReportRepository.GetExamResultsReport(examId, classSectionId);
        public DataTable GetSubstitutionReport(DateTime fromDate, DateTime toDate)
            => ReportRepository.GetSubstitutionReport(fromDate, toDate);
    }
}
