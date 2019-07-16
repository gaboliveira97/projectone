
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    { // O sistema foi desenvolvido com o pressuposto de que o usuario está acessando seu perfil em uma biblioteca online
        //e o mesmo pode alocar, desalocar, ter acesso aos livros que estão alocados ou ja foram devolvidos por ele

        static void Main(string[] args)
        {

            string[,] baseDeDados = new string[2, 5];

            int IndiceBaseDeDados = 0;

            Console.WriteLine("Iniciando sistema de alocação de livros.");

            var escolhaInicial = MenuInicial();

            while (true)
            {

                switch (escolhaInicial)
                {

                    case "1": { AlocarLivro(ref baseDeDados, ref IndiceBaseDeDados); } break;

                    case "2": { DevolverLivro(ref baseDeDados); } break;

                    case "3": { MostrarInformacoes(baseDeDados); } break;

                    case "4": { MostrarInformacoes(baseDeDados, "true"); } break;

                    case "5":
                        {

                            return;
                        }
                }

                escolhaInicial = MenuInicial();
            }
        }
        /// <summary>
        /// Apresenta as  informações do menu inicial.
        /// </summary>
        /// <returns>Retorna o menu escolhido.</returns>
        public static string MenuInicial()
        {

            Console.Clear();
            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine(" \n\n Bem vindo ao seu perfil no sistema de biblioteca online!!");
            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("\n\nMenu:");
            Console.WriteLine("\n\n1 - Alocar novo livro.");
            Console.WriteLine("2 - Devolver livro.");
            Console.WriteLine("3 - Lista de livros alocados.");
            Console.WriteLine("4 - Lista de livros devolvidos.");
            Console.WriteLine("5 - Sair do sistema.");

            Console.WriteLine("Digite o número da opção desejada:");

            return Console.ReadLine();
        }
        /// <summary>
        /// Metodo que insere informações dentro da nossa base de dados
        /// </summary>
        /// <param name="baseDeDados">Basse de dados como ref para alterar para todos os metodos</param>
        /// <param name="indiceBase">Indice da nossa base como red para alterar para todos os metodos</param>
        public static void AlocarLivro(ref string[,] baseDeDados, ref int indiceBase)
        {
            Console.WriteLine("---------Inserindo dados na lista---------");

            Console.WriteLine("Informe o nome do livro que deseja alocar:");

            var nome = Console.ReadLine();

            Console.WriteLine("Informe o Autor:");

            var autor = Console.ReadLine();

            AumentaTamanhoLista(ref baseDeDados);


            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;

                baseDeDados[i, 0] = (indiceBase++).ToString();

                baseDeDados[i, 1] = nome;

                baseDeDados[i, 2] = autor;

                baseDeDados[i, 3] = "true";

                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                break;
            }

            Console.WriteLine("Livro alocado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();

        }
        /// <summary>
        /// Mostra as informações dentro da nossa lista de dados"base de dados"
        /// </summary>
        /// <param name="baseDeDados">base de dados para a leitura e mostrar pro usuario</param>
        /// <param name="mostrarRegistroNAtivos"> Quando identificado com o valor true, o mesmo
        /// mostra os valores que não estão ativos dentro do sistema.</param>
        public static void MostrarInformacoes(string[,] baseDeDados, string mostrarRegistroNAtivos = "false")
        {

            Console.WriteLine("Apresentação das informações dentro da base de dados.");

            if (mostrarRegistroNAtivos == "true")
                Console.WriteLine("Livros devolvidos por você:");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {

                if (baseDeDados[i, 3] != mostrarRegistroNAtivos)
                    Console.WriteLine($"ID {baseDeDados[i, 0]} " +
                          $"- Nome:{baseDeDados[i, 1]} " +
                          $"- Autor:{baseDeDados[i, 2]}" +
                          $"- Data Alteração:{baseDeDados[i, 4]}");
            }



            Console.WriteLine("Resultados apresentados com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo utilizado para remover um livro pelo id dentro do sistema
        /// </summary>
        /// <param name="baseDeDados">Base de dados em que ele irá remover o livro pelo id</param>
        public static void DevolverLivro(ref string[,] baseDeDados)
        {

            Console.WriteLine("Area de remoção de livro do sistema.");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                Console.WriteLine($"ID:{baseDeDados[i, 0]} " +
                    $"- Nome:{baseDeDados[i, 1]} " +
                    $"- Autor:{baseDeDados[i, 2]}");

            Console.WriteLine("Informe o id do livro a ser removido:");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {
                    baseDeDados[i, 3] = "false";

                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }

            Console.WriteLine("Operações finalizadas.");
            Console.WriteLine("Para retornar ao menu inicial apertar qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que aumenta as informações disponivel para cadastro dentro da nossa lista
        /// </summary>
        /// <param name="baseDeDados">retorna nossa base de dados</param>
        public static void AumentaTamanhoLista(ref string[,] baseDeDados)
        {

            var limiteDaLista = true;

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {

                if (baseDeDados[i, 0] == null)
                    limiteDaLista = false;
            }

            if (limiteDaLista)
            {

                var listaCopia = baseDeDados;

                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 5];

                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {

                    baseDeDados[i, 0] = listaCopia[i, 0];

                    baseDeDados[i, 1] = listaCopia[i, 1];

                    baseDeDados[i, 2] = listaCopia[i, 2];

                    baseDeDados[i, 3] = listaCopia[i, 3];

                    baseDeDados[i, 4] = listaCopia[i, 4];
                }

                Console.WriteLine("Lista de livros atualizada foi atualizado.");
            }


        }


    }
}


