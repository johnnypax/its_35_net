using lez10_officine_otm.Models;

namespace lez10_officine_otm.Repositories
{
    public interface IRepository<T>
    {
        List<T> getAll();
        T? getById(int id);
        bool Insert(T obj);
        bool Delete(int id);
        bool Update(T obj);
    }
}
