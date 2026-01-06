public class ConversorDeMoedas
{
    private static double Dolar = 4.97;
    private static double Euro = 5.39;

    public static double RealParaDolar(double valorReal)
    {
        return valorReal / Dolar;
    }

    public static double DolarParaReal(double valorDolar)
    {
        return valorDolar * Dolar;
    }

    public static double RealParaEuro(double valorReal)
    {
        return valorReal / Euro;
    }

    public static double EuroParaReal(double valorEuro)
    {
        return valorEuro * Euro;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha a conversão:\n1- Real para dólar\n2- Dólar para real\n3- Real para euro\n4- Euro para real");
        int opcao = int.Parse(Console.ReadLine());

        if (opcao > 4 || opcao < 1)
        {
            Console.WriteLine("Valor inválido, informe outro:");
            opcao = int.Parse(Console.ReadLine());
        }

        double valorConversao;
        double resultado;

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Informe o valor em reais: ");
                valorConversao = double.Parse(Console.ReadLine());
                resultado = ConversorDeMoedas.RealParaDolar(valorConversao);
                Console.WriteLine($"O valor em dólares é: {resultado}");
                break;

            case 2:
                Console.WriteLine("Informe o valor em dólares: ");
                valorConversao = double.Parse(Console.ReadLine());
                resultado = ConversorDeMoedas.DolarParaReal(valorConversao);
                Console.WriteLine($"O valor em reais é: {resultado}");
                break;

            case 3:
                Console.WriteLine("Informe o valor em reais: ");
                valorConversao = double.Parse(Console.ReadLine());
                resultado = ConversorDeMoedas.RealParaEuro(valorConversao);
                Console.WriteLine($"O valor em euros é: {resultado}");
                break;

            case 4:
                Console.WriteLine("Informe o valor em euros: ");
                valorConversao = double.Parse(Console.ReadLine());
                resultado = ConversorDeMoedas.EuroParaReal(valorConversao);
                Console.WriteLine($"O valor em reais é: {resultado}");
                break;
        }
    }
}