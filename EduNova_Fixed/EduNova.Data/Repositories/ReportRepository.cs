using System;
using System.Data;

namespace EduNova.Data.Repositories
{
    public class ReportRepository
    {
        public static DataTable GetFeeDueReport(int? classSectionId)
        {
            return SqlHelper.ExecuteDataTable("sp_GetFeeDueStudents",
                SqlHelper.Param("@ClassSectionId", (object)classSectionId ?? DBNull.Value));
        }

        public static DataTable GetAttendanceReport(int classSectionId, DateTime fromDate, DateTime toDate)
        {
            return SqlHelper.ExecuteDataTable("sp_GetAttendanceSummary",
                SqlHelper.Param("@ClassSectionId", classSectionId),
                SqlHelper.Param("@FromDate", fromDate),
                SqlHelper.Param("@ToDate", toDate));
        }

        public static DataTable GetExamResultsReport(int examId, int classSectionId)
        {
            return SqlHelper.ExecuteDataTable("sp_GetExamResultsByClass",
                SqlHelper.Param("@ExamId", examId),
                SqlHelper.Param("@ClassSectionId", classSectionId));
        }

        public static DataTable GetSubstitutionReport(DateTime fromDate, DateTime toDate)
        {
            return SqlHelper.ExecuteDataTable("sp_GetSubstitutionReport",
                SqlHelper.Param("@FromDate", fromDate),
                SqlHelper.Param("@ToDate", toDate));
        }
    }
}
