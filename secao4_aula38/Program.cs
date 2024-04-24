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
            double trianguloX1, trianguloX2, trianguloX3, trianguloY1, trianguloY2, trianguloY3, areaX, areaY, p;

            Console.WriteLine("Entre com as medidas do triangulo X:");

            trianguloX1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloX2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloX3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (trianguloX1 + trianguloX2 + trianguloX3) / 2.0;

            areaX = Math.Sqrt(p * (p - trianguloX1) * (p - trianguloX2) * (p - trianguloX3));

            Console.WriteLine("Entre com as medias do tringulo Y:");

            trianguloY1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloY2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloY3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (trianguloY1 + trianguloY2 + trianguloY3) / 2;

            areaY = Math.Sqrt(p * (p - trianguloY1) * (p - trianguloY2) * (p - trianguloY3));

            Console.WriteLine("A área do triangulo X é: " + areaX);
            Console.WriteLine("A área do triangulo Y é: " + areaY);

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: " + areaX);
            }
            else if(areaX == areaY)
            {
                Console.WriteLine("As áreas dos triangulos X e Y são iguais");
            }
            else
            {
                Console.WriteLine("Maior área: " + areaY);
            }
        }
    }
}