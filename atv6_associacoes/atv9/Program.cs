namespace atv9
{
    public class Peca
    {
        public string Titulo { get; set; }
        public string Diretor { get; set; }

        public Peca(string titulo, string diretor)
        {
            Titulo = titulo;
            Diretor = diretor;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}, Diretor: {Diretor}";
        }
    }
    //---------------------------------------------------------------
    public class Teatro
    {
        private List<Peca> programacao;
        public Teatro()
        {
            programacao = new List<Peca>();
        }

        public void AgendarPeca(Peca peca)
        {
            programacao.Add(peca);
            Console.WriteLine($"Peça agendada: {peca}");
        }

        public void CancelarPeca(Peca peca)
        {
            if (programacao.Remove(peca))
            {
                Console.WriteLine($"Peça cancelada: {peca}");
            }
            else
            {
                Console.WriteLine("Peça não encontrada na programação.");
            }
        }

        public void ListarPecas()
        {
            Console.WriteLine("Programação do teatro:");
            foreach (var peca in programacao)
            {
                Console.WriteLine(peca);
            }
        }
    }
    //---------------------------------------------------------------
    public class Program
    {
        public static void Main()
        {
            Teatro teatro = new Teatro();

            Peca peca1 = new Peca("Romeu e Julieta", "William Shakespeare");
            Peca peca2 = new Peca("Chicago", "John Kander");

            teatro.AgendarPeca(peca1);
            teatro.AgendarPeca(peca2);
            teatro.ListarPecas();
            teatro.CancelarPeca(peca1);
            teatro.ListarPecas();
        }
    }
}