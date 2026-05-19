using lez10_officine_otm.Models;
using Microsoft.EntityFrameworkCore;

namespace lez10_officine_otm.Context
{
    public class OfficinaContext : DbContext
    {
        public OfficinaContext(DbContextOptions<OfficinaContext> options) : base(options) { 
        }

        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Intervento> Interventi { get; set; }

    }
}
