using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Livro : Produto
    {
        public Livro(string titulo, double preco, string autor) : base(titulo, preco)
        {
            Autor = autor;
        }

        public string Autor { get; private set; }

        public override void InformarDescricao()
        {
            Console.WriteLine($"{Titulo}escrito por {Autor}");
        }

    }
}
