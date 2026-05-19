using lez10_officine_otm.Models;
using lez10_officine_otm.Repositories;

namespace lez10_officine_otm.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteService(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<Cliente> getAllClienti()
        {
            return _clienteRepository.getAll();
        }

        public Cliente? getClienteById(int id)
        {
            return _clienteRepository.getById(id);
        }
    }
}
