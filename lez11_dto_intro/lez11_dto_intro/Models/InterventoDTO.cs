namespace lez11_dto_intro.Models
{
    public class InterventoDTO
    {
        public string? Cod { get; set; }
        public string? Tar { get; set; }
        public DateTime? Dti { get; set; }
        public DateTime? Dtu { get; set; }
        public string? Sta { get; set; }
        public string? Des { get; set; }
        public decimal? Pre { get; set; }

        public Cliente? Cli { get; set; }
    }
}
