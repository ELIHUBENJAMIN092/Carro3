using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro3
{
    public class Camioneta : Vehiculo
    {
        public double capacidadCarga;

        public double CapacidadCarga
        {
            get { return capacidadCarga; }
            set
            {
                if (value >= 0)
                    capacidadCarga = value;
                else
                    Console.WriteLine("Error: La capacidad de carga no puede ser un valor negativo.");
            }
        }

        public new void getInformation()
        {
            base.getInformation();
            Console.WriteLine($"Capacidad de carga: {capacidadCarga} toneladas");
        }
    }
}

