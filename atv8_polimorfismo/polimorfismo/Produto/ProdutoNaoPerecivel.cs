using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo.Produto
{
    public class ProdutoNaoPerecivel : Produto
    {
        public DateTime DataFabricacao { get; set; }
        public int ValidadeDias { get; set; }

        public override DateTime CalcularValidade()
        {
            return DataFabricacao.AddDays(ValidadeDias);
        }
    }
}
