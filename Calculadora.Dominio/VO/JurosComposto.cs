using System;

namespace Calculadora.Dominio.VO
{
    public sealed class JurosComposto
    {
        public double ValorInicial { get; private set; }
        public int Tempo { get; private set; }

        public double ValorTaxa { get; private set; }

        public JurosComposto(double valorInicial, int tempo, double valorTaxa)
        {
            this.SetValorInicial(valorInicial);
            this.SetTempo(tempo);
            this.SetTaxa(valorTaxa);
        }

        public void SetValorInicial(double valorInicial)
        {
            if (valorInicial < 0)
                throw new InvalidOperationException("O valor inicial não deve ser negativo.");

            this.ValorInicial = valorInicial;
        }

        public void SetTempo(int tempo)
        {
            if (tempo < 0)
                throw new InvalidOperationException("O tempo não deve ser negativo.");

            this.Tempo = tempo;
        }

        public void SetTaxa(double valor) => this.ValorTaxa = valor;

        public double Calcular()
        {
            var final = this.ValorInicial * Math.Pow(1 + this.ValorTaxa, this.Tempo);
            final = this.Truncate(final);

            return final;
        }

        private double Truncate(double valor) => Math.Truncate(valor * 100) / 100;
    }
}
