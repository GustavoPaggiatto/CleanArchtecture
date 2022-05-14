using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Taxa.Aplicacao.Interfaces;
using Taxa.Infra.Repositorio;

namespace Taxa.Infra.IoC
{
    public static class Registrador
    {
        public static void RegistrarDependencias(IServiceCollection services)
        {
            services.AddScoped<ITaxaRepositorio, TaxaRepositorio>();
            services.AddMediatR(typeof(Taxa.Aplicacao.CasosDeUso.ObterTaxa.ObterTaxaHandler));
        }
    }
}
