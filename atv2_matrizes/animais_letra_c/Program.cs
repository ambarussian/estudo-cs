Console.WriteLine("Digite o nome de 5 animais para verificação:");
string[] matrizNomes = new string[5];
int animalC = 0;

for (int i = 0; i < matrizNomes.Length; i++)
{
    matrizNomes[i] = Console.ReadLine();
    if (matrizNomes[i].StartsWith("C", StringComparison.OrdinalIgnoreCase))
    {
        animalC++;
    }
}

Console.WriteLine("\n\nOs animais digitados foram: ");
    foreach (string animal in matrizNomes){
        Console.WriteLine(animal);
    }
Console.WriteLine($"\nDestes, {animalC} animais começam com C");