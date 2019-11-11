using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;


namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JurosController : ControllerBase
    {


        public JurosController()
        {
        }


        [HttpGet("taxaJuros")]
        [SwaggerOperation(Summary = "Retorna Juros Fixo de 1%", Description = "Teste Web Api")]
        public IActionResult CalcularJuros()
        {
            string juros = "0,01";
            try
            {
                return Ok(juros);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}