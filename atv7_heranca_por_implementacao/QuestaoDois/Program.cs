namespace QuestaoDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new("Gol", "123456", "Volkswagen", 13000, 2010, false, 5);
            Moto moto = new("Kawasaki Ninja", "234567", "Bis", 6000, 2017, 2500);
            Caminhao caminhao = new("Caminhao", "345678", "Mercedes", 100000, 2019, 3, 90.750);

            carro.ExibirDetalhes();
            moto.ExibirDetalhes();
            caminhao.ExibirDetalhes();
        }
    }
}
