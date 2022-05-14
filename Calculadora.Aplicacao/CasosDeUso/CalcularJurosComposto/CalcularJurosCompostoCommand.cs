using MediatR;

namespace Calculadora.Aplicacao.CasosDeUso.CalcularJurosComposto
{
    public sealed class CalcularJurosCompostoCommand : IRequest<double>
    {
        public double ValorInicial { get; set; }
        public int Tempo { get; set; }
    }
}
