namespace lez11_dto_intro.Models
{
    public class ClienteDTO
    {
        public string? Cod { get; set; }
        public string? Nom { get; set; }
        public string? Cog { get; set; }
        public string? Ema { get; set; }
        public string? Tel { get; set; }

        public List<InterventoDTO>? Int { get; set; }
    }
}
