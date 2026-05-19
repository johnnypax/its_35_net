using lez11_dto_intro.Models;
using Microsoft.EntityFrameworkCore;

namespace lez11_dto_intro.Context
{
    public class OfficinaContext : DbContext
    {
        public OfficinaContext(DbContextOptions<OfficinaContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Intervento> Interventi { get; set; }
    }
}
