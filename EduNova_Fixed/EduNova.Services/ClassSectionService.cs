using System.Data;
using EduNova.Data.Repositories;

namespace EduNova.Services
{
    public class ClassSectionService
    {
        public DataTable GetAll() => ClassSectionRepository.GetAll();
        public DataTable GetClasses() => ClassSectionRepository.GetClasses();
        public DataTable GetSections() => ClassSectionRepository.GetSections();
        public int InsertClass(string name, string desc) => ClassSectionRepository.InsertClass(name, desc);
        public int UpdateClass(int id, string name, string desc) => ClassSectionRepository.UpdateClass(id, name, desc);
        public int DeleteClass(int id) => ClassSectionRepository.DeleteClass(id);
        public int InsertSection(int gradeClassId, int sectionId, int maxStudents)
            => ClassSectionRepository.InsertSection(gradeClassId, sectionId, maxStudents);
        public int DeleteSection(int id) => ClassSectionRepository.DeleteSection(id);
    }
}
