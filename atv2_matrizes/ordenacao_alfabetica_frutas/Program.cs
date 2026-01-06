Console.WriteLine("Digite 5 frutas para ordenação alfabética");
string[] matrizFrutas = new string[5];

for (int i = 0; i < matrizFrutas.Length; i++)
{
    matrizFrutas[i] = Console.ReadLine();
}

Array.Sort(matrizFrutas);
Console.WriteLine("\n\nFrutas digitadas em ordem alfabética:");

foreach (string frutas in matrizFrutas)
{
    Console.WriteLine(frutas);
}