Console.WriteLine("Digite 5 números inteiros para o somatório:");
int[] matrizSoma = new int[5];
int soma = 0;

for (int i = 0; i < 5; i++)
{
    matrizSoma[i] = int.Parse(Console.ReadLine());
    soma = soma + matrizSoma[i];
}

Console.WriteLine($"A soma de todos os números digitados resultam em {soma}");
