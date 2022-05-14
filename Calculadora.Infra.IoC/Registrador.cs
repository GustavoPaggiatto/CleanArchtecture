using Calculadora.Aplicacao.CasosDeUso.CalcularJurosComposto;
using Calculadora.Aplicacao.Configuracao;
using Calculadora.Aplicacao.Interfaces;
using Calculadora.Infra.Web;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Calculadora.Infra.IoC
{
    public static class Registrador
    {
        public static void RegistrarDependencias(IServiceCollection services)
        {
            services.AddScoped<IWebServiceGet<ValorTaxaResponse>, RestfullService<ValorTaxaResponse>>();
            services.AddMediatR(typeof(Calculadora.Aplicacao.CasosDeUso.CalcularJurosComposto.CalcularJurosCompostoHandler));
            services.AddOptions<WebGetOption>()
                .Configure<IConfiguration>(
                    (opt, config) => opt.Url = config.GetValue<string>("UrlGet"));
            services.AddOptions<WebGetOption>()
                .Configure<IConfiguration>(
                (opt, config) => opt.Url = config.GetValue<string>("UrlGithub"));
        }
    }
}
