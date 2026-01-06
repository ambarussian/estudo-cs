namespace atv4
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Preço: {Preco:C}";
        }
    }
    //---------------------------------------------------------------
    public class Loja
    {
        private List<Produto> inventario;

        public Loja()
        {
            inventario = new List<Produto>();
        }

        //metodo adiciona
        public void AdicionarProduto(Produto produto)
        {
            inventario.Add(produto);
            Console.WriteLine($"Produto adicionado: {produto}");
        }

        //metodo remove
        public void RemoverProduto(Produto produto)
        {
            if (inventario.Remove(produto))
            {
                Console.WriteLine($"Produto removido: {produto}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado no inventário.");
            }
        }

        //metodo exibir
        public void ListarProdutos()
        {
            Console.WriteLine("Inventário da loja:");
            foreach (var produto in inventario)
            {
                Console.WriteLine(produto);
            }
        }
    }
    //---------------------------------------------------------------
    public class Program
    {
        public static void Main()
        {
            Loja loja = new Loja();

            Produto produto1 = new Produto("Regata", 20.00);
            Produto produto2 = new Produto("Saia", 35.00);

            loja.AdicionarProduto(produto1);
            loja.AdicionarProduto(produto2);
            loja.ListarProdutos();
            loja.RemoverProduto(produto1);
            loja.ListarProdutos();
        }
    }
}