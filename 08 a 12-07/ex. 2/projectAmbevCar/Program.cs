using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Locadora_Ambev
{
    class Program
    {
        static string[,] baseDeVeiculos;
        static void Main(string[] args)
        {
            CarregarBaseDeDados();

            var opcaoMenu = MostrarMenuInicial();

            while (opcaoMenu != 4)
            {
                if (opcaoMenu == 1)
                    AlocarumVeiculo();

                if (opcaoMenu == 2)
                    DesalocarVeiculo();

                if (opcaoMenu == 3)
                    MostrarListaVeiculo();
                Console.ReadLine();

                opcaoMenu = MostrarMenuInicial();
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Mostra o seja bem vindo
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("   Bem Vindo ao sistema de alocação de Carros Ambev");
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("       Desenvolvido pela empresa BNU Sistemas");
            Console.WriteLine("____________________________________________________");

        }
        public static int MostrarMenuInicial()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1- Alocar um veiculo?");
            Console.WriteLine("2- Devolver um veiculo?");
            Console.WriteLine("3- Listagem de veiculos:");
            Console.WriteLine("4- Deseja sair do sistema?");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            return opcao;

        }
        /// <summary>
        /// Metodo que carrega base de dados do nosso sistema.
        /// </summary>
        public static void CarregarBaseDeDados()
        {
            baseDeVeiculos = new string[3, 4]
            {
                {"Vectra","2011","sim","Bom estado de conservação"},
                {"Cruze","2015","sim","Excelente estado de conservação"},
                {"Fusion","2014","não","Em manutenção"},

            };
        }
        /// <summary>
        /// Metodo que retorna se o veiculo pode ser alocado
        /// </summary>
        /// <param name="ModeloDoVeiculo">Nome do modelo a ser pesquisado</param>
        /// <returns>Vai retornar verdadeiro em caso do veiculo estiver disponivel para alocação</returns>
        public static bool? pesquisaDeVeiculo(ref string ModeloDoVeiculo)
        {
            for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
            {
                if (PesquisarDeNovo(ModeloDoVeiculo, baseDeVeiculos[i, 0]))
                {
                    Console.WriteLine($"O veiculo:{ModeloDoVeiculo}" +
                          $" pode ser alocado?:{baseDeVeiculos[i, 2]}");

                    return baseDeVeiculos[i, 1] == "sim";
                }
            }

            Console.WriteLine("Nenhum veiculo com esse nome foi encontrado. Deseja buscar novamente?");
            Console.WriteLine("Digite o número da opção desejada. Sim(1) ou Não(2)");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            if (opcao == 1) ;
            {
                Console.WriteLine("Digite o nome do veiculo a ser pesquisado:");
                ModeloDoVeiculo = Console.ReadLine();

                return pesquisaDeVeiculo(ref ModeloDoVeiculo);

            }
            return null;
        }
        /// <summary>
        /// Metodo que aloca o veiculo de acordo com o parametro passado
        /// </summary>
        /// <param name="ModeloDoVeiculo">Modelo do veiculo a ser alocado</param>
        public static void AtualizarCarro(string ModeloDoVeiculo, bool alocar)
        {
            for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
            {
                if (ModeloDoVeiculo == baseDeVeiculos[i, 0])
                    baseDeVeiculos[i, 2] = alocar ? "não" : "sim";
            }
            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("\\///\\///\\///\\///\\///\\///\\///\\///\\////\\\\////\\/");
            Console.WriteLine("\\\\////\\\\Lista atualizado com SUCESSO! \\////\\\\");
            Console.WriteLine("\\///\\///\\///\\///\\///\\///\\///\\///\\////\\\\////\\/");
        }
        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação  do meu 1
        /// </summary>
        public static void MostrarMenuAlocacao()
        {
            MostrarMenuInicial("Alocar um veiculo");

            var ModeloDoVeiculo = Console.ReadLine();
            var resultadoPesquisa = pesquisaDeVeiculo(ref ModeloDoVeiculo);

            if (resultadoPesquisa != null && resultadoPesquisa == true)


            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja alocar este veiculo? sim( 1 ) || não( 2 )");

                AtualizarCarro(ModeloDoVeiculo, Console.ReadKey().KeyChar.ToString() == "2");

                MostrarListaVeiculo();

                Console.ReadKey();

            }

        }
        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação do meu1
        /// </summary>
        public static void AlocarumVeiculo()
        {
            MostrarMenuInicial("Alocar Veiculo");

            var ModeloDoVeiculo = Console.ReadLine();
            var resultadoPesquisa = pesquisaDeVeiculo(ref ModeloDoVeiculo);

            if (resultadoPesquisa !=null && resultadoPesquisa == true)
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja alocar este veiculo? sim( 1 ) || não( 2 )");

                AtualizarCarro(ModeloDoVeiculo, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaVeiculo();

                Console.ReadKey();
            }

        }
        /// <summary>
        /// Metodo que mostra a lista de veiculos atualizado
        /// </summary>
        public static void MostrarListaVeiculo()
        {
            Console.WriteLine("Lisa de Veiculos:");
            for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeVeiculos[i, 0]} || ano:{baseDeVeiculos[i, 1]} || Disponivel:{baseDeVeiculos[i, 2]} " +
                    $"|| Condições:{baseDeVeiculos[i, 3]}");
            }
        }
        public static void DesalocarVeiculo()
        {
            MostrarMenuInicial("Desalocar Veiculo");

            MostrarListaVeiculo();

            var ModeloDoVeiculo = Console.ReadLine();
            var resultadoPesquisa = pesquisaDeVeiculo(ref ModeloDoVeiculo);


            if (resultadoPesquisa != null && resultadoPesquisa == false)
                {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja desalocar este veiculo? sim( 1 ) || não( 2 )");

                AtualizarCarro(ModeloDoVeiculo, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaVeiculo();

                Console.ReadKey();
            }
        }
        public static void MostrarMenuInicial(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o modelo do veiculo a ser alugado:");
        }
        public static bool PesquisarDeNovo(string primeiro, string segundo)

        {
            if (primeiro.ToLower().Replace(" ", "")
                == segundo.ToLower().Replace(" ", "")) ;

            return true;

            return false;

        }
    }
}




