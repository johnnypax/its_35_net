using lez11_dto_intro.Models;
using lez11_dto_intro.Repositories;

namespace lez11_dto_intro.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _clienteRepository;
        private readonly InterventoService _interventoService;
        public ClienteService(ClienteRepository clienteRepository, InterventoService interventoService)
        {
            _clienteRepository = clienteRepository;
            _interventoService = interventoService;
        }

        public ClienteDTO? GetClienteById(int id)
        {
            Cliente? cliente = _clienteRepository.GetById(id);
            if (cliente is null)
                return null;

            return new ClienteDTO
            {
                Cod = cliente.Codice,
                Nom = cliente.Nome,
                Cog = cliente.Cognome,
                Ema = cliente.Email,
                Tel = cliente.Telefono
            };
        }

        public ClienteDTO? GetClienteDettaglioById(int id)
        {
            Cliente? cliente = _clienteRepository.GetById(id);
            if (cliente is null)
                return null;

            return new ClienteDTO
            {
                Cod = cliente.Codice,
                Nom = cliente.Nome,
                Cog = cliente.Cognome,
                Ema = cliente.Email,
                Tel = cliente.Telefono,
                Int = _interventoService.GetInterventiByClienteRif(id)
            };
        }
    }
}
