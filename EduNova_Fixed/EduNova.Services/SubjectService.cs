using System.Data;
using EduNova.Data.Repositories;

namespace EduNova.Services
{
    public class SubjectService
    {
        public DataTable GetAll() => SubjectRepository.GetAll();
        public DataTable GetDomains() => SubjectRepository.GetDomains();
        public int Insert(string name, string code, int domainId, bool active) => SubjectRepository.Insert(name, code, domainId, active);
        public int Update(int id, string name, string code, int domainId, bool active) => SubjectRepository.Update(id, name, code, domainId, active);
        public int Delete(int id) => SubjectRepository.Delete(id);
    }
}
