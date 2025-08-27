using System;
using System.Collections.Generic;
using System.Linq;
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
                            break;
                        case EnumMenu.Depositar:
                            break;
                        case EnumMenu.Retirar:
                            break;
                        case EnumMenu.Salir:
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
            Console.WriteLine("Dame ");
            string pin = Console.ReadLine(); 
            if (pin == "1234")
                return true;
            else
                return false;
        }
    }
}