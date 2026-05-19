using System;
using System.Data;
using EduNova.Domain.Entities;

namespace EduNova.Data.Repositories
{
    public class StudentRepository
    {
        public static DataTable GetAll()
        {
            return SqlHelper.ExecuteDataTable("sp_Student_GetAll",
                SqlHelper.Param("@Search", DBNull.Value),
                SqlHelper.Param("@IsActive", DBNull.Value));
        }

        public static DataTable Search(string keyword)
        {
            return SqlHelper.ExecuteDataTable("sp_Student_GetAll",
                SqlHelper.Param("@Search", keyword),
                SqlHelper.Param("@IsActive", DBNull.Value));
        }

        public static DataRow GetById(int studentId)
        {
            var dt = SqlHelper.ExecuteDataTable("sp_Student_GetById",
                SqlHelper.Param("@StudentId", studentId));
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public static int Insert(Student s)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(s));
            var enrollment = s.Enrollments != null && s.Enrollments.Count > 0 ? s.Enrollments[0] : null;
            if (enrollment == null || enrollment.ClassSectionId <= 0)
                throw new ArgumentException("Student enrollment must include a valid class section.", nameof(s));
            var age = s.Age ?? CalculateAge(s.DateOfBirth);
            return SqlHelper.ExecuteNonQuery("sp_Student_Insert",
                SqlHelper.Param("@FirstName", s.FirstName),
                SqlHelper.Param("@LastName", s.LastName),
                SqlHelper.Param("@Phone", s.Phone),
                SqlHelper.Param("@Email", s.Email),
                SqlHelper.Param("@Address", s.Address),
                SqlHelper.Param("@DateOfBirth", (object)s.DateOfBirth ?? System.DBNull.Value),
                SqlHelper.Param("@GenderId", (int)s.Gender),
                SqlHelper.Param("@AdmissionNo", s.AdmissionNo),
                SqlHelper.Param("@Age", (object)age ?? DBNull.Value),
                SqlHelper.Param("@RollNo", (object)s.RollNo ?? DBNull.Value),
                SqlHelper.Param("@ClassSectionId", (object)enrollment?.ClassSectionId ?? DBNull.Value),
                SqlHelper.Param("@AcademicYear", (object)enrollment?.AcademicYear ?? DBNull.Value),
                SqlHelper.Param("@GuardianName", s.Guardian?.Name),
                SqlHelper.Param("@GuardianRelation", s.Guardian?.Relation),
                SqlHelper.Param("@GuardianPhone", s.Guardian?.Phone),
                SqlHelper.Param("@CreatedBy", DBNull.Value));
        }

        public static int Update(Student s)
        {
            var age = s.Age ?? CalculateAge(s.DateOfBirth);
            return SqlHelper.ExecuteNonQuery("sp_Student_Update",
                SqlHelper.Param("@StudentId", s.StudentId),
                SqlHelper.Param("@FirstName", s.FirstName),
                SqlHelper.Param("@LastName", s.LastName),
                SqlHelper.Param("@Phone", s.Phone),
                SqlHelper.Param("@Email", s.Email),
                SqlHelper.Param("@Address", s.Address),
                SqlHelper.Param("@DateOfBirth", (object)s.DateOfBirth ?? System.DBNull.Value),
                SqlHelper.Param("@GenderId", (int)s.Gender),
                SqlHelper.Param("@Age", (object)age ?? DBNull.Value),
                SqlHelper.Param("@RollNo", (object)s.RollNo ?? DBNull.Value),
                SqlHelper.Param("@IsActive", s.IsActive),
                SqlHelper.Param("@GuardianName", s.Guardian?.Name),
                SqlHelper.Param("@GuardianRelation", s.Guardian?.Relation),
                SqlHelper.Param("@GuardianPhone", s.Guardian?.Phone),
                SqlHelper.Param("@UpdatedBy", DBNull.Value));
        }

        public static int Delete(int studentId)
        {
            return SqlHelper.ExecuteNonQuery("sp_Student_Delete",
                SqlHelper.Param("@StudentId", studentId));
        }

        public static DataTable GetForClass(int classSectionId)
        {
            return SqlHelper.ExecuteDataTable("sp_GetStudentsForAttendance",
                SqlHelper.Param("@ClassSectionId", classSectionId));
        }

        private static int? CalculateAge(DateTime? dateOfBirth)
        {
            if (!dateOfBirth.HasValue)
                return null;
            var today = DateTime.Today;
            int age = today.Year - dateOfBirth.Value.Year;
            if (dateOfBirth.Value.Date > today.AddYears(-age))
                age--;
            return age > 0 ? (int?)age : null;
        }
    }
}
