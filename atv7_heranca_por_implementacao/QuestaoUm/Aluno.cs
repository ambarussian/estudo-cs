using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestaoUm
{
    public class Aluno : Pessoa
    {
        public string RegistroAcademico { get; set; }
        public string Curso { get; set; }
        public int Periodo { get; set; }

        public Aluno(int id, string nome, string cpf, string registroAcademico, string curso, int periodo) : base(id, nome, cpf)
        {
            RegistroAcademico = registroAcademico;
            Curso = curso;
            Periodo = periodo;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"{Nome} {Cpf} {RegistroAcademico} {Curso} {Periodo}°");
        }

    }
}
