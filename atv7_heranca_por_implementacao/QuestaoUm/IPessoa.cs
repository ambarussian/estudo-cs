using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoUm
{
    public interface IPessoa
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Cpf { get; set; }

        void MostrarDetalhes(); 

    }
}
