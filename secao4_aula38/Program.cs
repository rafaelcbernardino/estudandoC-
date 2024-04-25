using secao4_aula38;
using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            double areaX, areaY, p;

            Console.WriteLine("Entre com as medidas do triangulo X:");

            x.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (x.LadoA + x.LadoB + x.LadoC) / 2.0;

            areaX = Math.Sqrt(p * (p - x.LadoA) * (p - x.LadoB) * (p - x.LadoC));

            Console.WriteLine("Entre com as medias do tringulo Y:");

            y.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (y.LadoA + y.LadoB + y.LadoC) / 2.0;

            areaY = Math.Sqrt(p * (p - y.LadoA) * (p - y.LadoB) * (p - y.LadoC));

            Console.WriteLine("A área do triangulo X é: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A área do triangulo Y é: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            }
            else if(areaX == areaY)
            {
                Console.WriteLine("As áreas dos triangulos X e Y são iguais");
            }
            else
            {
                Console.WriteLine("Maior área: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            }
        }
    }
}