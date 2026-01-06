using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoDois
{
    public class Caminhao : Veiculo
    {
        public int Eixos {  get; set; }
        public double CargaMaxima { get; private set; }

        public Caminhao(string modelo, string placa, string marca, decimal preco, int ano, int eixos, double cargaMaxima) : base(modelo, placa, marca, preco, ano)
        {
             Eixos = eixos;
            CargaMaxima = cargaMaxima;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"{Modelo} {Marca} {Eixos} {CargaMaxima}");
        }
    }
}
