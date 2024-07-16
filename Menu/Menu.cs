using Bibliotech.Biblioteca;

namespace Bibliotech.Menu
{
     class Menu
    {

        public static void ExibirMenu()
        {
                Console.Clear();
                Console.WriteLine("Bem vindos ao Bibliotech");
                Console.WriteLine("Digite o número da opção que deseja");
                Console.WriteLine("1 - Livros disponíveis na biblioteca");
                Console.WriteLine("2 - Adicionar livro");
                Console.WriteLine("3 - Remover livro");
                Console.WriteLine("4 - Avaliar um livro");
                Console.WriteLine("0 - Sair");
                string opcao = Console.ReadLine();

                int opcaoNum = Convert.ToInt32(opcao);

                switch (opcaoNum)
                {
                    case 1:
                        Console.Clear();
                        
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine($"Opção {opcaoNum}");
                        break;

                    case 3:
                        Console.WriteLine($"Opção {opcaoNum}");
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
    }
}
