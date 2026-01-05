Console.WriteLine("Digite um número:");
var numeros = new List<int>();
int numero = int.Parse(Console.ReadLine());
numeros.Add(numero);

while (numero >= 0)
{
    Console.WriteLine("\nDigite outro número: ");
    numero = int.Parse(Console.ReadLine());
    if (numero >= 0)
    {
        numeros.Add(numero);
    }
}

Console.Write("Números digitados: ");
foreach (var num in numeros)
{
    Console.Write($"{num} ");
}