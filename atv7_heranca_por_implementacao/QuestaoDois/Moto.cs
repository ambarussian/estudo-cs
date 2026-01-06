using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoDois
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto(string modelo, string placa, string marca, decimal preco, int ano, int cilindradas) : base(modelo, placa, marca, preco, ano)
        {
            Cilindradas = cilindradas;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"{Modelo} {Marca} {Cilindradas}");
        }
    }
}
