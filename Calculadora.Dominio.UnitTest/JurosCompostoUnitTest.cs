using Calculadora.Dominio.VO;
using System;
using Xunit;

namespace Calculadora.Dominio.UnitTest
{
    public class JurosCompostoUnitTest
    {
        [Fact(DisplayName = "Set do valor inicial menor que zero.")]
        public void SetValorInicial_MenorQueZero_Excessao()
        {
            double valorInicial = -1;
            int tempo = 1;
            double valorTaxa = 0.01;

            var excessao = Assert.Throws<InvalidOperationException>(() => new JurosComposto(valorInicial, tempo, valorTaxa));

            Assert.Equal("O valor inicial não deve ser negativo.", excessao.Message);
        }

        [Fact(DisplayName = "Set do tempo menor que zero.")]
        public void SetTempo_MenorQueZero_Excessao()
        {
            double valorInicial = 1;
            int tempo = -1;
            double valorTaxa = 0.01;

            var excessao = Assert.Throws<InvalidOperationException>(() => new JurosComposto(valorInicial, tempo, valorTaxa));

            Assert.Equal("O tempo não deve ser negativo.", excessao.Message);
        }

        [Fact(DisplayName = "Verificação do cálculo do juros composto em um mês.")]
        public void Calcular_JurosCompostoUmMes_ValorFinal()
        {
            double valorInicial = 1;
            int tempo = 1;
            double valorTaxa = 0.01;

            double resultado = new JurosComposto(valorInicial, tempo, valorTaxa).Calcular();

            Assert.Equal(1.01, resultado);
        }

        [Fact(DisplayName = "Verificação do cálculo do juros composto em cinco meses.")]
        public void Calcular_JurosCompostoCincoMeses_ValorFinal()
        {
            double valorInicial = 1;
            int tempo = 5;
            double valorTaxa = 0.01;

            double resultado = new JurosComposto(valorInicial, tempo, valorTaxa).Calcular();

            Assert.Equal(1.05, resultado);
        }
    }
}
