Console.WriteLine("Digite 5 frutas:");
string[] matrizFrutas = new string[5];

for (int i = 0; i < matrizFrutas.Length; i++)
{
    matrizFrutas[i] = Console.ReadLine();
}

Console.WriteLine($"\n\nPrimeira fruta: {matrizFrutas[0]}");
Console.WriteLine($"Última fruta: {matrizFrutas[matrizFrutas.Length - 1]}");