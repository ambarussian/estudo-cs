Console.WriteLine("Informe seu nome:");
string nome = Console.ReadLine();

Console.WriteLine($"Olá, {nome}! Por favor informe suas notas para realizar o cálculo da média.");
Console.WriteLine("\nNota de matemática:");
float mat = float.Parse(Console.ReadLine());
Console.WriteLine("\nNota de português:");
float port = float.Parse(Console.ReadLine());
Console.WriteLine("\nNota de história:");
float hist = float.Parse(Console.ReadLine());
Console.WriteLine("\nNota de ciências:");
float cien = float.Parse(Console.ReadLine());
Console.WriteLine("\nNota de educação física:");
float edfis = float.Parse(Console.ReadLine());

float media = (mat + port + hist + cien + edfis) / 5;
Console.WriteLine($"\n{nome}, sua média final é {media}.");