using ExamenRuizEsparza.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRuizEsparza
{
    class Program
    {
        static void Main(string[] args)
        {
            Cajero cajero1 = new Cajero(0, 0);
            bool b = ValidarPin(cajero1);
            while (b)
            {
                b = ValidarPin(cajero1);
            }
            b = ValidarRetiro(cajero1);
            while (b)
            {
                b = ValidarRetiro(cajero1);
            }

            System.Threading.Thread.Sleep(50000);
        }


        private static bool ValidarPin(Cajero cajero1)
        {
            bool b = false;
            cajero1.Validar(cajero1);

            Console.WriteLine("Introduzca pin:");
            var pin = Console.ReadLine();
            cajero1.pin = int.Parse(pin);



            cajero1.TarjetaValida();
            b = cajero1.Validar(cajero1);

            if (b)
            {

                return false;
            }
            else
            {
                
                return true;
            }
        }

        private static bool ValidarRetiro(Cajero cajero1)
        {
            bool b = false;
            Console.WriteLine("Introduzca cantidad a retirar:");
            var retiro = Console.ReadLine();
            cajero1.retiro = int.Parse(retiro);
            cajero1.EntregaDeDinero();
            b = cajero1.Validar(cajero1);

            if (b)
            {
                cajero1.SinTarjeta();
                cajero1.Validar(cajero1);
                if (cajero1.monto == 0)
                {
                    cajero1.FueraDeServicio();
                    cajero1.Validar(cajero1);
                }
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
