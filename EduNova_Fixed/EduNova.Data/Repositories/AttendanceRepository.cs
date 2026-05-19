using System;
using System.Data;

namespace EduNova.Data.Repositories
{
    public class AttendanceRepository
    {
        public static DataTable GetStudentsForAttendance(int classSectionId, DateTime date)
        {
            return SqlHelper.ExecuteDataTable("sp_GetStudentsForAttendance",
                SqlHelper.Param("@ClassSectionId", classSectionId),
                SqlHelper.Param("@AttendanceDate", date));
        }

        public static int SaveAttendance(int studentId, int classSectionId, DateTime date, int status, int markedBy)
        {
            return SqlHelper.ExecuteNonQuery("sp_SaveAttendance",
                SqlHelper.Param("@StudentId", studentId),
                SqlHelper.Param("@ClassSectionId", classSectionId),
                SqlHelper.Param("@AttendanceDate", date),
                SqlHelper.Param("@Status", status),
                SqlHelper.Param("@MarkedBy", markedBy));
        }

        public static DataTable GetSummary(int classSectionId, DateTime fromDate, DateTime toDate)
        {
            return SqlHelper.ExecuteDataTable("sp_GetAttendanceSummary",
                SqlHelper.Param("@ClassSectionId", classSectionId),
                SqlHelper.Param("@FromDate", fromDate),
                SqlHelper.Param("@ToDate", toDate));
        }
    }
}
