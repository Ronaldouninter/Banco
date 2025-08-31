using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Acciones
    {
        private double saldo;

        public double consultarsaldo()
        {
            return saldo;

        }

        public void depositar(double dep)
        { 
            saldo += dep;
        }

        public void retirar (double ret)
        {
            if (saldo> ret)
                saldo -= ret;


            else
                Console.WriteLine("No tienes saldo suficiente");
        }

    }
}

        