using System;
using System.Data;

namespace EduNova.Data.Repositories
{
    public class TimetableRepository
    {
        public static DataTable GetScheduleConfig()
        {
            return SqlHelper.ExecuteDataTable("sp_GetScheduleConfig");
        }

        public static int SaveScheduleConfig(DateTime effectiveFrom, TimeSpan schoolStart, TimeSpan schoolEnd, int lectureDuration, int breakDuration, int breakAfterPeriod)
        {
            return SqlHelper.ExecuteNonQuery("sp_CreateOrUpdateScheduleConfig",
                SqlHelper.Param("@EffectiveFrom", effectiveFrom),
                SqlHelper.Param("@SchoolStart", schoolStart),
                SqlHelper.Param("@SchoolEnd", schoolEnd),
                SqlHelper.Param("@LectureDuration", lectureDuration),
                SqlHelper.Param("@BreakDuration", breakDuration),
                SqlHelper.Param("@BreakAfterPeriod", breakAfterPeriod));
        }

        public static DataTable RegenerateTimeSlots(int configId)
        {
            return SqlHelper.ExecuteDataTable("sp_GenerateTimeSlotsFromConfig",
                SqlHelper.Param("@ConfigId", configId));
        }

        public static DataTable GetTimetable(int classSectionId, int dayOfWeek)
        {
            return SqlHelper.ExecuteDataTable("sp_GetTimetable",
                SqlHelper.Param("@ClassSectionId", classSectionId),
                SqlHelper.Param("@DayOfWeek", dayOfWeek));
        }

        public static DataTable GetTeacherTimetable(int teacherId, int dayOfWeek)
        {
            return SqlHelper.ExecuteDataTable("sp_GetTeacherTimetable",
                SqlHelper.Param("@TeacherId", teacherId),
                SqlHelper.Param("@DayOfWeek", dayOfWeek));
        }

        public static int SaveTimetableEntry(int timetableEntryId, int classSectionId, int timeSlotId, int subjectId, int? teacherId, int dayOfWeek, string room)
        {
            return SqlHelper.ExecuteNonQuery("sp_TimetableEntry_CRUD",
                SqlHelper.Param("@TimetableEntryId", timetableEntryId),
                SqlHelper.Param("@ClassSectionId", classSectionId),
                SqlHelper.Param("@TimeSlotId", timeSlotId),
                SqlHelper.Param("@SubjectId", subjectId),
                SqlHelper.Param("@TeacherId", (object)teacherId ?? DBNull.Value),
                SqlHelper.Param("@DayOfWeek", dayOfWeek),
                SqlHelper.Param("@Room", room));
        }

        public static int DeleteTimetableEntry(int timetableEntryId)
        {
            return SqlHelper.ExecuteNonQuery("sp_TimetableEntry_CRUD",
                SqlHelper.Param("@TimetableEntryId", timetableEntryId),
                SqlHelper.Param("@ClassSectionId", DBNull.Value),
                SqlHelper.Param("@TimeSlotId", DBNull.Value),
                SqlHelper.Param("@SubjectId", DBNull.Value),
                SqlHelper.Param("@TeacherId", DBNull.Value),
                SqlHelper.Param("@DayOfWeek", DBNull.Value),
                SqlHelper.Param("@Room", DBNull.Value));
        }

        public static DataTable GetUnassignedSlotsForSubject(int classSectionId, int subjectId)
        {
            return SqlHelper.ExecuteDataTable("sp_GetUnassignedSlotsForSubject",
                SqlHelper.Param("@ClassSectionId", classSectionId),
                SqlHelper.Param("@SubjectId", subjectId));
        }

        public static DataTable GetTeacherLeaveRequests()
        {
            return SqlHelper.ExecuteDataTable("sp_GetTeacherLeaveRequests");
        }

        public static int SubmitLeaveRequest(int teacherId, DateTime leaveDate, string reason)
        {
            return SqlHelper.ExecuteNonQuery("sp_RequestTeacherLeave",
                SqlHelper.Param("@TeacherId", teacherId),
                SqlHelper.Param("@LeaveDate", leaveDate),
                SqlHelper.Param("@Reason", reason));
        }

        public static DataTable FindSubstitute(int timetableEntryId, int absentTeacherId)
        {
            return SqlHelper.ExecuteDataTable("sp_FindSubstituteTeacher",
                SqlHelper.Param("@TimetableEntryId", timetableEntryId),
                SqlHelper.Param("@AbsentTeacherId", absentTeacherId));
        }

        public static int AssignSubstitution(int timetableEntryId, int originalTeacherId, int substituteTeacherId, DateTime leaveDate)
        {
            return SqlHelper.ExecuteNonQuery("sp_AssignSubstitution",
                SqlHelper.Param("@TimetableEntryId", timetableEntryId),
                SqlHelper.Param("@OriginalTeacherId", originalTeacherId),
                SqlHelper.Param("@SubstituteTeacherId", substituteTeacherId),
                SqlHelper.Param("@LeaveDate", leaveDate));
        }

        public static DataTable GetTodaySubstitutions()
        {
            return SqlHelper.ExecuteDataTable("sp_GetTodaySubstitutions");
        }

        public static DataTable GetReplaceWizardData(int oldTeacherId)
        {
            return SqlHelper.ExecuteDataTable("sp_ReplaceTeacherWizard_Preview",
                SqlHelper.Param("@OldTeacherId", oldTeacherId));
        }

        public static DataTable ExecuteReplaceWizard(int oldTeacherId, int newTeacherId)
        {
            return SqlHelper.ExecuteDataTable("sp_ReplaceTeacherWizard",
                SqlHelper.Param("@OldTeacherId", oldTeacherId),
                SqlHelper.Param("@NewTeacherId", newTeacherId));
        }
    }
}
