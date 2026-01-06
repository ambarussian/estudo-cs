using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoUm
{
    public abstract class Pessoa(int id, string nome, string cpf) : IPessoa
    {
        public int Id { get; set; } = id;
        public string Nome { get; set; } = nome;
        public string Cpf { get; set; } = cpf;

        public abstract void MostrarDetalhes();

    }
}
