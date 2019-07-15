using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAndRemove
{
    class Program
    {
        //criamos nossa base de dados.
        static string[,] basededados = new string[2, 3];
        static int IndiceBaseDeDados = 0;
        static void Main(string[] args)

        {   //Apresentação do menu inicial.
            Console.WriteLine("Iniciando sistema de nome e idade:");
            //Criamos a variavel fora para não ser criada novamente
            var EscolhaInicial = ApresentandoMenuInicial();
            //Looop infinito até que dê uma treta.
            while (true)
            {//Iniciando a escolha do nosso menu.
                switch (EscolhaInicial)
                {

                    case "1": { InsereValoresNaLista(ref basededados, ref IndiceBaseDeDados); } break;
                    case "2": { } break;
                    case "3": { } break;
                    case "4": { } return;
                        // Returno dentro do nosso caso de escolha ele sai do nosso metodo principal ou metodo que estamos dentro de contexto.
                }
                //Alimento a escolha novamente.
                EscolhaInicial = ApresentandoMenuInicial();
            }
        }/// <summary>
         /// Apresenta as informações do Menu Inicial.
         /// </summary>
         /// <returns>Retorna ao menu escolhido</returns>
        public static string ApresentandoMenuInicial()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1- Inserir um novo registro.");
            Console.WriteLine("2- Remover um novo registro.");
            Console.WriteLine("3- Listar informações.");
            Console.WriteLine("4- Sair do sistema.");

            Console.WriteLine("Digite o número da opção desejada.");
            //Retorna ao Menu Escolhido.
            return Console.ReadLine();

        }
        public static void InsereValoresNaLista(ref string[,] basededados, ref int IndiceBase)
        {
            Console.WriteLine("Inserindo valores na lista");

            Console.WriteLine("Informe um nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a idade:");
            var idade = Console.ReadLine();

            for (int i = 0; i < basededados.GetLength(0); i++)
            {
                if (basededados[i, 0] != null)
                    continue;

                basededados[i, 0] = (IndiceBase++).ToString();

                basededados[i, 1] = nome;

                basededados[i, 2] = idade;

                break;
            }

            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para volta ao menu inicial basta clicar em qualquer tecla.");
            Console.ReadKey();


        }
        public static void MostrarInformacoes(string[,] basededados)
        {
            Console.WriteLine("Apresentação das informações dentro da base de dados.");

            for (int i = 0; i < basededados.GetLength(0); i++)

            {
                Console.WriteLine($"ID {basededados[i, 0]}" +
                    $"-Nome:{basededados[i, 01]}" +
                    $"-Idade:{basededados[i, 2]}");


                Console.WriteLine("Resultado apresentado com sucesso");
                Console.WriteLine("Para voltar ao menu inicial pressione qualquer tecla.");
                Console.ReadKey();
            }
        }
        public static void RemoverInformacoes(ref string[,] basededados)
        {
            Console.WriteLine("Area de registro do sistema.");

            for (int i = 0; i < basededados.GetLength(0); i++)

                Console.WriteLine($"ID:{basededados[i, 0]}" +
                     $"-Nome:{basededados[i, 01]}" +
                    $"-Idade:{basededados[i, 2]}");

            Console.WriteLine("Informe o ID de registro a ser removido.");

            var id = Console.ReadLine();

            for (int i = 0; i < basededados.GetLength(0); i++)

            { 
                if (basededados[i, 0] != null && basededados[i, 0] == id) ;

                {
                    basededados[i, 0] = null;
                    basededados[i, 1] = null;
                    basededados[i, 2] = null;


                }
            }

            Console.WriteLine("Operações finalizadas.");
            Console.WriteLine("Para retornar ao menu inicial pressione qualquer tecla.");
            Console.ReadKey();
            


        }
    }
}
