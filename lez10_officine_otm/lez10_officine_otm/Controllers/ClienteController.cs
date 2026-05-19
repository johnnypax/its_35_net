using lez10_officine_otm.Models;
using lez10_officine_otm.Services;
using Microsoft.AspNetCore.Mvc;

namespace lez10_officine_otm.Controllers
{
    [ApiController]
    [Route("/api/clienti")]
    public class ClienteController : Controller
    {
        private readonly ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public ActionResult<List<Cliente>> getAllClienti()
        {
            return _clienteService.getAllClienti();
        }

        [HttpGet("{id}")]
        public ActionResult<Cliente?> getClienteById(int id)
        {
            var cliente = _clienteService.getClienteById(id);
            if (cliente == null)
                return NotFound();
            return cliente;
        }
    }
}
