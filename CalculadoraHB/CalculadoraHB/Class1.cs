using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraHB
{
    public class Class1
    {
        public int CalculoAdicao(int Valor1, int Valor2)
        {
            return (Valor1 + Valor2);
        }

        public int CalculoSubtracao(int Valor1, int Valor2)
        {
            return (Valor1 - Valor2);
        }
        public int CalculoMultiplicacao(int Valor1, int Valor2)
        {
            return (Valor1 * Valor2);
        }

        public int CalculoDivisao(int Valor1, int Valor2)
        {
            return (Valor1 / Valor2);
        }

        public int AreaRetangulo(int Base, int Altura)
        {
            return (Base * Altura);
        }

        public double AreaTriangulo(double lado)
        {
            return (Math.Pow(lado, 2) * Math.Sqrt(3)) / 4;
        }

        public double RaioCirculo(double area)
        {
            return (Math.Sqrt(Math.PI / area));
        }
    }

}


