using System;
using System.Collections.Generic;
using System.Data;
using EduNova.Data.Repositories;
using EduNova.Domain.Entities;
using EduNova.Domain.Enums;

namespace EduNova.Services
{
    public class SubstitutionService
    {
        public List<SubstitutionAssignment> RunSubstitutionEngine(int teacherId, DateTime leaveDate)
        {
            var result = new List<SubstitutionAssignment>();
            int dow = leaveDate.DayOfWeek == DayOfWeek.Sunday ? 7 : (int)leaveDate.DayOfWeek;
            var dt = TimetableRepository.GetTeacherTimetable(teacherId, dow);
            if (dt.Rows.Count == 0) return result;

            foreach (DataRow row in dt.Rows)
            {
                int entryId = Convert.ToInt32(row["TimetableEntryId"]);
                var subDt = TimetableRepository.FindSubstitute(entryId, teacherId);
                int? subTeacherId = null;
                string subTeacherName = null;
                var status = SubstitutionStatus.Unassigned;

                if (subDt.Rows.Count > 0)
                {
                    subTeacherId = Convert.ToInt32(subDt.Rows[0]["TeacherId"]);
                    subTeacherName = subDt.Rows[0]["TeacherName"].ToString();
                    status = SubstitutionStatus.Assigned;
                    TimetableRepository.AssignSubstitution(entryId, teacherId, subTeacherId.Value, leaveDate);
                }

                result.Add(new SubstitutionAssignment
                {
                    TimetableEntryId = entryId,
                    OriginalTeacherId = teacherId,
                    SubstituteTeacherId = subTeacherId,
                    LeaveDate = leaveDate,
                    Status = status,
                    OriginalTeacherName = row["TeacherName"].ToString(),
                    SubstituteTeacherName = subTeacherName,
                    ClassName = row["ClassName"].ToString(),
                    SubjectName = row["SubjectName"].ToString(),
                    PeriodTime = row["PeriodTime"].ToString()
                });
            }
            return result;
        }
    }
}
