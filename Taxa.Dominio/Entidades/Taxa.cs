using System;

namespace Taxa.Dominio.Entidades
{
    public sealed class Taxa
    {
        public int Id { get; private set; }
        public double Valor { get; private set; }

        public Taxa(int id, double valor)
        {
            this.SetId(id);
            this.SetValor(valor);
        }

        public void SetId(int id)
        {
            if (id <= 0)
                throw new InvalidOperationException("O id da taxa não pode ser menor ou igual a zero.");
            
            this.Id = id;
        }

        public void SetValor(double valor)
        {
            if (valor <= 0)
                throw new InvalidOperationException("O valor da taxa não pode ser menor ou igual a zero.");

            this.Valor = valor;
        }
    }
}
