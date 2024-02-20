using ScreenSound.Menus;
using ScreenSound.Models;
using OpenAI_API;



Banda linkinpark = new("Linkin Park");
linkinpark.AdicionarNota(new Avaliacao(10));
linkinpark.AdicionarNota(new Avaliacao(9));

Banda bmth = new("Bring Me The Horizon");

Dictionary<string, Banda> bandasRegistradas = new()
        {
            { linkinpark.Nome, linkinpark },
            { bmth.Nome, bmth }
        };

Dictionary<int, Menu> opcoes = new()
        {
            { 1, new MenuRegistrarBanda() },
            { 2, new MenuRegistrarAlbum() },
            { 3, new MenuMostrarBandasRegistradas() },
            { 4, new MenuAvaliarBanda() },
            { 5, new MenuAvaliarAlbum() },
            { 6, new MenuExibirDetalhes() },
            { -1, new MenuSair() }
        };

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}



void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    int opcaoEscolhidaNumerica = int.Parse(Console.ReadLine()!);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        opcoes[opcaoEscolhidaNumerica].ExecutarAsync(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else Console.WriteLine("Opção inválida");

}
// ExibirOpcoesDoMenu();
