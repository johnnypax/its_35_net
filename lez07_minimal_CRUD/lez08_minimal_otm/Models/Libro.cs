namespace lez08_minimal_otm.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titolo { get; set; } = null!;
        public string Descrizione { get; set; } = null!;
        public Autore Autore { get; set; } = null!;

    }
}
