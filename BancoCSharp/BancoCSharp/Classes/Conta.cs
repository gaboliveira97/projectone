using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCSharp.Classes
{

    class Conta
    {
        double saldo = 0;
        public double Saldo { get { return saldo; } }
        public Conta()
        {
            saldo = 1000;
        }

        /// <summary>
        /// Metodo para sacar dinheiro de acordo com o saldo disponivel
        /// </summary>
        /// <param name="valor">Valor para sacar</param>
        /// <returns>restorna se o saque foi feito ou não/returns>
        public bool Sacar(double valor)

        {

            if (valor <= saldo)
            {//desconta um valor do saldo
                saldo -= valor;
                return true;
            }

            return false;
        }

        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
