Console.WriteLine("Digite 5 números:");
int?[] matrizNumeros = new int?[5];

for (int i = 0; i < matrizNumeros.Length; i++)
{
    matrizNumeros[i] = int.Parse(Console.ReadLine());
    if (matrizNumeros[i] % 2 != 0)
    {
        matrizNumeros[i] = null;
    }
}

Console.WriteLine("Números pares:");
foreach (int? pares in matrizNumeros)
{
    if (pares.HasValue)
    {
        Console.WriteLine(pares);
    }
}
