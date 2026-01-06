using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo.Produto
{
    internal class ProgramProduto
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>
            {
                new ProdutoPerecivel {Nome = "Tomate", Codigo = 1, DataFabricacao = new DateTime(2001, 1, 1), ValidadeDias = 12},
                new ProdutoNaoPerecivel {Nome = "Ketchup", Codigo = 11, DataFabricacao = new DateTime(2001, 1, 1), ValidadeDias = 70}
            };
            foreach (var produto in produtos)
            {
                Console.WriteLine($"A validade do produto {produto.Nome} é de {produto.CalcularValidade()}"); 
            }
        }
    }
}
