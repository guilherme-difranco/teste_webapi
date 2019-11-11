using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodigoController : Controller
    {
        [HttpGet("showmethecode")]
        [SwaggerOperation(Summary = "Mostra o link para o codigo fonte", Description = "Teste Web Api")]
        public string Showmethecode()
        {
            return "https://github.com/guilherme-difranco/teste_webapi";
        }
    }
}