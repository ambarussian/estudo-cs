using System;

public class Aluno
{
    public string Nome { get; set; }
    public double[] Notas { get; set; }

    public double CalcularMedia()
    {
        double soma = 0;
        foreach (double nota in Notas)
        {
            soma = soma + nota;
        }
        return soma / Notas.Length;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();

        int materias;
        Console.WriteLine("Informe seu nome: ");
        aluno.Nome = Console.ReadLine();
        Console.WriteLine("Informe quantas matérias você tem: ");
        materias = int.Parse(Console.ReadLine());
        aluno.Notas = new double[materias];


        for (int i = 0; i < materias; i++)
        {
            Console.WriteLine($"Informe a nota da matéria {i + 1}: ");
            aluno.Notas[i] = double.Parse(Console.ReadLine());
        }

        double media = aluno.CalcularMedia();
        Console.WriteLine($"A média do aluno {aluno.Nome} é: {media}");
    }
}