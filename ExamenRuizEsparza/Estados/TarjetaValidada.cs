using ExamenRuizEsparza.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRuizEsparza.Estados
{
    public class TarjetaValidada : EstadoCajero
    {
        public bool Valida(Cajero cajero)
        {
            if(cajero.pin == 1234 || cajero.pin == 4321)
            {
                Console.WriteLine("");
                Console.WriteLine("Pin valido.");
                Console.WriteLine("");
                return true;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Pin inválido.");
                Console.WriteLine("");
                return false;
            }
        }
    }
}
