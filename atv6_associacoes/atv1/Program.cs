namespace atv1
{
    public class Biblioteca
    {
        private List<Livro> livros;

        //construtor
        public Biblioteca()
        {
            livros = new List<Livro>();
        }

        //metodo add livro
        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
            Console.WriteLine($"Livro adicionado: {livro}");
        }

        //metodo remove livro
        public void RemoverLivro(Livro livro)
        {
            if (livros.Remove(livro))
            {
                Console.WriteLine($"Livro removido: {livro}");
            }
            else
            {
                Console.WriteLine("Livro não encontrado na biblioteca.");
            }
        }

        //metodo exibir livro
        public void ListarLivros()
        {
            Console.WriteLine("Livros na biblioteca:");
            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }
        }
    }
//---------------------------------------------------------------
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        //construtor
        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}, Autor: {Autor}";
        }
    }
//---------------------------------------------------------------   
    public class Program
    {
        public static void Main()
        {
            Biblioteca biblioteca = new Biblioteca();

            Livro livro1 = new Livro("Caim", "José Saramago");
            Livro livro2 = new Livro("Ensaio Sobre a Cegueira", "José Saramago");

            biblioteca.AdicionarLivro(livro1);
            biblioteca.AdicionarLivro(livro2);
            biblioteca.ListarLivros();
            biblioteca.RemoverLivro(livro1);
            biblioteca.ListarLivros();
        }
    }
}