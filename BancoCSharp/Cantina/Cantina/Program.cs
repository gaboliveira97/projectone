using Cantina.ComprarLanche;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCSharp
{
    class Program
    {
        static void Main(string[] args)

        {
            var teste = Cardapio();
            ComprarLanche accountUser = new ComprarLanche();
            

            if (accountUser.Comprar(teste))
                Console.WriteLine("Compra realizada com sucesso!");

            else
                Console.WriteLine("Operação não autorizada!");


            Console.WriteLine($"Saldo atual disponivel:{accountUser.MostrarSaldo()}");

            Console.WriteLine("Deseja realizar outra operação?");
            
            Console.ReadKey();
        }
        public static double Cardapio()
        {

            Console.Clear();
            Console.WriteLine("Pedido:");
            Console.WriteLine("1-DogBacon | 10,00");
            Console.WriteLine("2-DogTradicional  | 8,00");
            Console.WriteLine("3-Refrigerante  | 4,00");
            Console.WriteLine("Digite o número da opção desejada:");

            switch (Console.ReadLine())
            {

                case "1": { return 10; }
                case "2": { return 8; }
                case "3": { return 4; }
            }

            return 0;



        }

    }
}
