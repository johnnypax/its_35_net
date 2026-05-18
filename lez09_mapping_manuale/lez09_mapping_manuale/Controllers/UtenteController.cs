using lez09_mapping_manuale.Context;
using lez09_mapping_manuale.Models;
using Microsoft.AspNetCore.Mvc;

namespace lez09_mapping_manuale.Controllers
{
    [ApiController]
    [Route("api/utenti")]
    public class UtenteController : Controller
    {
        private readonly VideotecaContext _videotecaContext;
        public UtenteController(VideotecaContext videotecaContext)
        {
            _videotecaContext = videotecaContext;
        }

        [HttpGet]
        public ActionResult<List<Utente>> getAllUtenti()
        {
            return _videotecaContext.Utenti.ToList();
        }
    }
}
