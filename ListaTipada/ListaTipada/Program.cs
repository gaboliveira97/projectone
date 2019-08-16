using ListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lanche> minhaLista = new List<Lanche>();
            minhaLista.Add(new Lanche()
            {
                Nome = "Bolinho Soya + Refri Bonus: Gastrite",
                Quantidade = 2,
                Valor = 7.50
            });
            minhaLista.Add(new Lanche()
            {
                Nome = "Pão de queijo",
                Quantidade = 9,
                Valor = 1.75
            });
            minhaLista.Add(new Lanche()
            {
                Nome = "Pão com mortadela",
                Quantidade = 3,
                Valor = 2.50
            });
            minhaLista.Add(new Lanche()
            {
                Nome = "Dog Bacon",
                Quantidade = 5,
                Valor = 8.00
            });
            minhaLista.Add(new Lanche()
            {
                Nome = "X tudo",
                Quantidade = 3,
                Valor = 10.00
            });
            //Aqui ando pela minha lista para apresentar os valores em tela
            //item in significa que ele ja é um indice da minha lista 
            foreach (Lanche item in minhaLista)

                Console.WriteLine($"Lanches disponiveis: {item.Nome}");
            Console.WriteLine("Removendo intem");

            foreach (Lanche item in minhaLista)
            {
                if (item.Quantidade == 3)
                {
                    minhaLista.Remove(item);
                    break;
                }

            }

            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");


            Console.ReadKey();

        }
    }
}
