using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech.Biblioteca
{
    public class Livro 
    {
        public Livro(string nome, string autor, string sinopse) 
        {
            Nome = nome;
            Autor = autor;
            sinopse = Sinopse;

        }

        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Sinopse  { get; set; }

        public void DescreverLivro()
        {
            
        }

    }
}
