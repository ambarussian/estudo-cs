using System;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public bool EhMaiorDeIdade()
    {
        return Idade > 18;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();

        Console.WriteLine("Digite seu nome: ");
        pessoa.Nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        pessoa.Idade = int.Parse(Console.ReadLine());

        if (pessoa.EhMaiorDeIdade())
        {
            Console.WriteLine($"{pessoa.Nome} é maior de idade");
        }

        else
        {
            Console.WriteLine($"{pessoa.Nome} não é maior de idade");
        }
    }
}