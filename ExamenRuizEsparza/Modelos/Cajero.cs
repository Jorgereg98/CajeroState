using ExamenRuizEsparza.Estados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenRuizEsparza.Modelos
{
    public class Cajero
    {
        private EstadoCajero estado;
        public double monto;
        public int pin;
        public int retiro;
        

        public Cajero(int pin, int retiro)
        {
            this.monto = 5000;
            estado = new SinTarjeta();
            this.pin = pin;
            this.retiro = retiro;
        }

        public void TarjetaValida()
        {
            estado = new TarjetaValidada();
            Console.WriteLine("");

        }

        public void SinTarjeta()
        {
            estado = new SinTarjeta();
            Console.WriteLine("");
        }

        public void FueraDeServicio()
        {
            estado = new FueraDeServicio();
            Console.WriteLine("");

        }

        public void EntregaDeDinero()
        {
            estado = new EntregaDeDinero();
        }

        public bool Validar(Cajero cajero)
        {
            return estado.Valida(cajero);
            
        }
    }
}
