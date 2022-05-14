using Calculadora.Aplicacao.CasosDeUso.CalcularJurosComposto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Calculadora.API.Controllers
{
    [ApiController]
    [Route("")]
    public class JurosComposto : ControllerBase
    {
        readonly IMediator _mediator;

        public JurosComposto(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("calculajuros")]
        public async Task<IActionResult> Get([FromQuery] CalcularJurosCompostoCommand request)
        {
            try
            {
                double valorFinal = await _mediator.Send(request, this.HttpContext.RequestAborted);
                return Ok(new { valor = valorFinal });
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
