using ListaBiManeiraSimples.Carrega;
using ListaBiManeiraSimples.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando nossa lista com mais de uma dimensão
            string[,] listaDeNome = new string[5, 2];
            //Aqui iniciamos nosso objeto em memoria
            var carregaListas = new CarregarLista();
            //Aqui chamamos nosso metodo.
            carregaListas.CarregaInformacoesEListaElasEmTela(listaDeNome);

            var showLista = new MostrarLista();

            showLista.PesquisandoInformacoesNaNossaLista(carregaListas.ListaNome, "0");

            Console.ReadKey();
        }

    }
}
