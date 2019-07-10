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
            MostrarSejabemvindo();

            if (MenuInicial() == 1)
            {
                Console.Clear();

                MostrarSejabemvindo();

                Console.WriteLine("Menu - Alocação de Livros");
                Console.WriteLine("Digite o nome do Livro a ser alocado:");

                var livro = Console.ReadLine();
                if   (PesquisadeLivroParaAlocar(livro))
                {
                    Console.Clear();
                    Console.WriteLine("Você deseja alocar o livro? Para sim (1) Para não (0)");

                    if (Console.ReadKey().KeyChar.ToString() == "1") 
                    {
                        AlocarLivro(livro);
                        Console.Clear();
                        Console.WriteLine("Livro alocado com sucesso!");
                        //futuro esperar calma
                    }
                    else

                        Console.Clear();
                        Console.WriteLine("listagem de livros");

                    for (int i = 0; i < Basedelivros.GetLength(0); i++)
                    {
                        Console.WriteLine($"Nome: {Basedelivros[i, 0]} Disponivel: {Basedelivros[i, 1]}");

                    }
                }
            }

            Console.ReadKey();

        }
        /// <summary>
        /// Mostra tela com a frase seja bem vindo ao entrar no programa.
        /// </summary>

        public static void MostrarSejabemvindo()
        {
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("          Sistema de alocação de livros");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine("         Desenvolvido pelas industrias BNU");
            Console.WriteLine("__________________________________________________");
        }
        /// <summary>
        /// Metodo mostra o conteudo do menu e as opções de escolha.
        /// </summary>
        /// <returns>Retonra o numero do menu escolhido.</returns>
        public static int MenuInicial()

        {
            Console.WriteLine("Menu Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1- Alocar um livro.");
            Console.WriteLine("2- Sair do sistema.");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo que carrega base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()

        {
            Basedelivros = new string[2, 2]
            {
                {"O pequeno", "sim" },
                {"O grande", "não" }
            };
        }

        /// <summary>
        /// Metodo que retorna se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomelivro">Nome do livro a  ser pesquisado</param>
        /// <returns>Retorna verdadeiro em caso o livro estiver livre para alocação.</returns>
        public static bool PesquisadeLivroParaAlocar(string nomelivro)

        {
            for (int i = 0; i < Basedelivros.GetLength(0); i++)
            {
                if (nomelivro == Basedelivros[i, 0])
                {

                    Console.WriteLine($"O livro  {nomelivro}" +
                        $" pode ser alocado?  {Basedelivros[i, 1]}");

                    return Basedelivros[i, 1] == "sim";
                }
            }
            return false;
        }

        /// <summary>
        /// Metodo que aloca o livro de acordo com o parametro passado. 
        /// </summary>
        /// <param name="nomeLivro"></param>
        public static void AlocarLivro(string nomeLivro)
        {
            for (int i = 0; i < Basedelivros.GetLength(0); i++)
            {
                if (nomeLivro == Basedelivros[i, 0])
                    Basedelivros[i, 1] = "não";
            }
        }
       	
    }
}
