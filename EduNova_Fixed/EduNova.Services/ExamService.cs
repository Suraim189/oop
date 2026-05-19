using System;
using System.Data;
using EduNova.Data.Repositories;
using EduNova.Domain.Enums;

namespace EduNova.Services
{
    public class ExamService
    {
        public DataTable GetAll() => ExamRepository.GetAll();
        public int CreateExam(string name, ExamType type, int classSectionId, int subjectId, DateTime date, int totalMarks)
            => ExamRepository.CreateExam(name, (int)type, classSectionId, subjectId, date, totalMarks);
        public DataTable GetStudentsForMarks(int examId) => ExamRepository.GetStudentsForMarks(examId);
        public int SaveMarks(int examId, int studentId, int obtained) => ExamRepository.SaveMarks(examId, studentId, obtained);
        public DataSet GetResultReport(int examId, int studentId) => ExamRepository.GetStudentResultCard(examId, studentId);
        public DataTable GetResultsByClass(int examId, int classSectionId) => ExamRepository.GetResultsByClass(examId, classSectionId);
        public int DeleteExam(int examId) => ExamRepository.DeleteExam(examId);

        public static string CalculateGrade(int obtained, int total)
        {
            if (total == 0) return "N/A";
            decimal pct = (decimal)obtained / total * 100;
            if (pct >= 90) return "A+";
            if (pct >= 80) return "A";
            if (pct >= 70) return "B";
            if (pct >= 60) return "C";
            if (pct >= 50) return "D";
            return "F";
        }
    }
}
