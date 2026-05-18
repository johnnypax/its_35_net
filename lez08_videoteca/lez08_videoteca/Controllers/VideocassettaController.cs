using lez08_videoteca.models;
using Microsoft.AspNetCore.Mvc;

namespace lez08_videoteca.Controllers
{
    [ApiController]
    [Route("api/videocassetta")]
    public class VideocassettaController : Controller
    {
        [HttpGet("lista")]
        public ActionResult<List<Videocassettum>> getAllVideocassette()
        {
            List<Videocassettum> risultato = new List<Videocassettum>();

            using (var ctx = new Ict35VideotecaContext())
            {
                risultato = ctx.Videocassetta.ToList();
            }

            return Ok(risultato);
        }

        [HttpGet("{varCodi}")]
        public ActionResult<Videocassettum?> getByIdVideocassetta(string varCodi)
        {
            Videocassettum? risultato = null;

            using(var ctx = new Ict35VideotecaContext())
            {
                risultato = ctx.Videocassetta.Where(v => v.Codice == varCodi).FirstOrDefault();
            }

            if (risultato is null)
                return NotFound();

            return Ok(risultato);
        }

        [HttpPost]
        public ActionResult insertVideocassetta(Videocassettum objVideo)
        {
            using (var ctx = new Ict35VideotecaContext())
            {
                try
                {
                    ctx.Videocassetta.Add(objVideo);
                    ctx.SaveChanges();

                    return Ok();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            return BadRequest();

        }
    }
}
