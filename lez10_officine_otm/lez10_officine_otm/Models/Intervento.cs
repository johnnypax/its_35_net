using System.ComponentModel.DataAnnotations.Schema;

namespace lez10_officine_otm.Models
{
    [Table("Intervento")]
    public class Intervento
    {
        public int InterventoID { get; set; }
        public string Codice { get; set; } = null!;
        public string Targa { get; set; } = null!;
        [Column("data_ingresso")]
        public DateTime DataIngresso { get; set; }
        [Column("data_uscita")]
        public DateTime? DataUscita { get; set; }
        public string Stato { get; set; } = null!;
        public string? Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public int  ClienteRIF { get; set; }
    }
}
