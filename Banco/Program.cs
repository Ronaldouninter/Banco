using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();


            bool entrar = loggin();
            if (entrar)
            {
                while (true)
                {
                    switch (Menu())
                    {
                        case EnumMenu.Consultar:
                            Console.WriteLine("tu saldo es: " + acciones.consultarsaldo());
                            break;
                        case EnumMenu.Depositar:
                            Console.WriteLine("¿Cuánto va a depositar?");
                            double dep = Convert.ToDouble(Console.ReadLine());

                            acciones.depositar(dep);
                            Console.WriteLine("Depósito realizado. Tu saldo es:  " + acciones.consultarsaldo());
                            break;
                        case EnumMenu.Retirar:
                            Console.WriteLine("¿Cuánto va a retirar ?");
                            double ret = Convert.ToDouble(Console.ReadLine());

                            acciones.retirar(ret);
                            Console.WriteLine("Retiro realizado. Tu saldo es: " + acciones.consultarsaldo());
                            break;
                        case EnumMenu.Salir:
                            Console.WriteLine("Gracia por usar el Banco Santander");
                            Environment.Exit(0);
                            break;

                        default:
                            break;
                    }
                }
            }

        }

        public enum EnumMenu
        {
            Consultar = 1, Depositar, Retirar, Salir
        }

        static EnumMenu Menu()
        {
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Retirar");
            Console.WriteLine("4. Salir");
            EnumMenu opcion = (EnumMenu)Convert.ToInt32(Console.ReadLine());
            return opcion;

        }

        static bool loggin()
        {
            Console.WriteLine("Dame pin  ");
            string pin = Console.ReadLine();
            if (pin == "1234")
                return true;
            else
                return false;
        }


    }
}