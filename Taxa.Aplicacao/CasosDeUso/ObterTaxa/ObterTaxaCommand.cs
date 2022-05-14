using MediatR;

namespace Taxa.Aplicacao.CasosDeUso.ObterTaxa
{
    public sealed class ObterTaxaCommand : IRequest<Taxa.Dominio.Entidades.Taxa>
    {
    }
}
