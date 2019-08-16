using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoMedia
{
    class BoletimAlunos
    {
        public int MediaNotas(int Nota1, int Nota2, int Nota3)

        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }
        public int frequencia(int totalAulas, int numeroFaltas)
        {
            return ((totalAulas - numeroFaltas) * 100) / totalAulas;
        }

        public void situacao(int media, int frequencia)
        {
            if ((media >= 7) && (frequencia >= 75))
            {
                Console.WriteLine($"Aluno aprovado com média {media} e frequencia de {frequencia}%");
            }
            else
            {
                Console.WriteLine($"Aluno reprovado com média {media} e frequencia de {frequencia}%");
            }

        }
    }
}
