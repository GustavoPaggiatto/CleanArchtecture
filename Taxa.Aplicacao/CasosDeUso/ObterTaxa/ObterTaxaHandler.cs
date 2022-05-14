using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Taxa.Aplicacao.Interfaces;

namespace Taxa.Aplicacao.CasosDeUso.ObterTaxa
{
    public sealed class ObterTaxaHandler : IRequestHandler<ObterTaxaCommand, Dominio.Entidades.Taxa>
    {
        readonly ITaxaRepositorio _repositorio;

        public ObterTaxaHandler(ITaxaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<Dominio.Entidades.Taxa> Handle(ObterTaxaCommand request, CancellationToken cancellationToken)
        {
            var taxa = await _repositorio.ObterTaxaAsync(cancellationToken);
            return taxa;
        }
    }
}
