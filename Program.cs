using ExemploSemStrategy.service;
using ExemploSemStrategy.service.frete;

Console.WriteLine("Informe a distancia");

int distancia = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Qual o tipo de Frete (1) Normal, (2) Sedex: ");

int? opcaoFrete = Convert.ToInt32(Console.ReadLine());

TipoFrete tipoFrete = new TipoFrete();

if (opcaoFrete == 1)
{
    tipoFrete.frete = new Normal();
    tipoFrete.calcularPreco(distancia);
}
if (opcaoFrete == 2)
{
    tipoFrete.frete = new Sedex();
    tipoFrete.calcularPreco(distancia);
}