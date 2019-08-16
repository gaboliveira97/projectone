using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimples.Carrega
{
    class CarregarLista

    {
        string[,] listaDeNome;

        public string [,] ListaNome { get { return listaDeNome; } }
        /// <summary>
        /// Metodo que carrega as informações dentro da nossa lista criada no metodo "MAIN"
        /// E mostra as iformações logo em seguida
        /// </summary>
        /// <param name="arrayBi">Nossa lista a ser carregada</param>
        public CarregarLista()
        {
            //Assinamos nossa lista no metodo construtor
            //com isso ja deixamos a lista pronta para uso nos demais metodos 
            //sem precisar de um parametro para isso
            listaDeNome = new string[10, 2];
        }
        public void CarregaInformacoesEListaElasEmTela(string[,] arrayBi)
        {
            //Usando um laço simples para colocar valores mas no mesmo agora utilizando o
            //GetLength com o parametro "0" para indicar que queremos o tamanho da primeira coluna
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Carregando o que podemos chamar de ID, identificador do nosso registro unico
                arrayBi[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informação extra para deixar legal
                arrayBi[i, 1] = $"Felipe_{i}";
            }

            //Lembrando que GetLength é um metodo e usamos "(parametro)" com parametro ou as vezes sem 
            //para realizar a chamada do mesmo
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Formatamos uma string de maneira que os dados sejam apresentados 
                Console.WriteLine($"ID:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
            }
        }
    }
}
