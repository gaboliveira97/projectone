using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var elementoX = new teste(5, 5);

            elementoX.AlteraInformacoes(5, 5);
            elementoX.MostrarInformacoes();


            Console.ReadKey();
        }
    }
    public class teste
    {
        private int A { get; set; } = 0;
        private int B { get; set; } = 0;
        public teste(int pA, int pB )
        {
            A = pA;
            B = pB;
        }
        public void MostrarInformacoes()
        {
            Console.WriteLine(A + B);
        }
        public void AlteraInformacoes(int pA, int pB)
        {
            A = pA * 2;
            A = pB * 2;
        }
    }
}
