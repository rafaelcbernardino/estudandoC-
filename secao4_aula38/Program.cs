using secao4_aula38;
using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");

            x.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.CalcularAreaTriangulo();

            Console.WriteLine("Entre com as medias do tringulo Y:");

            y.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaY = y.CalcularAreaTriangulo();

            Console.WriteLine("A área do triangulo X é: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A área do triangulo Y é: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: " + x.CalcularAreaTriangulo().ToString("F4", CultureInfo.InvariantCulture));
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