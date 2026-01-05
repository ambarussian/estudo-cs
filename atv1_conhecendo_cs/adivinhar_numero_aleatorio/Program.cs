using System;

Console.WriteLine("Olá! Te convido a jogar um jogo simples que consiste em adivinhar um número aleatório de 1 a 50 que escolhi.\n");
Console.WriteLine("Te darei algumas dicas informando se o número que você supõe que seja o certo é maior ou menor ao que pensei!\n");
Console.WriteLine("Vamos nessa!? :D\n\n");

Random random = new Random();
int num = random.Next(1, 51);

Console.WriteLine("Bom... para começar, digite seu palpite: ");
int palpite = int.Parse(Console.ReadLine());

while (palpite != num)
{

    if (palpite < num)
    {
        Console.WriteLine("\nPensei num número maior... Tente de novo: ");
        palpite = int.Parse(Console.ReadLine());
    }

    else if (palpite > num)
    {
        Console.WriteLine("\nPensei num número menor... Tente de novo: ");
        palpite = int.Parse(Console.ReadLine());
    }
    
    else if (!int.TryParse(Console.ReadLine(), out palpite))
    {
        Console.Write("\nEsse número é inválido :(! Digite outro: ");
        palpite = int.Parse(Console.ReadLine());
    }

}

if (palpite == num)
{
    Console.WriteLine($"Realmente pensei no número {num}!\nParabéns! Você acertou! ^^");
}