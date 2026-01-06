using System;

class Cliente
{
    public string Nome { get; set; }
    private string Endereco { get; set; }
    public void AtualizarEndereco(string novoEndereco)
    {
        Endereco = novoEndereco;
    }
    public string ObterEndereco()
    {
        return Endereco;
    }

    private string Telefone { get; set; }
    public void AtualizarTelefone(string novoTelefone)
    {
        Telefone = novoTelefone;
    }
    public string ObterTelefone()
    {
        return Telefone;
    }
}

//-----------------------------------------------------------------------------
//-----------------------------------------------------------------------------

class Conta
{
    private string NumeroConta { get; set; }
    public double Saldo { get; private set; }
    private Cliente Titular { get; set; }

    //Construtor da classe conta
    public Conta(string numeroConta, double saldoInicial, Cliente titular)
    {
        NumeroConta = numeroConta;
        Saldo = saldoInicial;
        Titular = titular;
    }
//-----------------------------------------------------------------------------
    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor inválido");
            return;
        }

        Saldo += (double)valor;
        Console.WriteLine($"Depósito de R${valor} realizado com sucesso!");
    }
//-----------------------------------------------------------------------------
    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor inválido");
            return;
        }

        if (valor > (decimal)Saldo)
        {
            Console.WriteLine("Saldo insuficiente");
            return;
        }

        Saldo = Saldo - (double)valor;
        Console.WriteLine($"Saque de R${valor} realizado com sucesso!");
    }
//-----------------------------------------------------------------------------
    public void Transferir(decimal valor, Conta contaDestino)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor inválido");
            return;
        }

        if (valor > (decimal)Saldo)
        {
            Console.WriteLine("Saldo insuficiente");
            return;
        }

        Saldo -= (double)valor;
        contaDestino.Depositar(valor);
        Console.WriteLine($"Transferência de R${valor} para a conta {contaDestino.NumeroConta} realizada com sucesso!");
    }
//-----------------------------------------------------------------------------
    public void ExibirSaldo()
{
    Console.WriteLine($"A conta {NumeroConta} tem saldo de R${Saldo}");
}
}

//-----------------------------------------------------------------------------
//-----------------------------------------------------------------------------

class Program
    {
        static void Main()
        {
            Cliente cliente1 = new Cliente();
            cliente1.Nome = "João";
            cliente1.AtualizarEndereco("Rua ABC, 123");
            cliente1.AtualizarTelefone("123456");
            Console.WriteLine($"Cliente: {cliente1.Nome}\nEndereço: {cliente1.ObterEndereco()}\nTelefone: {cliente1.ObterTelefone()}");

            Cliente cliente2 = new Cliente();
            cliente2.Nome = "Maria";
            cliente2.AtualizarEndereco("Rua DEF, 456");
            cliente2.AtualizarTelefone("654321");
            Console.WriteLine($"\n\nCliente: {cliente2.Nome}\nEndereço: {cliente2.ObterEndereco()}\nTelefone: {cliente2.ObterTelefone()}");

            Conta conta1 = new Conta("1", 1050.7, cliente1);
            Conta conta2 = new Conta("2", 129.0, cliente2);

            int opcao;

            do
            {
                Console.WriteLine("\n\n=================================");
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1. Depositar\n2. Sacar\n3. Transferir\n4. Exibir saldo\n5. Sair");
                Console.WriteLine("=================================\n");
                opcao = int.Parse(Console.ReadLine());

            while (opcao < 1 || opcao > 5)
            {
                Console.WriteLine("\nOpcão inválida, digite novamente:");
                opcao = int.Parse(Console.ReadLine());
            }

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o valor para depósito:");
                        decimal valorDeposito = decimal.Parse(Console.ReadLine());
                        conta1.Depositar(valorDeposito);
                        break;

                    case 2:
                        Console.Write("Digite o valor para saque:");
                        decimal valorSaque = decimal.Parse(Console.ReadLine());
                        conta1.Sacar(valorSaque);
                        break;

                    case 3:
                        Console.Write("Digite o valor para transferência:");
                        decimal valorTransferencia = decimal.Parse(Console.ReadLine());
                        conta1.Transferir(valorTransferencia, conta2);
                        break;

                    case 4:
                        conta1.ExibirSaldo();
                        break;

                    case 5:
                        Console.WriteLine("Saindo do programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 5);
    }
}