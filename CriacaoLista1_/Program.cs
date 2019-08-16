using CriacaoLista1_.CriarLista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoLista1_
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaBi = new CriarListaBi();

            listaBi.LimparLista();

            Console.ReadKey();

        }
    }
}
