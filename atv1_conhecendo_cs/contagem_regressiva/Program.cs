Console.WriteLine("Digite um número para realizar a contagem regressiva:");
int input = int.Parse(Console.ReadLine());

while (input != 0)
{
    int decresce = input - 1;
    Console.WriteLine(decresce);
    input = decresce;
}