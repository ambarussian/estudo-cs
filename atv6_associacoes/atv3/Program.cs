namespace atv3
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }

        public Aluno(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Matrícula: {Matricula}";
        }
    }
//---------------------------------------------------------------
    public class Escola
    {
        private List<Aluno> alunos;

        public Escola()
        {
            alunos = new List<Aluno>();
        }

        //metodo matricula
        public void MatricularAluno(Aluno aluno)
        {
            alunos.Add(aluno);
            Console.WriteLine($"Aluno matriculado: {aluno}");
        }

        //metodo desmatricula
        public void DesmatricularAluno(Aluno aluno)
        {
            if (alunos.Remove(aluno))
            {
                Console.WriteLine($"Aluno desmatriculado: {aluno}");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado na escola.");
            }
        }

        //metodo exibir
        public void ListarAlunos()
        {
            Console.WriteLine("Alunos na escola:");
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
//---------------------------------------------------------------
    public class Program
    {
        public static void Main()
        {
            Escola escola = new Escola();

            Aluno aluno1 = new Aluno("Pafúncio", "1234567");
            Aluno aluno2 = new Aluno("Praxedes", "7654321");

            escola.MatricularAluno(aluno1);
            escola.MatricularAluno(aluno2);
            escola.ListarAlunos();
            escola.DesmatricularAluno(aluno1);
            escola.ListarAlunos();
        }
    }
}