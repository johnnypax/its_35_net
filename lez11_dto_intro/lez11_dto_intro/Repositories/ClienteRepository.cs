using lez11_dto_intro.Context;
using lez11_dto_intro.Models;

namespace lez11_dto_intro.Repositories
{
    public class ClienteRepository : IRepository<Cliente>
    {
        private readonly OfficinaContext _context;

        public ClienteRepository(OfficinaContext context)
        {
            _context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            return _context.Clienti.ToList();
        }

        public Cliente? GetById(int id)
        {
            return _context.Clienti.Find(id);
        }

        public bool Insert(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
