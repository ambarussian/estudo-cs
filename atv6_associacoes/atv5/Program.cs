namespace atv5
{
    public class Musica
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }

        public Musica(string titulo, string artista)
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
    public class Playlist
    {
        private List<Musica> musicas;

        public Playlist()
        {
            musicas = new List<Musica>();
        }

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
            Console.WriteLine($"Música adicionada: {musica}");
        }

        public void RemoverMusica(Musica musica)
        {
            if (musicas.Remove(musica))
            {
                Console.WriteLine($"Música removida: {musica}");
            }
            else
            {
                Console.WriteLine("Música não encontrada na playlist.");
            }
        }

        public void ListarMusicas()
        {
            Console.WriteLine("Músicas na playlist:");
            foreach (var musica in musicas)
            {
                Console.WriteLine(musica);
            }
        }
    }
    //---------------------------------------------------------------
    public class Program
    {
        public static void Main()
        {
            Playlist playlist = new Playlist();

            Musica musica1 = new Musica("NO RULES", "The Hatters");
            Musica musica2 = new Musica("RUSSIAN STYLE", "The Hatters");

            playlist.AdicionarMusica(musica1);
            playlist.AdicionarMusica(musica2);
            playlist.ListarMusicas();
            playlist.RemoverMusica(musica1);
            playlist.ListarMusicas();
        }
    }
}