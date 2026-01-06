using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoUm
{
    public class FuncionarioAdministrativo : Pessoa
    {
        public decimal Salario {  get; set; }
        public string Divisao { get; set; }

        public FuncionarioAdministrativo(int id, string nome, string cpf, decimal salario, string divisao) : base(id, nome, cpf)
        {
            Salario = salario;            
            Divisao = divisao;
        }

        
        public override void MostrarDetalhes()
        {
            Console.WriteLine($"{Nome} {Cpf} {Salario} {Divisao}");
        }
    
    }
}
