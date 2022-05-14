using Calculadora.Aplicacao.Configuracao;
using System.Threading;
using System.Threading.Tasks;

namespace Calculadora.Aplicacao.Interfaces
{
    public interface IWebServiceGet<T>
    {
        Task<T> GetAsync(WebGetOption configuracao, CancellationToken cancellationToken);
    }
}
