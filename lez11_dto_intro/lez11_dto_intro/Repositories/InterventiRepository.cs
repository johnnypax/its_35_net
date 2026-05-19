using lez11_dto_intro.Context;
using lez11_dto_intro.Models;

namespace lez11_dto_intro.Repositories
{
    public class InterventiRepository : IRepository<Intervento>
    {
        private readonly OfficinaContext _context;

        public InterventiRepository(OfficinaContext context)
        {
            _context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Intervento> GetAll()
        {
            return _context.Interventi.ToList();
        }

        public Intervento? GetById(int id)
        {
            return _context.Interventi.Find(id);
        }

        public bool Insert(Intervento entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Intervento entity)
        {
            throw new NotImplementedException();
        }

        public List<Intervento> GetInterventiByClienteRif(int idRif)
        {
            return _context.Interventi.Where(i => i.ClienteRIF == idRif).ToList();
        }
    }
}
