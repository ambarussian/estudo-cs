Console.WriteLine("Digite 5 países para ordenação alfabética reversa:");
string[] matrizPaises = new string[5];

for (int i = 0; i < matrizPaises.Length; i++)
{
    matrizPaises[i] = Console.ReadLine();
}

Array.Sort(matrizPaises);
Array.Reverse(matrizPaises);

Console.WriteLine("\n\nOs países digitados em ordem reversa:");
foreach (string pais in matrizPaises)
{
    Console.WriteLine(pais);
}