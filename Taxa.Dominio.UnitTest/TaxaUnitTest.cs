using System;
using Xunit;

namespace Taxa.Dominio.UnitTest
{
    public class TaxaUnitTest
    {
        [Fact(DisplayName = "Set Id menor ou igual a zero.")]
        public void SetId_MenorOuIgualZero_Excessao()
        {
            int id = -1;
            double valor = 1;

            var excessao = Assert.Throws<InvalidOperationException>(() => new Taxa.Dominio.Entidades.Taxa(id, valor));

            Assert.Equal("O id da taxa não pode ser menor ou igual a zero.", excessao.Message);
        }

        [Fact(DisplayName = "Set Valor menor ou igual a zero.")]
        public void SetValor_MenorOuIgualAZero_Excessao()
        {
            int id = 1;
            double valor = -1;

            var excessao = Assert.Throws<InvalidOperationException>(() => new Taxa.Dominio.Entidades.Taxa(id, valor));

            Assert.Equal("O valor da taxa não pode ser menor ou igual a zero.", excessao.Message);
        }
    }
}
