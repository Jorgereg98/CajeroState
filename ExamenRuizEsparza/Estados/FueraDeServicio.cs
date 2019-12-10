using ExamenRuizEsparza.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRuizEsparza.Estados
{
    public class FueraDeServicio : EstadoCajero
    {
        public bool Valida(Cajero cajero)
        {
            if(cajero.monto == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Cajero fuera de servicio");
                Console.WriteLine("");
            }
            return false;
            
        }
    }
}
