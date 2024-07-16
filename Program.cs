using Bibliotech.Menu;
using Bibliotech.Biblioteca;

//Menu.ExibirMenu();

Biblioteca biblioteca = new Biblioteca();
Livro livro1 = new Livro("Harry Potter", "Jk Rolling", "abababab");
Livro livro2 = new Livro("Harry Potter", "Jk Rolling", "abababab");
Livro livro3 = new Livro("Harry Potter", "Jk Rolling", "abababab");

biblioteca.AdicionarLivro(livro1);
biblioteca.AdicionarLivro(livro2);
biblioteca.AdicionarLivro(livro3);

biblioteca.MostrarLivros();








