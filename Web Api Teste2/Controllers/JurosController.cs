using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JurosController : ControllerBase
    {
        private IJurosService _JurosService;

        public JurosController(
            IJurosService jurosService)
        {
            _JurosService = jurosService;
        }


        [HttpGet("calculajuros/{valorInicial}/{meses}")]
        [SwaggerOperation(Summary = "Calcula Juros Composto", Description = "Teste Web Api")]
        public IActionResult CalcularJuros(double valorInicial, int meses)
        {
            ResponseModel model = _JurosService.CalcularJuros(valorInicial, meses);
            try
            {
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}