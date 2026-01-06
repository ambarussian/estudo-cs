using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoDois
{
    public interface IVeiculo
    {
        string Modelo { get; set; }
        string Placa {  get; set; }
        string Marca { get; set; }
        decimal Preco { get; set; }
        int Ano { get; set; }

        void ExibirDetalhes();
    }
}
