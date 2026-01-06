using System.Runtime.InteropServices;

Console.WriteLine("Digite 5 números para verificar se são pares:");
int[] matriz = new int[5];

for (int i = 0; i < 5; i++) {
    matriz[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Os números pares são:");
foreach (int num in matriz)
{
    if (num % 2 == 0)
    {
        Console.WriteLine(num);
    }
}

