using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaAstral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            CalculadoraSigno calc = new CalculadoraSigno();

            Console.WriteLine("Qual seu nome?");
            usuario.nome = Console.ReadLine();

            Console.WriteLine("Qual o dia do seu nascimento?");
            usuario.diaNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o mês do seu nascimento?");
            usuario.mesNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Calculando .... \n");

            usuario.signo = calc.Calcular(usuario.diaNascimento, usuario.mesNascimento);
            Console.WriteLine(usuario.nome + ", o seu signo é " + usuario.signo.nome + ": \n" + usuario.signo.descricao);
            Console.ReadLine();


        }
    }
}
