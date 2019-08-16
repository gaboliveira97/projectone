using ConsoleApp2.MyFirstClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new Carro();

            teste++;

            teste.MostrarCarro();

            Console.ReadKey();
        }
    }
}
