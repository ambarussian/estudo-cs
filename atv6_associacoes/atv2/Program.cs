namespace atv2
{
        public class Funcionario
        {
            public string Nome { get; set; }
            public string Cargo { get; set; }

            public Funcionario(string nome, string cargo)
            {
                Nome = nome;
                Cargo = cargo;
            }

            public override string ToString()
            {
                return $"Nome: {Nome}, Cargo: {Cargo}";
            }
        }
//---------------------------------------------------------------
    public class Empresa
        {
            private List<Funcionario> funcionarios;

            public Empresa()
            {
                funcionarios = new List<Funcionario>();
            }

            //metodo contrata
            public void ContratarFuncionario(Funcionario funcionario)
            {
                funcionarios.Add(funcionario);
                Console.WriteLine($"Funcionário contratado: {funcionario}");
            }
            
            //metodo demite
            public void DemitirFuncionario(Funcionario funcionario)
            {
                if (funcionarios.Remove(funcionario))
                {
                    Console.WriteLine($"Funcionário demitido: {funcionario}");
                }
                else
                {
                    Console.WriteLine("Funcionário não encontrado na empresa.");
                }
            }

            //metodo exibe
            public void ListarFuncionarios()
            {
                Console.WriteLine("Funcionários da empresa:");
                foreach (var funcionario in funcionarios)
                {
                    Console.WriteLine(funcionario);
                }
            }
        }
//---------------------------------------------------------------
    public class Program
        {
            public static void Main()
            {
                Empresa empresa = new Empresa();

                Funcionario funcionario1 = new Funcionario("Pafúncio", "Backend");
                Funcionario funcionario2 = new Funcionario("Praxedes", "Frontend");

                empresa.ContratarFuncionario(funcionario1);
                empresa.ContratarFuncionario(funcionario2);
                empresa.ListarFuncionarios();
                empresa.DemitirFuncionario(funcionario1);
                empresa.ListarFuncionarios();
            }
        }
    }