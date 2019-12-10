using ExamenRuizEsparza.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRuizEsparza.Estados
{
    public class EntregaDeDinero : EstadoCajero
    {
        public bool Valida(Cajero cajero)
        {
            if(cajero.monto - cajero.retiro < 0)
            {
                Console.WriteLine("");
                Console.WriteLine("El cajero no cuenta con saldo suficiente.");
                Console.WriteLine("");
                return false;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Ha retirado " + cajero.retiro + " exitosamente.");
                Console.WriteLine("");
                cajero.monto = cajero.monto - cajero.retiro;
                return true;
            }
            
        }

    }
}
