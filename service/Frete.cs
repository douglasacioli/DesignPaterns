using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploSemStrategy.service
{
    public class Frete
    {
        public TipoFrete tipo { get; set; }

        public Frete(TipoFrete tipoFrete)
        {
            tipo = tipoFrete;
        }

        public double calcularPreco(int distancia)
        {
            double preco = 0;
            if(TipoFrete.Normal.Equals(tipo))
            {
                preco = distancia * 1.25 +10;
            }
            else if (TipoFrete.Sedex.Equals(tipo))
            {
                preco = distancia * 1.45 + 12;
            }

            return preco;
        }
        
    }
}