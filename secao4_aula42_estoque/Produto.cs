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

        public double ValorTotalEmEstoque()
        {
            return preco * quantidade;
        }

        public void AdicionarProduto(int qtd)
        {
            quantidade += qtd;
        }

        public void RemoverProduto(int qtd)
        {
            quantidade -= qtd;
        }

        public override string ToString()
        {
            return nomeProduto 
                + ", $" 
                + preco.ToString("F2") 
                + ", " 
                + quantidade
                + " unidades, Total: $" 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
