using System.Threading;
using System.Threading.Tasks;

namespace Taxa.Aplicacao.Interfaces
{
    public interface ITaxaRepositorio
    {
        Task<Taxa.Dominio.Entidades.Taxa> ObterTaxaAsync(CancellationToken cancallationToken);
    }
}
