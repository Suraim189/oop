using System;
using System.Data;

namespace EduNova.Data.Repositories
{
    public class ExamRepository
    {
        public static DataTable GetAll()
        {
            return SqlHelper.ExecuteDataTable("sp_GetExams");
        }

        public static int CreateExam(string examName, int examType, int classSectionId, int subjectId, DateTime examDate, int totalMarks)
        {
            return SqlHelper.ExecuteNonQuery("sp_CreateExam",
                SqlHelper.Param("@ExamName", examName),
                SqlHelper.Param("@ExamType", examType),
                SqlHelper.Param("@ClassSectionId", classSectionId),
                SqlHelper.Param("@SubjectId", subjectId),
                SqlHelper.Param("@ExamDate", examDate),
                SqlHelper.Param("@TotalMarks", totalMarks));
        }

        public static DataTable GetStudentsForMarks(int examId)
        {
            return SqlHelper.ExecuteDataTable("sp_GetStudentsForMarks",
                SqlHelper.Param("@ExamId", examId));
        }

        public static int SaveMarks(int examId, int studentId, int obtainedMarks)
        {
            return SqlHelper.ExecuteNonQuery("sp_SaveMarks",
                SqlHelper.Param("@ExamId", examId),
                SqlHelper.Param("@StudentId", studentId),
                SqlHelper.Param("@ObtainedMarks", obtainedMarks));
        }

        public static System.Data.DataSet GetStudentResultCard(int examId, int studentId)
        {
            return SqlHelper.ExecuteDataSet("sp_GetStudentResultCard",
                SqlHelper.Param("@StudentId", studentId),
                SqlHelper.Param("@ExamId", examId));
        }

        public static DataTable GetResultsByClass(int examId, int classSectionId)
        {
            return SqlHelper.ExecuteDataTable("sp_GetExamResultsByClass",
                SqlHelper.Param("@ExamId", examId),
                SqlHelper.Param("@ClassSectionId", classSectionId));
        }

        public static int DeleteExam(int examId)
        {
            return SqlHelper.ExecuteNonQuery("sp_DeleteExam",
                SqlHelper.Param("@ExamId", examId));
        }
    }
}
