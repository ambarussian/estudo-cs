namespace atv6
{
    public class Obra
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }

        public Obra(string titulo, string artista)
        {
            Titulo = titulo;
            Artista = artista;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}, Artista: {Artista}";
        }
    }
    //---------------------------------------------------------------
    public class Museu
    {
        private List<Obra> exposicao;

        public Museu()
        {
            exposicao = new List<Obra>();
        }

        public void AdicionarObra(Obra obra)
        {
            exposicao.Add(obra);
            Console.WriteLine($"Obra adicionada: {obra}");
        }

        public void RemoverObra(Obra obra)
        {
            if (exposicao.Remove(obra))
            {
                Console.WriteLine($"Obra removida: {obra}");
            }
            else
            {
                Console.WriteLine("Obra não encontrada na exposição.");
            }
        }

        public void ListarObras()
        {
            Console.WriteLine("Obras na exposição:");
            foreach (var obra in exposicao)
            {
                Console.WriteLine(obra);
            }
        }
    }
    //---------------------------------------------------------------
    public class Program
    {
        public static void Main()
        {
            Museu museu = new Museu();

            Obra obra1 = new Obra("Os Girassóis", "Vincent Van Gogh");
            Obra obra2 = new Obra("O Grito", "Edvard Munch");

            museu.AdicionarObra(obra1);
            museu.AdicionarObra(obra2);
            museu.ListarObras();
            museu.RemoverObra(obra1);
            museu.ListarObras();
        }
    }
}