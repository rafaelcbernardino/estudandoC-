using secao4_aula40_exercitando_classes;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa primeiraPessoa, segundaPessoa;

            primeiraPessoa = new Pessoa();
            segundaPessoa = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");

            //digitando o nome da primeira pessoa
            Console.Write("Nome: ");
            primeiraPessoa.nome = Console.ReadLine();
            //digitando a idade da primera pessoa
            Console.Write("Idade: ");
            primeiraPessoa.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");

            //digitando o nome da segunda pessoa
            Console.Write("Nome: ");
            segundaPessoa.nome = Console.ReadLine();
            //digitando a idade da segunda pessoa
            Console.Write("Idade: ");
            segundaPessoa.idade = int.Parse(Console.ReadLine());

            if (primeiraPessoa.idade > segundaPessoa.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + primeiraPessoa.nome);
            }
            else if(primeiraPessoa.idade == segundaPessoa.idade)
            {
                Console.WriteLine("As duas pessoas possuem a mesma idade.");
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + segundaPessoa.nome);
            }
        }
    }
}