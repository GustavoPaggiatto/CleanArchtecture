using System.Threading;
using System.Threading.Tasks;
using Taxa.Aplicacao.Interfaces;

namespace Taxa.Infra.Repositorio
{
    public sealed class TaxaRepositorio : ITaxaRepositorio
    {
        const double VALOR = 0.01;

        public async Task<Dominio.Entidades.Taxa> ObterTaxaAsync(CancellationToken cancallationToken)
        {
            cancallationToken.ThrowIfCancellationRequested();
            return await Task.Run(() => new Dominio.Entidades.Taxa(1, VALOR));
        }
    }
}
