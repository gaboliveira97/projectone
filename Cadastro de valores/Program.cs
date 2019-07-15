using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_valores
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] listadeNome = new string[5, 4];
            int IdParaLista = 0;

            NovoRegistro(ref listadeNome, ref IdParaLista);

            Console.ReadKey();

            NovoRegistro(ref listadeNome, ref IdParaLista);

            Console.ReadKey();
        }

        public static void NovoRegistro(ref String[,] listadeNome, ref int IdParaLista)

        {
            for (int i = 0; i < listadeNome.GetLength(0); i++)
            {
                if (listadeNome[i, 0] != null)
                    continue;

                Console.WriteLine("\r\nInforma um nome para adicionar um registro:");
                var nome = Console.ReadLine();

                Console.WriteLine("\r\nInforma sua idade para adicionar um registro:");
                var idade = Console.ReadLine();

                Console.WriteLine("\r\nInforma seu peso para adicionar um registro:");
                var peso = Console.ReadLine();

                listadeNome[i, 0] = (IdParaLista++).ToString();
                listadeNome[i, 1] = nome;
                listadeNome[i, 2] = idade;
                listadeNome[i, 3] = peso;

                Console.WriteLine("Deseja inserir novo registro? Sim (1) Não (0)");
                var continuar = Console.ReadKey().KeyChar.ToString();

                if (continuar == "0") 
                   break;

                AumentoTamanhoLista(ref listadeNome);

            }
            Console.WriteLine("Registro realizado com sucesso, segue informações adicionadas:");

            for (int i = 0; i < listadeNome.GetLength(0); i++)
                Console.WriteLine(string.Format("Registro ID {0} - Nome:{1} - Idade:{2} - Peso:{3}", listadeNome[i, 0], listadeNome[i, 1],
                  listadeNome[i, 2], listadeNome[i, 3]));
        }
        public static void AumentoTamanhoLista(ref string[,] listadeNome)
        {
            var LimitedaLista = true;

            for (int i = 0; i < listadeNome.GetLength(0); i++)
            {
                if (listadeNome[i, 0] == null)
                    LimitedaLista = false;
            }

            if (LimitedaLista)
            {
                var listacopia = listadeNome;

                listadeNome = new string[listadeNome.GetLength(0) + 5, 4];

                for (int i = 0; i < listacopia.GetLength(0); i++)
                {
                    listadeNome[i, 0] = listacopia[i, 0];
                    listadeNome[i, 1] = listacopia[i, 1];
                    listadeNome[i, 2] = listacopia[i, 2];
                    listadeNome[i, 3] = listacopia[i, 3];
                }

                Console.WriteLine("O tamanho da lista foi atualizado.");
            }

        }




}
}

