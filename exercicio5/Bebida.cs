using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    class Bebida : ItemMenu
    {
        public string TamanhoBebida { get; set; }
        public Bebida(string nome, double preco) : base(nome, preco)
        {
        }

        public override void ImprimirPreco()
        {
            double precoPequena = 0.9 * Preco;
            double precoMedia = 1.6 * Preco;
            double precoGrande = 2.5 * Preco;

            Console.WriteLine($"{Nome} p: {precoPequena.ToString("C")}");
            Console.WriteLine($"{Nome} m: {precoMedia.ToString("C")}");
            Console.WriteLine($"{Nome} g: {precoGrande.ToString("C")}");
            //if (TamanhoBebida == "pequena")
            //{
            //    Preco = 0.8 * Preco;
            //    Console.WriteLine($"{Nome} {TamanhoBebida}: {Preco.ToString("C")}");
            //}
            //else if (TamanhoBebida == "média")
            //{
            //    Preco = 1.3 * Preco;
            //    Console.WriteLine($"{Nome} {TamanhoBebida}: {Preco.ToString("C")}");
            //}
            //else if (TamanhoBebida == "grande")
            //{
            //    Preco = 1.9 * Preco;
            //    Console.WriteLine($"{Nome} {TamanhoBebida}: {Preco.ToString("C")}");
            //}
            //else
            //{
            //    Console.WriteLine("Não foi possível concluir seu pedido");
            //}
        }
    }
}
