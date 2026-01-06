Console.WriteLine("Digite o nome de 5 países:");
string[] matrizPaises = new string[5];
int paises = 0;

for (int i = 0; i < matrizPaises.Length; i++)
{
    matrizPaises[i] = Console.ReadLine();
    if (matrizPaises[i].Length > 10)
    {
        paises++;
    }
}

Console.WriteLine($"\n\nDos países digitados, {paises} têm mais de 10 letras");