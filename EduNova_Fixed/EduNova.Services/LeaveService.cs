using System;
using System.Data;
using EduNova.Data.Repositories;

namespace EduNova.Services
{
    public class LeaveService
    {
        public DataTable GetLeaveRequests() => TimetableRepository.GetTeacherLeaveRequests();
        public int SubmitLeave(int teacherId, DateTime date, string reason) => TimetableRepository.SubmitLeaveRequest(teacherId, date, reason);
    }
}
