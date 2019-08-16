using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina.ComprarLanche
{
    class ComprarLanche
    {
        double saldo = 20;
        public double Saldo { get { return saldo; } }

        public ComprarLanche()
        {
            saldo = 20;
        }
        public bool Comprar(double lanche)

        {

            if (lanche <= saldo)
            {
                saldo -= lanche;
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

