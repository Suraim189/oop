using System;
using System.Data;
using System.Linq;

namespace EduNova.Data.Repositories
{
    public class TeacherRepository
    {
        public static DataTable GetAll()
        {
            return SqlHelper.ExecuteDataTable("sp_Teacher_GetAll",
                SqlHelper.Param("@Search", DBNull.Value),
                SqlHelper.Param("@IsActive", DBNull.Value));
        }

        public static DataTable GetActive()
        {
            return SqlHelper.ExecuteDataTable("sp_Teacher_GetActive");
        }

        public static DataRow GetById(int teacherId)
        {
            var dt = SqlHelper.ExecuteDataTable("sp_Teacher_GetById",
                SqlHelper.Param("@TeacherId", teacherId));
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public static int Insert(EduNova.Domain.Entities.Teacher t)
        {
            var subjectIds = t.Subjects != null && t.Subjects.Count > 0
                ? string.Join(",", t.Subjects.Select(s => s.SubjectId))
                : null;
            return SqlHelper.ExecuteNonQuery("sp_Teacher_Insert",
                SqlHelper.Param("@FirstName", t.FirstName),
                SqlHelper.Param("@LastName", t.LastName),
                SqlHelper.Param("@Phone", t.Phone),
                SqlHelper.Param("@Email", t.Email),
                SqlHelper.Param("@Address", t.Address),
                SqlHelper.Param("@DateOfBirth", (object)t.DateOfBirth ?? DBNull.Value),
                SqlHelper.Param("@GenderId", (int)t.Gender),
                SqlHelper.Param("@EmployeeCode", t.EmployeeCode),
                SqlHelper.Param("@Qualification", t.Qualification),
                SqlHelper.Param("@JoiningDate", t.JoiningDate),
                SqlHelper.Param("@Salary", t.Salary),
                SqlHelper.Param("@SubjectIds", (object)subjectIds ?? DBNull.Value),
                SqlHelper.Param("@CreatedBy", DBNull.Value));
        }

        public static int Update(EduNova.Domain.Entities.Teacher t)
        {
            var subjectIds = t.Subjects != null && t.Subjects.Count > 0
                ? string.Join(",", t.Subjects.Select(s => s.SubjectId))
                : null;
            return SqlHelper.ExecuteNonQuery("sp_Teacher_Update",
                SqlHelper.Param("@TeacherId", t.TeacherId),
                SqlHelper.Param("@FirstName", t.FirstName),
                SqlHelper.Param("@LastName", t.LastName),
                SqlHelper.Param("@Phone", t.Phone),
                SqlHelper.Param("@Email", t.Email),
                SqlHelper.Param("@Address", t.Address),
                SqlHelper.Param("@DateOfBirth", (object)t.DateOfBirth ?? DBNull.Value),
                SqlHelper.Param("@GenderId", (int)t.Gender),
                SqlHelper.Param("@Qualification", t.Qualification),
                SqlHelper.Param("@Salary", t.Salary),
                SqlHelper.Param("@IsActive", t.IsActive),
                SqlHelper.Param("@SubjectIds", (object)subjectIds ?? DBNull.Value),
                SqlHelper.Param("@UpdatedBy", DBNull.Value));
        }

        public static int Delete(int teacherId)
        {
            return SqlHelper.ExecuteNonQuery("sp_Teacher_Delete",
                SqlHelper.Param("@TeacherId", teacherId));
        }

        public static int SetActiveStatus(int teacherId, bool isActive)
        {
            return SqlHelper.ExecuteNonQuery("sp_SetTeacherActiveStatus",
                SqlHelper.Param("@TeacherId", teacherId),
                SqlHelper.Param("@IsActive", isActive));
        }

        public static DataTable GetSubjectsForTeacher(int teacherId)
        {
            return SqlHelper.ExecuteDataTable("sp_GetTeacherSubjects",
                SqlHelper.Param("@TeacherId", teacherId));
        }

        public static int AssignSubjects(int teacherId, int[] subjectIds)
        {
            int result = 0;
            foreach (var sid in subjectIds)
            {
                result += SqlHelper.ExecuteNonQuery("sp_SetTeacherSubjects",
                    SqlHelper.Param("@TeacherId", teacherId),
                    SqlHelper.Param("@SubjectId", sid));
            }
            return result;
        }
    }
}
