using System;

public class Retangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public double CalcularPerimetro()
    {
        return (Base * 2) + (Altura * 2);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();
        Console.WriteLine("Digite a base do retângulo: ");
        retangulo.Base = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura do retângulo: ");
        retangulo.Altura = double.Parse(Console.ReadLine());

        Console.WriteLine($"O perímetro do retângulo é: {retangulo.CalcularPerimetro()}");

    }
}
