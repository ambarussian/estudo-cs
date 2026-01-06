using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo.Produto
{
    /*Implemente uma hierarquia de classes para um sistema de gerenciamento
    de estoque, incluindo classes para ProdutoPerecivel, ProdutoNaoPerecivel,
    utilizando polimorfismo para calcular a validade de diferentes produtos.*/

    public abstract class Produto
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }

        public abstract DateTime CalcularValidade();

    }
}
