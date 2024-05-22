using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace secao4_aula42_estoque
{
    public class Produto
    {
        public string nomeProduto;
        public double preco;
        public int quantidade;
        public int quantidadeEstoque;
        public double valorTotalEstoque;

        public void AdicionarProduto()
        {
            quantidadeEstoque = (quantidadeEstoque + quantidade);
            valorTotalEstoque = (valorTotalEstoque + (preco * quantidade));
        }

        public void RemoverProduto()
        {
            quantidadeEstoque = (quantidadeEstoque - quantidade);
            valorTotalEstoque = (valorTotalEstoque - (preco * quantidade));
        }

        public string ValorTotalEmEstoque()
        {
            return "Dados atualizados: " +  nomeProduto + ", $" + preco.ToString("F2") + ", " + quantidadeEstoque + " unidades, Total: $" + valorTotalEstoque.ToString("F2");
        }
    }
}
