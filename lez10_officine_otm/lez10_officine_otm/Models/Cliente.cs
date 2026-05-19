using System.ComponentModel.DataAnnotations.Schema;

namespace lez10_officine_otm.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Codice { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string Cognome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Telefono { get; set; }
    }
}
