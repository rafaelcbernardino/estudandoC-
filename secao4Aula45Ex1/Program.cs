using secao4Aula45Ex1;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            retangulo.altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            retangulo.largura = double.Parse(Console.ReadLine());

            Console.Write(retangulo);
        }
    }
}