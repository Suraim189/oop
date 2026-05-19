using System.Data;
using EduNova.Data.Repositories;
using EduNova.Domain.Entities;

namespace EduNova.Services
{
    public class StudentService
    {
        public DataTable GetAll()
        {
            return StudentRepository.GetAll();
        }

        public DataRow GetById(int studentId)
        {
            return StudentRepository.GetById(studentId);
        }

        public int Insert(Student s)
        {
            return StudentRepository.Insert(s);
        }

        public int Update(Student s)
        {
            return StudentRepository.Update(s);
        }

        public int Delete(int studentId)
        {
            return StudentRepository.Delete(studentId);
        }

        public DataTable GetForClass(int classSectionId)
        {
            return StudentRepository.GetForClass(classSectionId);
        }
    }
}
