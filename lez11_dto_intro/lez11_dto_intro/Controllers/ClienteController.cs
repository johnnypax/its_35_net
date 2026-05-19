using lez11_dto_intro.Models;
using lez11_dto_intro.Services;
using Microsoft.AspNetCore.Mvc;

namespace lez11_dto_intro.Controllers
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

        [HttpGet("{id}")]
        public ActionResult<ClienteDTO?> GetCliById(int id)
        {
            ClienteDTO? cli = _clienteService.GetClienteById(id);
            if(cli is null)
                return NotFound();

            return Ok(cli);
        }

        [HttpGet("{id}/dettaglio")]
        public ActionResult<ClienteDTO?> GetCliByIdDettaglio(int id)
        {
            ClienteDTO? cli = _clienteService.GetClienteDettaglioById(id);
            if (cli is null)
                return NotFound();

            return Ok(cli);
        }
    }
}
