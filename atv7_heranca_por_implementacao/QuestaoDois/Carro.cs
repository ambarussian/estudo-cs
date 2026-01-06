using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoDois
{
    public class Carro : Veiculo
    {
        public bool Cambio {  get; set; }
        public int NumeroPassageiros { get; set; }

        public Carro(string modelo, string placa, string marca, decimal preco, int ano, bool cambio, int numeroPassageiros) : base(modelo, placa, marca, preco, ano)
        {
            Cambio = cambio;
            NumeroPassageiros = numeroPassageiros;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"{Modelo} {Marca} {Cambio} {NumeroPassageiros}");
        }
    }
}
