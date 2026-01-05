Console.WriteLine("Informe um número para cálculo de fatorial:");
int numero = int.Parse(Console.ReadLine());
int fatorial = 1;

for (int i = 1; i <= numero; i++)
{
    fatorial *= i;
}

Console.WriteLine($"O fatorial de {numero} é {fatorial}");