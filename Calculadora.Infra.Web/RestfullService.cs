using Calculadora.Aplicacao.Configuracao;
using Calculadora.Aplicacao.Interfaces;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Calculadora.Infra.Web
{
    public sealed class RestfullService<T> : IWebServiceGet<T>
    {
        public async Task<T> GetAsync(WebGetOption configuracao, CancellationToken cancellationToken)
        {
            T result;

            cancellationToken.ThrowIfCancellationRequested();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(configuracao.Url, cancellationToken);
                result = await response.Content.ReadAsAsync<T>(cancellationToken);
            }

            return result;
        }
    }
}
