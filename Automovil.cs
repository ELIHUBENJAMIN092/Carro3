using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro3
{
    public class Automovil : Vehiculo
    {
        public int puertas;

        public int Puertas
        {
            get { return puertas; }
            set
            {
                if (value >= 2) // Se asume que un automóvil debe tener al menos 2 puertas
                    puertas = value;
                else
                    Console.WriteLine("Error: Un automóvil debe tener al menos 2 puertas.");
            }
        }

        public new void getInformation()
        {
            base.getInformation();
            Console.WriteLine($"Número de puertas: {puertas}");
        }
    }

}

