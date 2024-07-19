using Bibliotech.Menu;
using Bibliotech.BibliotechMain;

Biblioteca biblioteca = new Biblioteca();
Livro LivroDefault = new Livro("Harry Potter");
Livro LivroDefault2 = new Livro("Senhor dos Anéis");

ExibirMenu();

void ExibirMenu()
{
    Console.Clear();
    Console.WriteLine("Bem vindos ao Bibliotech");
    Console.WriteLine("Digite o número da opção que deseja");
    Console.WriteLine("1 - Adicionar um livro na sua biblioteca");
    Console.WriteLine("2 - Remover um livro na sua biblioteca ");
    Console.WriteLine("3 - Listar os livros");
    Console.WriteLine("4 - Avaliar um livro");
    Console.WriteLine("0 - Sair");
    string opcao = Console.ReadLine();

    int opcaoNum = Convert.ToInt32(opcao);

    switch (opcaoNum)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("-- Adicionar um livro na sua biblioteca --");
            Console.WriteLine("Digite o nome do Livro:");
            string nomeDolivro = Console.ReadLine();
            Livro livro = new Livro(nomeDolivro);
            biblioteca.AdicionarLivro(livro);
            ExibirMenu();
            break;

        case 2:
            Console.Clear();
            Console.WriteLine("-- Remover um livro na sua biblioteca --");
            Console.WriteLine("Digite o nome do Livro:");
            string nomeDolivroRemovida = Console.ReadLine();
            biblioteca.RemoverLivro(nomeDolivroRemovida);
            ExibirMenu();
            break;

        case 3:
            Console.Clear();
            biblioteca.MostrarLivros();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            ExibirMenu();
            break;

        case 4:
            Console.WriteLine($"Opção {opcaoNum}");
            break;

        case 0:
            Console.WriteLine($"Opção {opcaoNum}");
            break;

        default:
            Console.WriteLine();
            break;
    }
}













