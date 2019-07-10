using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecttwo
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] listadeLivros = new string[2, 2]
                {{"O pequeno", "sim"},{"O grande", "não" } };

            for (int i = 0; i < listadeLivros.GetLength(0); i++) 
            {

                var livro = listadeLivros[i, 0];
                var disponivel = listadeLivros[i, 1];

                Console.WriteLine($"Nome do Livro: {livro} Disponivel: {disponivel}.") ;
            }

            Console.ReadKey();
        }

    }
}
