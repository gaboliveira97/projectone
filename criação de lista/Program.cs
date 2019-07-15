using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criação_de_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciando uma lista de string com Array linear
            string[] lista = new string[10]; //Aqui definimos as posições da lista iniciando ela com 10 espaços na memoria para alocar informações de textos.

            // Laços que usamos geralmente para andar sobre nossa lista 
            for (int i = 0; i < lista.Length; i++)
            {
                //Carregando os valores de nossa lista.
                //aonde "i" representa cada espaço que temos disponivel.
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
                // DateTime é um tipo do .net c# que disponibiliza funçoes relacionadas a datas 
                //e horas, se precisar trabalhar com essas informações use ele.

            }
            //Laço de repetição que usamos para varrer nossa lista de maneira mais simples.
            foreach (var item in lista) //var item indica uma unidade da nossa lista in lista.
                Console.WriteLine(item); //Aqui apresentamos essa informação na tela 

            Console.ReadKey();

            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty; //Aqui limpamos nosso valor dentro da coleção

            //Laço de repetição que usamos para varrer nossa lista de maneira mais simples.
            foreach (var item in lista) //var item indica uma unidade da nossa lista in lista.
                Console.WriteLine(item); //Aqui apresentamos essa informação na tela 

            Console.ReadKey();
        }
    }
}
