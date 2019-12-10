using ExamenRuizEsparza.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRuizEsparza.Estados
{
    public class SinTarjeta : EstadoCajero
    {
        public bool Valida(Cajero cajero)
        {
            Console.WriteLine("");
            Console.WriteLine("Sin tarjeta");
            Console.WriteLine("");
            return false;
        }
    }
}
