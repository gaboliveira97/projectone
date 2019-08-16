using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCalculadora.calculadora;

namespace BibliotecaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var calcular = new calculos();

            Console.WriteLine(calcular.CalculoAdicao(5, 5));

            Console.ReadKey();

        }
    }
}
