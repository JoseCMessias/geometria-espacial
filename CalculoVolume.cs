using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace formas_geométrica
{
    public class CalculoVolume : ICalculo
    { 
        double pi = 3.1415;

        public void esfera()
        {
            Console.Write("Informe o Raio: ");
            double raio = double.Parse(Console.ReadLine());

            // V = 4/3 PI * raio^3
            double volumeEsfera = pi * Math.Pow(raio, 3);

            Console.WriteLine("Volune da esfera = " + volumeEsfera.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void cubo()
        {
            Console.Write("Informe a Largura: ");
            double largura = double.Parse(Console.ReadLine());
            double volumeCubo = Math.Pow(largura, 3);
            
            // V = L^3
            Console.WriteLine("Volune do cubo = " + volumeCubo.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void paralelepido()
        {
            Console.Write("Informe a Largura: ");
            double largura = double.Parse(Console.ReadLine());
            Console.Write("Informe a Altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Informe a Base: ");
            double Base = double.Parse(Console.ReadLine());

            // V = B x L x h
            double volumeParalelepipedo = Base * largura * altura;

            Console.WriteLine("Volune do Paralelepipedo = " + volumeParalelepipedo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}