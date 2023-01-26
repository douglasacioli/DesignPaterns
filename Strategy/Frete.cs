using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploSemStrategy.service.frete
{
    public abstract class Frete
    {
        public abstract double calcularPreco(int distancia);
    }
}