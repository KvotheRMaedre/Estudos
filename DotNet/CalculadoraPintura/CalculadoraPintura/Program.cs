using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraPintura;

namespace CalculadoraPintura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura;
            double altura;
            double profundidade;

            Calculadora calculadora = new Calculadora();

            Console.WriteLine("Qual a largura do cômodo?");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a profundidade do cômodo?");
            profundidade = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a altura do cômodo?");
            altura = double.Parse(Console.ReadLine());

            calculadora.areaParede = calculadora.CalcularAreaParedes(largura, altura, profundidade);

            calculadora.areaTeto = calculadora.CalcularAreaTeto(largura, profundidade); ;

            calculadora.litragemNecessaria = calculadora.CacularLitragemNecessaria();

            Console.WriteLine("Área das paredes é: ");
            Console.WriteLine(calculadora.areaParede);

            Console.WriteLine("Área do teto é: ");
            Console.WriteLine(calculadora.areaTeto);

            Console.WriteLine("A Quantidade de litros para pintar as paredes é: ");
            Console.WriteLine(calculadora.litragemNecessaria);

            Console.ReadLine();
        }
    }
}
