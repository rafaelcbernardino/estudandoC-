using secao4_aula42_estoque;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Digite os dados do produto a ser cadastrado no estoque.");

            Console.Write("Nome: ");
            produto.nomeProduto = Console.ReadLine();

            Console.Write("Preço: ");
            produto.preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em estoque: ");
            produto.quantidade = int.Parse(Console.ReadLine());

            produto.AdicionarProduto();

            Console.WriteLine(produto.ValorTotalEmEstoque());

            Console.WriteLine("Digite a quantidade de entrada no estoque:");
            produto.quantidade = int.Parse(Console.ReadLine());

            produto.AdicionarProduto();
            Console.WriteLine(produto.ValorTotalEmEstoque());

            Console.WriteLine("Digite a quantidade de saída no estoque:");
            produto.quantidade = int.Parse(Console.ReadLine());

            produto.RemoverProduto();
            Console.WriteLine(produto.ValorTotalEmEstoque());

        }
    }
}