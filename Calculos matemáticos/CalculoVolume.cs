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

            Console.WriteLine($"Volune do Esfera =   {volumeEsfera.ToString("F2", CultureInfo.InvariantCulture)} cm³");
        }

        public void cubo()
        {
            Console.Write("Informe a Largura: ");
            double largura = double.Parse(Console.ReadLine());
            double volumeCubo = Math.Pow(largura, 3);
            
            // V = L^3
            Console.WriteLine($"Volune do cubo =   {volumeCubo.ToString("F2", CultureInfo.InvariantCulture)} cm³");
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

             Console.WriteLine($"Volune do Paralelepipedo =   {volumeParalelepipedo.ToString("F2", CultureInfo.InvariantCulture)} cm³");
        }

        public void cone()
        {
            Console.Write("Informe a Raio: ");
            double raio = double.Parse(Console.ReadLine());
            Console.Write("Informe a Altura: ");
            double altura = double.Parse(Console.ReadLine());
            
            // V = (pi * R^2 * h) / 3
            double volumeCone = (pi * Math.Pow(raio,2) * altura) / 3;

             Console.WriteLine($"Volune do Cone =   {volumeCone.ToString("F2", CultureInfo.InvariantCulture)} cm³");
        }

        public void piramide()
        {
            Console.Write("Informe o Lado: ");
            double lado = double.Parse(Console.ReadLine());
            Console.Write("Informe a Altura: ");
            double altura = double.Parse(Console.ReadLine());

            // area da base de uma piramide vai ser areaBase = lado^2
            double areaBase = Math.Pow(lado, 2);

            // V = (areaBase * altura) / 3
            double volumePiramide = (areaBase * altura) / 3;

           Console.WriteLine($"Volune do Pirâmide =   {volumePiramide.ToString("F2", CultureInfo.InvariantCulture)} cm³");
        }

        public void cilindro()
        {
            Console.Write("Informe o Raio: ");
            double raio = double.Parse(Console.ReadLine());
            Console.Write("Informe a Altura: ");
            double altura = double.Parse(Console.ReadLine());

            // V = pi * R^2 * h
            double volumeCilindro = Math.Pow(raio, 2) * pi * altura;

            Console.WriteLine($"Volune do Cilindro =   {volumeCilindro.ToString("F2", CultureInfo.InvariantCulture)} cm³");
        }
    }
}