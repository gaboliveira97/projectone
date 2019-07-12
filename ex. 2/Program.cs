using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._2
{
    class Program
    {
        static void Main(string[] args)

            
        {
            Apresentacao();
            Ingredientes();
            MododePreparo();
               /////TESTE
            

            Console.ReadKey();
        }

        public static void Apresentacao()

        {
            Console.WriteLine("||||||||||||||||||||||||||||||||");
            Console.WriteLine("RECEITA DE BOLO DE CENOURA!|||||");
            Console.WriteLine("||||||||||||||||||||||||||||||||");
        }
        public static void Ingredientes()

        {
            Console.ReadLine();

            Console.WriteLine("Ingredientes:");
           
            Console.WriteLine("3 ovos.");
            
            Console.WriteLine("1 xicara de oleo.");
            
            Console.WriteLine("2 copos (250ml) de açucar.");
            
            Console.WriteLine("2 copos (250ml) de farinha de trigo.");
            
            Console.WriteLine("2 copos (250ml) de leite.");
            
            Console.WriteLine("1 Colher de Fermento.");
        }
        public static void MododePreparo()
        {
            Console.ReadLine();

            Console.WriteLine("Primeiro Passo: Em um Liquidificador bata as cenouras, o oleo e os ovos.");
            Console.ReadLine();
            Console.WriteLine("Segundo Passo: Acrescente o açucar e bata novamente por 5 minutos.");
            Console.ReadLine();
            Console.WriteLine("Primeiro Passo: Em um Liquidificador bata as cenouras, o oleo e os ovos.");
            Console.ReadLine();
            Console.WriteLine("Em uma tigela ou na batedeira adicione a farinha de trigo.");
            Console.ReadLine();
            Console.WriteLine("Acrescente o fermento e misture lentamente.");
            Console.ReadLine();
            Console.WriteLine("Asse a 180 graus por 40 minutos.");

        }
    }
}
