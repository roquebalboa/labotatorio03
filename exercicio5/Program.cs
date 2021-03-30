using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    class Program
    {
        //Escreva uma classe chamada “ItemMenu”. Ela deve ter um atributo chamado “Nome” e os métodos: “ImprimirNome()” e
        //“ImprimirPreco()” para imprimir o nome do item e o preço na tela, respectivamente.
        //Crie duas classes derivadas: “Bebida” e “Aperitivo”;
        //As bebidas devem, ter 3 preços diferentes de acordo com o tamanho: pequena, média e grande;
        //Criar um construtor para a classe “Bebida” para receber os três preços;
        //Os aperitivos possuem apenas um preço;
        //Criar uma classe de teste que receba um array com 5 elementos do tipo “ItemMenu”, sendo  3 objetos do tipo “Bebida” e
        //2 objetos do tipo “Aperitivo” e imprima o cardápio da lanchonete, mostrando o nome e o preço de cada produto.

        const double PRECO_APERITIVO = 12.50f;

        static void Main(string[] args)
        {
            ItemMenu bebida0 = new Bebida("Velho olho vermelho", 9.50);
            ItemMenu bebida1 = new Bebida("Cocão gelado", 7.50);
            ItemMenu bebida2 = new Bebida("Suco de tamarindo", 6);

            ItemMenu aperitivo0 = new Aperitivo("Frango a passarinho", PRECO_APERITIVO);
            ItemMenu aperitivo1 = new Aperitivo("batata frita suprema", PRECO_APERITIVO);

            ItemMenu[] cardapio = { aperitivo0, aperitivo1, bebida0, bebida1, bebida2 };

            Console.WriteLine("NÃO SERVIMOS AGUA NÃO INSISTA");

            foreach (ItemMenu item in cardapio)
            {
                item.ImprimirNome();
                item.ImprimirPreco();
                Console.WriteLine("\n*****************************");
                Console.ReadLine();
                
            }
        }
    
    }
}
