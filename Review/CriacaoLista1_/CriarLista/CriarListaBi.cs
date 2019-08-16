using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoLista1_.CriarLista
{
    class CriarListaBi
    {
        string[,] listaBi;

        public CriarListaBi()

        {
            listaBi = new string[5, 2];

            CarregaLista();

        }

        public void CarregaLista()
        {

            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                listaBi[i, 0] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
            }

            foreach (var item in listaBi)
                Console.WriteLine(item);
        }

        public void LimparLista()
        {

            for (int i = 0; i < listaBi.GetLength(0); i++)
                listaBi[i, 0] = string.Empty;

            foreach (var item in listaBi)
                Console.WriteLine(item);

        }
    }
}
