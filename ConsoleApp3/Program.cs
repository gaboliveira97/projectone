using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaComDLL
{
    class Program
    {
        static void Main(string[] args)
   
        {
           var teste = new GetFiles();
            var Test = teste.RetornaArquivosDoMeuDocumentos();
            var Imagens = teste.RetornaArquivosImagesFiles();
            var Git = teste.RetornaArquivosGit();

            for (int i = 0; i < Test.Length; i++)
            {
                Console.WriteLine(Test[i]);

                Console.ReadLine(); 
            }
            for (int i = 0; i < Imagens.Length; i++)
            {
                Console.WriteLine(Imagens[i]);

                Console.ReadLine();
            }

            for (int i = 0; i < Git.Length; i++)
            {
                Console.WriteLine(Git[i]);

                Console.ReadLine();
            }
        }
       
    }
}
