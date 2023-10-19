Dictionary<string, List<int>> produtosRegistrados = new Dictionary<string, List<int>>();
produtosRegistrados.Add("Linkin Park", new List<int> { });
produtosRegistrados.Add("The Beatles", new List<int> { });
produtosRegistrados.Add("Taylor Swift", new List<int> { });
produtosRegistrados.Add("Post Malone", new List<int> { });

void ExibirLogo()
{
    Console.WriteLine(@"


--------------------------------------------------------------------------------------------  
    ███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░  ░██████╗████████╗░█████╗░██████╗░███████╗
    ████╗░████║██║░░░██║██╔════╝██║██╔══██╗  ██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔════╝
    ██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝  ╚█████╗░░░░██║░░░██║░░██║██████╔╝█████╗░░
    ██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗  ░╚═══██╗░░░██║░░░██║░░██║██╔══██╗██╔══╝░░
    ██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝  ██████╔╝░░░██║░░░╚█████╔╝██║░░██║███████╗
    ╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░  ╚═════╝░░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚══════╝
--------------------------------------------------------------------------------------------
");
    Console.WriteLine("Gerencie o estoque aqui!");
}
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um artista");
    Console.WriteLine("Digite 2 para mostrar todos os artistas");
    Console.WriteLine("Digite 3 para remover artista");
    Console.WriteLine("Digite 4 para entrada de estoque");
    Console.WriteLine("Digite 5 para saida de estoque");
    Console.WriteLine("Digite 6 para exibir detalhes");
    Console.WriteLine("Digite 7 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarArtista();
            break;
        case 2:
            MostrarArtistasRegistrados();
            break;
        case 3:
            RemoverArtista();
            break;
        case 4:
            EntradaEstoque();
            break;
        case 5:
            SaidaEstoque();
            break;
        case 6:
            ExibirDetalhes();
            break;
        case 7:
            Console.WriteLine("\nVolte sempre!");
            break;
        default:
            Console.WriteLine("\nOpção inválida");
            break;
    }
}

void RegistrarArtista()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro dos artistas");
    Console.Write("Digite o nome do artista que deseja registrar: ");
    string nomeDoArtista = Console.ReadLine()!;
    produtosRegistrados.Add(nomeDoArtista, new List<int>());
    Console.WriteLine($"O artista {nomeDoArtista} foi registrado com sucesso!");
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarArtistasRegistrados()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todos os artistas registrados");

    foreach (string artista in produtosRegistrados.Keys)
    {
        Console.WriteLine($"Artista: {artista}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}
void RemoverArtista()
{
    Console.Clear();
    ExibirTituloDaOpcao("Remover Produtos");
    Console.Write("Digite o nome do produto que deseja remover: ");
    string nomeDoArtista = Console.ReadLine()!;
    if (produtosRegistrados.ContainsKey(nomeDoArtista))
    {
        produtosRegistrados.Remove(nomeDoArtista);
        Console.WriteLine($"\nO artista {nomeDoArtista} foi removido com sucesso!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\no Produto: {nomeDoArtista} não foi encontrado!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

void EntradaEstoque()
{
    Console.Clear();
    ExibirTituloDaOpcao("Adicionar Produto");
    Console.Write("Digite o nome do Produto que deseja colocar no estoque: ");
    string nomeDoArtista = Console.ReadLine()!;
    if (produtosRegistrados.ContainsKey(nomeDoArtista))
    {
        Console.Write($"\nQual a quatidade que o produto: {nomeDoArtista} esta sendo adicionado? :  ");
        int qtd = int.Parse(Console.ReadLine()!);
        produtosRegistrados[nomeDoArtista].Add(qtd);
        Console.WriteLine($"\nfoi adiconado {qtd} o produtos: {nomeDoArtista}");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\no Produto: {nomeDoArtista} não foi encontrado!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void SaidaEstoque()
{
    Console.Clear();
    ExibirTituloDaOpcao("Adicionar Produto");
    Console.Write("Digite o nome do Produto que deseja remover do estoque: ");
    string nomeDoArtista = Console.ReadLine()!;
    if (produtosRegistrados.ContainsKey(nomeDoArtista))
    {
        Console.Write($"\nQual a quatidade que o produto: {nomeDoArtista} esta sendo removido? :  ");
        int qtd = int.Parse(Console.ReadLine()!);
        produtosRegistrados[nomeDoArtista].Remove(qtd);
        Console.WriteLine($"\nfoi removido {qtd} do produto: {nomeDoArtista}");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\no Produto: {nomeDoArtista} não foi encontrado!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirDetalhes()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir detalhes do produto");
    Console.Write("Digite o nome do produto que deseja conhecer melhor: ");
    string nomeDoArtista = Console.ReadLine()!;
    if (produtosRegistrados.ContainsKey(nomeDoArtista))
    {
        List<int> qtd = produtosRegistrados[nomeDoArtista];
        Console.WriteLine($"\nA o produto {nomeDoArtista} tem {qtd.Sum()} e custa R$19,99.");
        Console.WriteLine("Digite uma tecla para votar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\no Produto: {nomeDoArtista} não foi encontrado!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesDoMenu();