using lez11_dto_intro.Models;
using lez11_dto_intro.Repositories;

namespace lez11_dto_intro.Services
{
    public class InterventoService
    {
        private readonly InterventiRepository _interventiRepository;

        public InterventoService(InterventiRepository interventiRepository)
        {
            _interventiRepository = interventiRepository;
        }

        public List<InterventoDTO> GetInterventiByClienteRif(int rif)
        {
            List<Intervento> interventi = _interventiRepository.GetInterventiByClienteRif(rif);
            List<InterventoDTO> interventiDTO = new List<InterventoDTO>();

            foreach (var item in interventi)
            {
                InterventoDTO dto = new InterventoDTO
                {
                    Cod = item.Codice,
                    Tar = item.Targa,
                    Dti = item.DataIngresso,
                    Dtu = item.DataUscita,
                    Sta = item.Stato,
                    Des = item.Descrizione,
                    Pre = item.Prezzo
                };
                interventiDTO.Add(dto);
            }

            return interventiDTO;
        }
    }
}
