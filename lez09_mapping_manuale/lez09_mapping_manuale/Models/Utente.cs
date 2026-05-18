using System.ComponentModel.DataAnnotations.Schema;

namespace lez09_mapping_manuale.Models
{
    [Table("Utente")]
    public class Utente
    {
        public int utenteID { get; set; }
        public string Nome { get; set; } = null!;
        public string Cognome { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
