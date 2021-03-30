using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto jogofifa = new JogoDigital("fifa 2020", 550, "PS5");
            Produto jogoGow = new JogoDigital("God od War", 5.99, "PS2"); 
            Produto livro1 = new Livro("O principe", 40, "Maquiavel");
            Produto livro2 = new Livro("A arte da guerra", 57, "Sun Tzu");

            Produto[] produtos = { jogofifa, jogoGow, livro1, livro2 };
            foreach (Produto item in produtos)
            {
                item.InformarDescricao();
                item.InformarPreco();
                Console.WriteLine("------------------");
                Console.ReadLine();

            }
        }
    }
}
