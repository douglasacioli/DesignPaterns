// See https://aka.ms/new-console-template for more information
using ExemploSemStrategy.service;

Console.WriteLine("Informe a distancia");

int distancia = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Qual o tipo de Frete (1) Normal, (2) Sedex: ");

int? opcaoFrete = Convert.ToInt32(Console.ReadLine());

TipoFrete tipofrete = new TipoFrete();

Frete frete = new Frete(tipofrete);

double preco = frete.calcularPreco(distancia);
System.Console.WriteLine($"O valor é de R$ {preco} ");