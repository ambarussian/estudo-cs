Console.WriteLine("Digite 5 cores:");
string[] matrizCores = new string[5];
int primaria = 0;

for(int i = 0; i < matrizCores.Length; i++)
{
    matrizCores[i] = Console.ReadLine().ToLower();
    if (matrizCores[i] == "amarelo" || matrizCores[i] == "azul" || matrizCores[i] == "vermelho") 
    {
        primaria++;
    }
}

Console.WriteLine($"\n\nDas cores digitadas, cores primárias apareceram {primaria} vezes");
