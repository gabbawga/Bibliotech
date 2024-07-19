using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech.BibliotechMain
{
    public class Biblioteca
    {

        public List<Livro> ListaDeLivros { get; set; }
        
        public void AdicionarLivro(Livro livro)
        {
            ListaDeLivros.Add(livro);
        }

        public void RemoverLivro(Livro livro)
        {
            if (ListaDeLivros.Contains(livro))
            {
                Console.WriteLine("Não existe este livro");
            }
            ListaDeLivros.Remove(livro);
        }

        public void MostrarLivros()
        {
            foreach (Livro livro in ListaDeLivros)
            {
                Console.WriteLine($"Livros na biblioteca:{livro.Nome}");
            }
        }
    }
}
