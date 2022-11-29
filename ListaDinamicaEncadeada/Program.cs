// See https://aka.ms/new-console-template for more information
using ListaDinamicaEncadeada;
using System.IO;

Console.WriteLine("Hello, World!");

List<Produto> lista = new List<Produto>();

lista.Add(new Produto(1, "Abacaxi", 5.0));
lista.Add(new Produto(2, "Feijao", 2.0));
lista.Add(new Produto(3, "Abacate", 5.0));
lista.Add(new Produto(4, "Arroz", 7.0));
lista.Add(new Produto(5, "Alface", 1.0));
lista.Add(new Produto(6, "Frango",11.0));


int opcao = 1;
var opcaoFim = "Y";

while (opcao != 0 || opcaoFim != "N")
{
    var precoTotal = 0.0;
   
    foreach (var item in lista)
{
    Console.Write("Codigo do produto: " + item.Codigo + " | ");
    Console.Write("Nome do produto: " + item.Nome + " | ");
    Console.Write("Preco do produto: " + item.Preco.ToString());
    Console.WriteLine(" ");
    precoTotal = precoTotal + item.Preco;
}
Console.WriteLine("Total: " + precoTotal + " Reais.");

Console.WriteLine(" ");
Console.WriteLine("#############################################################################");
Console.WriteLine(" ");
Console.WriteLine("O que deseja fazer? ");
Console.WriteLine("Add item na lista? aperte 1");
Console.WriteLine("Visaulizar item da lista? aperte 2");
Console.WriteLine("Apagar item da lista lista? aperte 3");
Console.WriteLine("Deseja gerar um lista de compras? aperte 4");
Console.WriteLine("Se deseja sair aperte 0");


 opcao = int.Parse(Console.ReadLine());
    


if (opcao == 1 || opcaoFim == "N")
{
    Console.WriteLine("Qual o nome do produto?");
    string nome = Console.ReadLine();

    Console.WriteLine("qual o preço?");
    var preco = double.Parse(Console.ReadLine());

    lista.Add(new Produto(lista.Count + 1, nome, preco));

}
else if (opcao == 2)
{
    Console.WriteLine("Qual item deseja visualizar? Digite o codigo: ");
    var codigo = int.Parse(Console.ReadLine());
    var produto = lista.Find(x => x.Codigo == codigo);

    Console.Write("Codigo do produto: " + produto.Codigo + " | ");
    Console.Write("Nome do produto: " + produto.Nome + " | ");
    Console.Write("Preco do produto: " + produto.Preco.ToString());
    Console.WriteLine(" ");

    }
else if (opcao == 3)
{
    Console.WriteLine("Qual item deseja remover da lista, digite o codigo?");

    int codigo = int.Parse(Console.ReadLine());
    Produto obj = lista.Find(x => x.Codigo == codigo);
    lista.Remove(obj);
    }
    else if(opcao == 4)
    {
        StreamWriter x;
        string caminho = "C:\\Users\\gusta\\source\\repos\\Projetos Pessoais\\ListaDinamicaEncadeada\\myFile.txt.";
        x = File.CreateText(caminho);
        x.WriteLine("Lista de Compras: ");
        x.WriteLine();
        x.WriteLine();

        foreach (var item in lista)
        {
            x.Write("Codigo do produto: " + item.Codigo + " | ");
            x.Write("Nome do produto: " + item.Nome + " | ");
            x.Write("Preco do produto: " + item.Preco.ToString());
            x.WriteLine(" ");
            precoTotal = precoTotal + item.Preco;
        }
        x.Close();
        Console.WriteLine(" O Arquivo foi gerado com sucesso! o Caminho do arquivo é: " + caminho);

    }

    


    Console.WriteLine("Deseja continuar? S ou N: ");
    opcaoFim = Console.ReadLine();

}