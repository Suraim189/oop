using System.Collections.Generic;

namespace EduNova.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
        int Insert(T entity);
        int Update(T entity);
        int Delete(int id);
    }
}