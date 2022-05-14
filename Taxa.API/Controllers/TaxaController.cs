using Microsoft.AspNetCore.Mvc;
using MediatR;
using Taxa.Aplicacao.CasosDeUso.ObterTaxa;
using System.Threading.Tasks;
using System;

namespace Taxa.API.Controllers
{
    [ApiController]
    [Route("")]
    public class TaxaController : ControllerBase
    {
        readonly IMediator _mediator;

        public TaxaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("taxajuros")]
        public async Task<IActionResult> GetAsync()
        {
            try
            {
                var taxa = await _mediator.Send(new ObterTaxaCommand(), this.HttpContext.RequestAborted);
                return Ok(taxa);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
