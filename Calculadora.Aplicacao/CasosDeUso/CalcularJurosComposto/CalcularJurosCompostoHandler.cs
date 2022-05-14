using Calculadora.Aplicacao.Configuracao;
using Calculadora.Aplicacao.Interfaces;
using Calculadora.Dominio.VO;
using MediatR;
using Microsoft.Extensions.Options;
using System.Threading;
using System.Threading.Tasks;

namespace Calculadora.Aplicacao.CasosDeUso.CalcularJurosComposto
{
    public sealed class CalcularJurosCompostoHandler : IRequestHandler<CalcularJurosCompostoCommand, double>
    {
        readonly IWebServiceGet<ValorTaxaResponse> _webServiceGet;
        readonly WebGetOption _configuracao;

        public CalcularJurosCompostoHandler(
            IWebServiceGet<ValorTaxaResponse> webServiceGet,
            IOptions<WebGetOption> configuracao)
        {
            _webServiceGet = webServiceGet;
            _configuracao = configuracao.Value;
        }

        public async Task<double> Handle(CalcularJurosCompostoCommand request, CancellationToken cancellationToken)
        {
            var taxa = await _webServiceGet.GetAsync(_configuracao, cancellationToken);
            var juros = this.BuildJurosComposto(request, taxa.Valor);

            return juros.Calcular();
        }

        private JurosComposto BuildJurosComposto(CalcularJurosCompostoCommand request, double taxa)
        {
            return new JurosComposto(request.ValorInicial, request.Tempo, taxa);
        }
    }
}
