using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoUm
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }
        public string Departamento { get; set; }

        public Professor(int id, string nome, string cpf,  decimal salario, string departamento) : base(id, nome, cpf)
        {
            Salario = salario;
            Departamento = departamento;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"{Nome} {Cpf} {Salario} {Departamento} ");
        }
    }
}
