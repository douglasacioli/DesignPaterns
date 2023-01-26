using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ExemploSemStrategy.service.frete;

namespace ExemploSemStrategy.service
{
    public class TipoFrete
    {
        public Frete frete { get; set; }
        
        public void calcularPreco(int distancia)
        {
            System.Console.WriteLine($"o valor do Frete é R$: {frete.calcularPreco(distancia).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    
    }
}