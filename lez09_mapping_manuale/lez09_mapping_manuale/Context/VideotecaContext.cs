using lez09_mapping_manuale.Models;
using Microsoft.EntityFrameworkCore;

namespace lez09_mapping_manuale.Context
{
    public class VideotecaContext : DbContext
    {
        public VideotecaContext(DbContextOptions<VideotecaContext> options) : base(options)
        {
        }

        public DbSet<Utente> Utenti { get; set; }
    }
}
