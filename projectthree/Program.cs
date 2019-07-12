using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectthree
{
    class Program
    {
        static string[,] Basedelivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 3)
            {
                if (opcaoMenu == 1)
                    AlocarUmLivro();

                if (opcaoMenu == 2)
                    DesalocarUmLivro();

                opcaoMenu = MenuPrincipal();
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Mostra as informações iniciais do sistema.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("         Sistema de alocação de livros.");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("    Desenvolvido pelas industrias BNU Sistemas");
            Console.WriteLine("________________________________________________");
        }
        /// <summary>
        /// Metodo que mostra o menu inicial com as opções para escolha.
        /// </summary>
        /// <returns>Retorna o número do menu escolhido.</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Devolver um livro.");
            Console.WriteLine("3 - Sair do sistema.");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo que carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            Basedelivros = new string[2, 2]
            {
                {"O pequeno","sim"},
                {"O grande","não"}
            };
        }
        /// <summary>
        /// Metodo que retorna se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado</param>
        /// <returns>Retorna verdadeiro em caso o livro estiver livre para alocação.</returns>
        public static bool? PesquisaLivroParaAlocacao(string nomeLivro)
        {
            for (int i = 0; i < Basedelivros.GetLength(0); i++)
            {
                if (Compararnomes(nomeLivro, Basedelivros[i, 0]))

                {
                    Console.WriteLine($"O livro:{nomeLivro}" +
                          $" pode ser alocado?:{Basedelivros[i, 1]}");

                    return Basedelivros[i, 1] == "sim";
                }
            }

            Console.WriteLine("Nenhum livro com esse nome foi encontrado. Deseja buscar novamente?");
            Console.WriteLine("Digite o número da opção desejada. Sim(1) ou Não(2)");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if (opcao == 1) ;
            {
                Console.WriteLine("Digite o nome do linho a ser pesquisado:");
                nomeLivro = Console.ReadLine();

                return PesquisaLivroParaAlocacao(nomeLivro);

            }
            return null;


        }
        /// <summary> 
        /// Metodo para alterar a informação de alocação do livro.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro</param>
        /// <param name="alocar">Valor booleano que define se o livro esta ou não disponivel.</param>
        public static void AlocarLivro(string nomeLivro, bool alocar)
        {
            for (int i = 0; i < Basedelivros.GetLength(0); i++)
            {
                if (nomeLivro == Basedelivros[i, 0])
                {
                    Basedelivros[i, 1] = alocar ? "não" : "sim";
                }
            }

            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Livro atualizado com sucesso!");
        }
        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação do menu 1
        /// </summary>
        public static void AlocarUmLivro()
        {
            MostrarMenuInicialLivros("Alocar um livro:");

            var nomedolivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(nomedolivro);

            if (resultadoPesquisa != null && resultadoPesquisa == true)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja alocar o livro? para sim(1) para não(0)");

                AlocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeLivros();

                Console.ReadKey();
            }
        }


        /// <summary>
        /// Metodo que mostra a lista de livros atualizado
        /// </summary>
        public static void MostrarListaDeLivros()
        {
            Console.WriteLine("Listagem de livros:");

            for (int i = 0; i < Basedelivros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {Basedelivros[i, 0]} Disponivel:{Basedelivros[i, 1]}");
            }
        }
        public static void DesalocarUmLivro()
        {
            MostrarMenuInicialLivros("Desalocar um livro:");

            MostrarListaDeLivros();

            var nomedolivro = Console.ReadLine();
            var resultadoPesquisa = PesquisaLivroParaAlocacao(nomedolivro);

            if (!PesquisaLivroParaAlocacao(nomedolivro) != null
                && PesquisaLivroParaAlocacao(nomedolivro) == false)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja desalocar o livro? para sim(1) para não(0)");

                AlocarLivro(nomedolivro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeLivros();

                Console.ReadKey();
            }
        }
        public static void MostrarMenuInicialLivros(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do livro para realizar a operação:");
        }
        public static bool Compararnomes(string primeiro, string segundo)


        {
            if (primeiro.ToLower().Replace(" ", "")
                == segundo.ToLower().Replace(" ", "")) ;

            return true;

            return false;

        }



    }

}




