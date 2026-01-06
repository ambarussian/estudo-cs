namespace atv8
{
    public class Voo
    {
        public string Numero { get; set; }
        public string Destino { get; set; }

        public Voo(string numero, string destino)
        {
            Numero = numero;
            Destino = destino;
        }

        public override string ToString()
        {
            return $"Número: {Numero}, Destino: {Destino}";
        }
    }
    //---------------------------------------------------------------
    public class Aeroporto
    {
        private List<Voo> voos;

        public Aeroporto()
        {
            voos = new List<Voo>();
        }

        public void AdicionarVoo(Voo voo)
        {
            voos.Add(voo);
            Console.WriteLine($"Voo adicionado: {voo}");
        }

        public void CancelarVoo(Voo voo)
        {
            if (voos.Remove(voo))
            {
                Console.WriteLine($"Voo cancelado: {voo}");
            }
            else
            {
                Console.WriteLine("Voo não encontrado no aeroporto.");
            }
        }

        public void ListarVoos()
        {
            Console.WriteLine("Voos no aeroporto:");
            foreach (var voo in voos)
            {
                Console.WriteLine(voo);
            }
        }
    }
    //---------------------------------------------------------------
    public class Program
    {
        public static void Main()
        {
            Aeroporto aeroporto = new Aeroporto();

            Voo voo1 = new Voo("1234", "São Paulo");
            Voo voo2 = new Voo("5678", "Minas Gerais");

            aeroporto.AdicionarVoo(voo1);
            aeroporto.AdicionarVoo(voo2);
            aeroporto.ListarVoos();
            aeroporto.CancelarVoo(voo1);
            aeroporto.ListarVoos();
        }
    }
}