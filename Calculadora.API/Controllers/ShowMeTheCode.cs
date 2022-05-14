using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MediatR;
using System.Threading.Tasks;
using Calculadora.Aplicacao.CasosDeUso.CalcularJurosComposto;
using System;

namespace Calculadora.API.Controllers
{
    [ApiController]
    [Route("")]
    public class ShowMeTheCode : Controller
    {
        readonly IConfiguration _configuration;
        
        public ShowMeTheCode(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("showmethecode")]
        public ActionResult ObterLinkGit()
        {
            var url = _configuration.GetValue<string>("UrlGithub");
            return Ok(_configuration.GetValue<string>("UrlGithub"));
        }
    }
}
