// See https://aka.ms/new-console-template for more information
using System.Security.Claims;

List<Produto> listaProdutos = new List<Produto> ();
List<string> lista = new List<string> ();

while (true)
{
    Console.Clear ();
    Console.WriteLine("SELECIONE UMA OPÇÃO");
    Console.WriteLine("1 - PARA EXECUTAR LOOPS\n2 - PARA EXECUTAR PRODUTOS\n3 - PARA LER PRODUTOS\n4 - SAIR\nDIGITE OPÇÃO DESEJADA");
    string escolha = Console.ReadLine();
    Console.Clear();

    switch (escolha)
    {
        case "1":
            ExecutarLoops();
            break;
        case "2":
            AdicionarProduto();
            break;
        case "3":
            Console.WriteLine("Função em desenvolvimento...");
            break;
        case "4":
            Console.WriteLine("Saindo do programa...");
            return;
        default:
            Console.WriteLine("Você digitou uma opção inválida.");
            break;

    }

    Console.ReadKey();
}

static void ExecutarLoops ()
{
    Console.WriteLine("Executando exemplos de loops...");

    Console.WriteLine("\nExemplo de FOR:");
    for (int i = 0; i <= 5; i++) 
    {
        Console.WriteLine($"Número: {i}");
    }

    Console.WriteLine("\nExemplo de WHILE:");
    int contadorWhile = 1;
    while (contadorWhile <= 5)
    {
        Console.WriteLine($"Número: {contadorWhile}");
        contadorWhile++;
    }

    Console.WriteLine("\nExemplo de DO-WHILE:");
    int contadorDoWhile = 1;
    do
    {
        Console.WriteLine($"Número {contadorDoWhile}");
        contadorDoWhile++;
    } while (contadorDoWhile <= 5);

    Console.WriteLine("\nExemplo de FOREACH");
    string[] cores = { "Vermelho", "Azul", "Verde", "Amarelo" };
    foreach (string cor in cores)
    {
        Console.WriteLine($"Cor: {cor}");
    }
}

void AdicionarProduto()
{
    Produto item1 = new Produto();
    item1.Nome = "Big Mac";
    item1.Preco = 12.50;

    listaProdutos.Add(item1);

    Produto item2 = new Produto();
    item2.Nome = "Sorvete";
    item2.Preco = 3.50;

    listaProdutos.Add(item2);
}

void lerProdutos()
{
    if (listaProdutos.Count == 0)
    {
        Console.WriteLine("Necessário carregar produtos.");
    }
    else {
        foreach (Produto item in listaProdutos)
        {
            Console.WriteLine($"\nNome produto: {item.Nome}");
            Console.WriteLine($"\nPreço produto: {item.Preco}");
        }
    }
}
class Produto 
{
    public String Nome { get; set; }
    public double Preco { get; set; }
}