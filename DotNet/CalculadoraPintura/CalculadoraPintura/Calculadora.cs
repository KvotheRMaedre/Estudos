using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    internal class Calculadora
    {
        public double areaParede;
        public double areaTeto;
        public double litragemNecessaria;

        public double CalcularAreaParedes(double largura, double altura, double profundidade)
        {
            areaParede = 2 * (largura + profundidade) * altura;
            return areaParede;
        }

        public double CalcularAreaTeto(double largura, double profundidade)
        {
            areaTeto = largura * profundidade;
            return areaTeto;
        }

        public double CacularLitragemNecessaria()
        {
            litragemNecessaria = (areaParede + areaTeto) / 10;
            return litragemNecessaria;
        }

    }
}
