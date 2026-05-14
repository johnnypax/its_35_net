namespace lez07_minimal_CRUD.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titolo { get; set; } = null!;
        public string Descrizione { get; set; } = null!;
        public string Autore { get; set; } = null!;
        public int Anno { get; set; }
    }
}
