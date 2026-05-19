using lez10_officine_otm.Context;
using lez10_officine_otm.Models;

namespace lez10_officine_otm.Repositories
{
    public class ClienteRepository : IRepository<Cliente>
    {
        private readonly OfficinaContext _context;

        public ClienteRepository(OfficinaContext ctx)
        {
            _context = ctx;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> getAll()
        {
            return _context.Clienti.ToList();
        }

        public Cliente? getById(int id)
        {
            return _context.Clienti.Find(id);
        }

        public bool Insert(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}
