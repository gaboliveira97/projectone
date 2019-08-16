using Calculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoDLLamiguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new Calculadora();

            Console.WriteLine("Soma:");
            Console.WriteLine(teste.Adicao(10,10));

            Console.WriteLine("Subtração:");
            Console.WriteLine(teste.Subtracao(20, 10));

            Console.WriteLine("Multiplicação:");
            Console.WriteLine(teste.Multiplicacao(3, 3));

            Console.WriteLine("Divisão:");
            Console.WriteLine(teste.Divisao(15, 3));

            Console.WriteLine("Calculo Triangulo:");
            Console.WriteLine(teste.CalcularTriangulo(10, 5));

            Console.WriteLine("Calculo Raio:");
            Console.WriteLine(teste.CalcularRaio(10));

            Console.ReadKey();




        }
    }
}
