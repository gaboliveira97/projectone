using CalculoMedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletim
{
    class Program
    {
        static void Main(string[] args)
        {
            BoletimAlunos teste = new BoletimAlunos();

            Console.WriteLine("Informe nota 01:");
            var nota01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe nota 02:");
            var nota02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe nota 03:");
            var nota03 = Convert.ToInt32(Console.ReadLine());

            var media = teste.MediaNotas(nota01, nota02, nota03);
            var frequencia = teste.frequencia(100, 10);

            teste.situacao(media, frequencia);

          

            Console.ReadKey();
        }
    }
}
