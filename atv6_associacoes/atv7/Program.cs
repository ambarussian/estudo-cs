namespace atv7
{
    public class Prato
    {
        public string Nome { get; set; }
        public List<string> Ingredientes { get; set; }

        public Prato(string nome, List<string> ingredientes)
        {
            Nome = nome;
            Ingredientes = new List<string>(ingredientes);
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Ingredientes: {string.Join(", ", Ingredientes)}";
        }
    }
    //---------------------------------------------------------------
    public class Restaurante
    {
        private List<Prato> menu;
        public Restaurante()
        {
            menu = new List<Prato>();
        }

        public void AdicionarPrato(Prato prato)
        {
            menu.Add(prato);
            Console.WriteLine($"Prato adicionado: {prato}");
        }

        public void RemoverPrato(Prato prato)
        {
            if (menu.Remove(prato))
            {
                Console.WriteLine($"Prato removido: {prato}");
            }
            else
            {
                Console.WriteLine("Prato não encontrado no menu.");
            }
        }

        public void ListarPratos()
        {
            Console.WriteLine("Menu do restaurante:");
            foreach (var prato in menu)
            {
                Console.WriteLine(prato);
            }
        }
    }
    //---------------------------------------------------------------
    public class Program
    {
        public static void Main()
        {
            Restaurante restaurante = new Restaurante();

            List<string> ingredientes1 = new List<string> { "Frango", "Arroz", "Legumes" };
            Prato prato1 = new Prato("Frango com Arroz", ingredientes1);

            List<string> ingredientes2 = new List<string> { "Massa", "Tomate", "Manjericão" };
            Prato prato2 = new Prato("Massa ao Pomodoro", ingredientes2);

            restaurante.AdicionarPrato(prato1);
            restaurante.AdicionarPrato(prato2);
            restaurante.ListarPratos();
            restaurante.RemoverPrato(prato1);
            restaurante.ListarPratos();
        }
    }
}