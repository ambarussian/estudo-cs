using System;
using System.Collections.Generic;

Console.WriteLine("Você deseja: \n1- Adicionar um produto\n2- Verificar um produto\n");
int opcao = int.Parse(Console.ReadLine());
var listaProdutos = new List<Produto>();

switch (opcao)
{
    case 1:
        Console.WriteLine("Informe o nome do produto:\n");
        string nomeProduto = Console.ReadLine();
        Console.WriteLine("\nInforme o preço do produto:\n");
        float precoProduto = float.Parse(Console.ReadLine());
        listaProdutos.Add(new Produto (nomeProduto, precoProduto));
        Console.WriteLine("Produto cadastrado!");
        break;

    case 2:
        Console.WriteLine("Lista de Produtos:");
        foreach (var prod in listaProdutos)
        {
            Console.WriteLine($"\nProduto: {prod.Nome}, Preço: {prod.Preco}\n");
        }
        break;
}

struct Produto
{
    public string Nome;
    public float Preco;

    public Produto(string nome, float preco)
    {
        Nome = nome;
        Preco = preco;
    }
}