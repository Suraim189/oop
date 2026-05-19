using System.Data;
using EduNova.Data.Repositories;
using EduNova.Domain.Entities;

namespace EduNova.Services
{
    public class TeacherService
    {
        public DataTable GetAll()
        {
            return TeacherRepository.GetAll();
        }

        public DataRow GetById(int teacherId)
        {
            return TeacherRepository.GetById(teacherId);
        }

        public int Insert(Teacher t)
        {
            return TeacherRepository.Insert(t);
        }

        public int Update(Teacher t)
        {
            return TeacherRepository.Update(t);
        }

        public int Delete(int teacherId)
        {
            return TeacherRepository.Delete(teacherId);
        }

        public DataTable GetSubjectsForTeacher(int teacherId)
        {
            return TeacherRepository.GetSubjectsForTeacher(teacherId);
        }

        public DataTable GetActive()
        {
            return TeacherRepository.GetActive();
        }
    }
}
