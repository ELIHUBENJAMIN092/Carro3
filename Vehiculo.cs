using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro3
{
    public class Vehiculo
    {
        public string marca;
        public string modelo;
        public int año;

        public string Marca
        {
            
                get { return marca; }
                set
        {
                    if (!string.IsNullOrEmpty(value))
                        marca = value;
                    else
                        Console.WriteLine("Error: La marca no puede estar vacía.");
                }
            }

    public string Modelo
        {
            get { return modelo; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    modelo = value;
                else
                    Console.WriteLine("Error: El modelo no puede estar vacío.");
            }
        }

        public int Año
        {
            get { return año; }
            set
            {
                if (value > 0)
                    año = value;
                else
                    Console.WriteLine("Error: El año debe ser un valor positivo.");
            }
        }

        public void getInformation()
        {
            Console.WriteLine($"Información del vehículo: Marca - {marca}, Modelo - {modelo}, Año - {año}");
        }

        public void runAction()
        {
            Console.WriteLine("Realizando una acción genérica del vehículo.");
        }

    }
}
