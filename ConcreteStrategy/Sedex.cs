using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploSemStrategy.service.frete
{
    public class Sedex : Frete
    {
        public override double calcularPreco(int distancia)
        {
            return distancia * 1.45 + 12;
        }
    }
}