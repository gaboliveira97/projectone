using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permissão_para_beber
{
    class Program
    {
        static void Main(string[] args)
        {

            MostrarBemVindo();
            MenuPrincipal();



            Console.ReadKey();



        }

        public static void MostrarBemVindo()
        {
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("Bem vindo a Loja Virtual Ambev");
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("Sistema criado pelas indústrias BNU Sistemas");
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||");
        }
        public static void MenuPrincipal()

        {

            Console.WriteLine("Para prosseguirmos por favor informe sua idade:");

            int.TryParse(Console.ReadLine(), out int idade);
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade e podemos prosseguir.");

                int.TryParse(Console.ReadLine(), out int opcao);
            }
            else
            {
                Console.WriteLine("Você ainda é menor de idade. Espere os 18 anos.");
            }
            

















        }


    }

}
