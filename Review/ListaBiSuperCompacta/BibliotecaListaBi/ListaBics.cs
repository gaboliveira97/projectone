using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSuperCompacta.BibliotecaListaBi
{
    class ListaBi
    {
        string[,] listaBi;
        /// <summary>
        /// Iniciamos a nossa lista bi, agora quando iniciamos uma instancia dela ela ja 
        /// vem com a lista carregada.
        /// </summary>
        public ListaBi()
        {
            listaBi = new string[5, 2];

            CarregaListaBi();
        }
        /// <summary>
        /// Aqui já carregamos "Popular" a lista quando chamado esse metodo.
        /// </summary>
        public void CarregaListaBi()
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                listaBi[i, 0] = i.ToString();
                listaBi[i, 1] = $"Felipe_{i}";
                //Ao adicionar o registro na lista ja mostramos na tela
                Console.WriteLine($"Id:{i} Nome:Felipe_{i}");
            }
        }
        /// <summary>
        /// Aqui temos o metodo que realiza a pesquisa das informações em nossa
        /// lista 
        /// </summary>
        /// <param name="idPesquisa">Aqui vai o id da nossa informação</param>
        public void PesquisaLista(string idPesquisa)
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)

            {
                Console.WriteLine("Resultado encontrado com sucesso!");
                Console.WriteLine($"Você pesquisou pelo registro: {listaBi[i, 1]}");
                //saio do metodo porque não preciso mais dele.
                return;
            }
            Console.WriteLine("Nenhum regustro encontrado com esse id");
        }
    }
}
