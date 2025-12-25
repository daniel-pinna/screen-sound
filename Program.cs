// Screen Sound
string mensagemDeBoasVindas = "\nBoas vindas ao Screen Sound";

// List<string> listaDasBandas = new List<string> {"U2", "The Beatles", "Calypso"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> {10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{    
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░░██████╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗██╔════╝
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║╚█████╗░
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║░╚═══██╗
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    // if (opcaoEscolhidaNumerica == 1)
    // {
    //     Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
    // } else if (opcaoEscolhidaNumerica == 2)
    // {
    //     Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
    // } 

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: MostrarMediaDaBanda();
            break;
        case -1: Console.WriteLine("Tchau Tchau ;) " + opcaoEscolhida);
            break;
        default: Console.WriteLine("Opção inválida");
            break;
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

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();   
    ExibirTituloDaOpcao("Exibir todas as bandas registradas");

    // for (int i = 0; i < listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // }

    foreach (var banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void MostrarMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        double mediaDaBanda = bandasRegistradas[nomeDaBanda].Average();
        Console.Write($"A Media da banda {nomeDaBanda} é: {mediaDaBanda}\n");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    
}

//Desafios da Fase 1
void DesafioDefinirAprovacao()
{
    Console.Write("Digite a sua nota: ");
    int notaMedia = int.Parse(Console.ReadLine()!);

    if (notaMedia >= 5)
    {
        Console.WriteLine("\nNota suficiente para aprovação");
    }
}

void DesafioSelecaoNaLista()
{
    List<string> linguagens = new List<string> { "C#", "Java", "JavaScript" };
    Console.WriteLine(linguagens[0]);
}

void DesafioJogoNumeroSecreto()
{
    Random rand = new Random();
    int numeroAleatorio = rand.Next(1, 101);
    int numeroSecreto;
    do
    {
        Console.Write("\nTente adivinhar o número secreto: ");
        numeroSecreto = int.Parse(Console.ReadLine()!);

        if (numeroSecreto < numeroAleatorio)
        {
            Console.WriteLine("Tente um valor maior");
        }
        else if (numeroSecreto > numeroAleatorio)
        {
            Console.WriteLine("Tente um valor menor");
        }
        else
        {
            Console.WriteLine("Parabéns você acertou!");
        }
    } while (numeroSecreto != numeroAleatorio);
}

void desafio1()
{
    DesafioDefinirAprovacao();
    DesafioSelecaoNaLista();
    DesafioJogoNumeroSecreto();
}


//Desafios da Fase 2
void DesafiosOperacoesAritimeticas()
{
    float a = 4;
    float b = 8;

    float soma = a + b;
    float subtracao = a - b;
    float divisao = a / b;
    float multiplicacao = a * b;

    Console.WriteLine($"a + b = {soma}");
    Console.WriteLine($"a - b = {subtracao}");
    Console.WriteLine($"a / b = {divisao}");
    Console.WriteLine($"a * b = {multiplicacao}");
}

void DesafioSomarLista()
{
    List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
    int total = 0;

    foreach (int numero in numeros)
    {
        total += numero;
    }
    Console.WriteLine($"\nA soma dos elementos da lista é: {total}\n");
}

void DesafioNumerosPar()
{
    List<int> listaNumeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    foreach (int num in listaNumeros)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine(num);
        }
    }
}

void desafio2()
{
    DesafiosOperacoesAritimeticas();
    DesafioSomarLista();
    DesafioNumerosPar();

}


//Desafios da Fase 3
void DesafioMediaDeAlunosComDicionario()
{
    Dictionary<string, List<double>> notasAlunos = new Dictionary<string, List<double>>();

    // Adicione notas para alguns alunos
    notasAlunos["João"] = new List<double> { 8.5, 9.0, 7.5 };
    notasAlunos["Maria"] = new List<double> { 7.0, 8.0, 6.5 };

    foreach (var aluno in notasAlunos)
    {
        double soma = 0;
        for (int i = 0; i < aluno.Value.Count; i++)
        {
            soma += aluno.Value[i];
        }
        double media = soma / aluno.Value.Count;
        Console.WriteLine($"Média de {aluno.Key}: {media}");
    }
}

void DesafioEstoqueComDicionario()
{
    Dictionary<string, int> estoque = new Dictionary<string, int>
    {
        { "camisetas", 50 },
        { "calças", 30 },
        { "tênis", 20 },
    };

    string produto = "camisetas";

    if (estoque.ContainsKey(produto))
    {
        Console.WriteLine($"\nQuantidade em estoque de {produto}: {estoque[produto]} unidades.");
    }
    else
    {
        Console.WriteLine("Produto não encontrado no estoque.");
    }
}

void DesafioPerguntasERespostaComDicionario()
{
    Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>
    {
        { "\nQual é a capital do Brasil?", "Brasília" },
        { "Quanto é 7 vezes 8?", "56" },
        { "Quem escreveu 'Romeu e Julieta'?", "William Shakespeare" },
    };

    int pontuacao = 0;

    foreach (var pergunta in perguntasERespostas)
    {
        Console.WriteLine(pergunta.Key);
        Console.Write("Sua resposta: ");
        string respostaUsuario = Console.ReadLine()!;

        if (respostaUsuario.ToLower() == pergunta.Value.ToLower())
        {
            Console.WriteLine("Correto!\n");
            pontuacao++;
        }
        else
        {
            Console.WriteLine($"Incorreto. A resposta correta é: {pergunta.Value}\n");
        }
    }

    Console.WriteLine($"Pontuação final: {pontuacao} de {perguntasERespostas.Count}");
}

void DesafioLoginComDicionario()
{
    Dictionary<string, string> usuarios = new Dictionary<string, string>
    {
        { "user1", "senha123" },
        { "user2", "abc456" },
    };

    string nomeUsuario = "user1";
    string senha = "senha123";

    if (usuarios.ContainsKey(nomeUsuario) && usuarios[nomeUsuario] == senha)
        Console.WriteLine("\nLogin bem-sucedido!");
    else
        Console.WriteLine("Nome de usuário ou senha incorretos.");
}

void DesafioMediaEmListas()
{
    Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
        { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
        { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
        { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
        { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
        { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
    };

    double mediaVendasBugatti = vendasCarros["Bugatti Veyron"].Average();
    Console.WriteLine("\nMédia de vendas do Bugatti Veyron: " + mediaVendasBugatti);
}

void desafio3()
{
    DesafioMediaDeAlunosComDicionario();
    DesafioEstoqueComDicionario();
    DesafioPerguntasERespostaComDicionario();
    DesafioLoginComDicionario();
    DesafioMediaEmListas();
}

// desafio1();
// desafio2();
// desafio3();

ExibirOpcoesDoMenu();