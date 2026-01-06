Console.WriteLine("Digite o nome de cinco cidades:");
string[] matrizCidades = new string[5];

for (int i = 0; i < matrizCidades.Length; i++)
{
    matrizCidades[i] = Console.ReadLine();
    if (matrizCidades[i].StartsWith("S", StringComparison.OrdinalIgnoreCase))
    {
        matrizCidades[i] = "";
    }
}

Console.WriteLine("\n\nCidades digitadas que não começam com S:");
foreach (string cidade in matrizCidades)
{
    Console.WriteLine(cidade);
}
