using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech.Biblioteca
{
    public class Biblioteca
    {

        List<Livro> listaDeLivros = new List<Livro>();  

        public string Nome { get; } = "Bibliotech";

        public void AdicionarLivro(Livro livro)
        {
            listaDeLivros.Add(livro);
        }

        public void RemoverLivro(Livro livro)
        {
            listaDeLivros.Remove(livro);
        }

        public void MostrarLivros()
        {
            foreach(Livro livro in listaDeLivros)
            {
                Console.WriteLine($"Livros na biblioteca:{livro.Nome}");
            }
        }
    }
}
