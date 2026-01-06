using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoDois
{
    public abstract class Veiculo(string modelo, string placa, string marca, decimal preco, int ano) : IVeiculo
    {
        public string Modelo { get; set; }
        public string Placa { get;  set; }
        public string Marca { get;  set; }
        public decimal Preco { get; set; }
        public int Ano { get; set; }

        public abstract void ExibirDetalhes();
    }
}
