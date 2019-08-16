using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InserirAlunos
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] baseDeDados = new string[5, 4];

            int IndiceBaseDeDados = 0;

            Console.WriteLine("Iniciando sistema Registro de Alunos");

            
        }
        /// <summary>
        /// Apresenta as  informações do menu inicial.
        /// </summary>
        /// <returns>Retorna o menu escolhido.</returns>
        public string MenuInicial()
        {

            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inseir um novo registro.");
            Console.WriteLine("2 - Remover um registro.");
            Console.WriteLine("3 - Listar registros.");
            Console.WriteLine("4 - Alterar registros.");
            Console.WriteLine("5 - Sair do sistema.");

            Console.WriteLine("Digite o número da opção desejada:");

            return Console.ReadLine();
        }
        /// <summary>
        /// Metodo que insere informações dentro da nossa base de dados
        /// </summary>
        /// <param name="baseDeDados">Basse de dados como ref para alterar para todos os metodos</param>
        /// <param name="indiceBase">Indice da nossa base como red para alterar para todos os metodos</param>
        public void RegistroDeInformacoes(ref string[,] baseDeDados, ref int indiceBase)
        {
            Console.WriteLine("---------Inserindo Registros ---------");

            Console.WriteLine("Informe o nome:");

            var nome = Console.ReadLine();

            Console.WriteLine("Informe a média:");

            var media = Console.ReadLine();

            Console.WriteLine("Informe a frequencia:");

            var frequencia = Console.ReadLine();

            Console.WriteLine("Informe a situação:");

            var situacao = Console.ReadLine();

            AumentaTamanhoLista(ref baseDeDados);


            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;

                baseDeDados[i, 0] = (indiceBase++).ToString();

                baseDeDados[i, 1] = nome;

                baseDeDados[i, 2] = media;

                baseDeDados[i, 3] = frequencia;

                baseDeDados[i, 4] = situacao;

                break;
            }

            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();

        }
        /// <summary>
        /// Mostra as informações dentro da nossa lista de dados"base de dados"
        /// </summary>
        /// <param name="baseDeDados">base de dados para a leitura e mostrar pro usuario</param>
        /// <param name="mostrarRegistroNAtivos"> Quando identificado com o valor true, o mesmo
        /// mostra os valores que não estão ativos dentro do sistema.</param>
        public void MostrarInformacoes(string[,] baseDeDados, string mostrarRegistroNAtivos = "false")
        {

            Console.WriteLine("Apresentação das informações dentro da base de dados.");

            if (mostrarRegistroNAtivos == "true")
                Console.WriteLine("Registros desativados dentro do sistema.");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {

                if (baseDeDados[i, 3] != mostrarRegistroNAtivos)
                    Console.WriteLine($"ID {baseDeDados[i, 0]} " +
                          $"- Nome:{baseDeDados[i, 1]} " +
                          $"- Média:{baseDeDados[i, 2]}" +
                          $"- Frequencia:{baseDeDados[i, 3]}" +
                        $"- Situação:{baseDeDados[i, 4]}");
        }


            Console.WriteLine("Resultados apresentados com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo utilizado para remover um registro pelo id dentro do sistema
        /// </summary>
        /// <param name="baseDeDados">Base de dados em que ele irá remover o registro pelo id</param>
        public void RemoverInformacoes(ref string[,] baseDeDados)
        {

            Console.WriteLine("Area de remoção de registro do sistema.");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
                Console.WriteLine($"ID {baseDeDados[i, 0]} " +
                          $"- Nome:{baseDeDados[i, 1]} " +
                          $"- Média:{baseDeDados[i, 2]}" +
                          $"- Frequencia:{baseDeDados[i, 3]}" +
                        $"- Situação:{baseDeDados[i, 4]}");

            Console.WriteLine("Informe o id do registro a ser removido:");
            var id = Console.ReadLine();

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {

                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {
                    baseDeDados[i, 3] = "false";

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
        public void AumentaTamanhoLista(ref string[,] baseDeDados)
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

                Console.WriteLine("O tamanho da lista foi atualizado.");
            }

        }
    }
}

