using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotech.BibliotechMain
{
    public class Livro
    {
        public Livro(string nome)
        {
            Nome = nome;
 
        }

        public string Nome { get; set; }

        public void DescreverLivro()
        {
            Console.WriteLine($" O livro {Nome} ");
        }

    }
}
