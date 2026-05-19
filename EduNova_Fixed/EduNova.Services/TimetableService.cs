using System;
using System.Data;
using EduNova.Data.Repositories;
using EduNova.Domain.DTOs;
using EduNova.Domain.Entities;

namespace EduNova.Services
{
    public class TimetableService
    {
        public DataTable GetScheduleConfig() => TimetableRepository.GetScheduleConfig();
        public int SaveScheduleConfig(SchoolScheduleConfig config)
        {
            return TimetableRepository.SaveScheduleConfig(config.EffectiveFrom, config.SchoolStart, config.SchoolEnd,
                config.LectureDuration, config.BreakDuration, config.BreakAfterPeriod);
        }
        public DataTable RegenerateTimeSlots(int configId) => TimetableRepository.RegenerateTimeSlots(configId);
        public DataTable GetTimetable(int classSectionId, int day) => TimetableRepository.GetTimetable(classSectionId, day);
        public DataTable GetTeacherTimetable(int teacherId, int day) => TimetableRepository.GetTeacherTimetable(teacherId, day);
        public int SaveTimetableEntry(TimetableEntry e) => TimetableRepository.SaveTimetableEntry(e.TimetableEntryId, e.ClassSectionId, e.TimeSlotId, e.SubjectId, e.TeacherId, e.DayOfWeek, e.Room);
        public int DeleteTimetableEntry(int id) => TimetableRepository.DeleteTimetableEntry(id);
        public DataTable GetUnassignedSlots(int classSectionId, int subjectId) => TimetableRepository.GetUnassignedSlotsForSubject(classSectionId, subjectId);
        public DataTable GetLeaveRequests() => TimetableRepository.GetTeacherLeaveRequests();
        public int SubmitLeave(int teacherId, DateTime date, string reason) => TimetableRepository.SubmitLeaveRequest(teacherId, date, reason);
        public DataTable FindSubstitute(int entryId, int absentTeacherId) => TimetableRepository.FindSubstitute(entryId, absentTeacherId);
        public int AssignSubstitution(int entryId, int origTeacherId, int subTeacherId, DateTime date) => TimetableRepository.AssignSubstitution(entryId, origTeacherId, subTeacherId, date);
        public DataTable GetTodaySubstitutions() => TimetableRepository.GetTodaySubstitutions();
        public DataTable GetReplaceWizardData(int oldTeacherId) => TimetableRepository.GetReplaceWizardData(oldTeacherId);
        public DataTable ExecuteReplaceWizard(int oldTeacherId, int newTeacherId) => TimetableRepository.ExecuteReplaceWizard(oldTeacherId, newTeacherId);

        public SubstitutionResult RequestLeave(int teacherId, DateTime date, string reason)
        {
            SubmitLeave(teacherId, date, reason);
            var result = new SubstitutionResult { TotalSlots = 0, AssignedSlots = 0, UnassignedSlots = 0, Details = new System.Collections.Generic.List<SubstitutionDetailDTO>() };
            if (date.Date != DateTime.Now.Date) return result;
            var subService = new SubstitutionService();
            var assignments = subService.RunSubstitutionEngine(teacherId, date);
            result.TotalSlots = assignments.Count;
            foreach (var a in assignments)
            {
                if (a.Status == Domain.Enums.SubstitutionStatus.Assigned)
                    result.AssignedSlots++;
                else
                    result.UnassignedSlots++;
            }
            return result;
        }
    }
}
