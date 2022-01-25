using System;

namespace TryParse
{
    class Program
    {
        int edad = 32;
        int añoActual = 2020;

        static void Main(string[] args)
        {
            string numeroComoString = "128";
            int valorParseado;

            //tryparse
            bool exito = int.TryParse(numeroComoString, out valorParseado);
            if (exito)
                Console.WriteLine("Parsing exitoso - el numero es {0}", valorParseado);
            else
                Console.WriteLine("Parsing fallido");

            
            //concatenar segunda opción
            string nombre = "Jorge";
            string apellido = "Ardila";
            int hijos = 1;
            Console.WriteLine("Hola! soy {0} {1} y tengo {2} hijo", nombre, apellido, hijos);
            
            Console.Read();
        }

        //formas de usar el método get - set        
        public int Edad
        {
            get
            {
                return edad; //too: return a*b*c;
            }
            set
            {
                edad = value;
            }
        }

        public int Año
        {
            get
            {
                return añoActual;
            }
            set
            {
                if (value < 0)
                    throw new Exception("El año debe ser positivo");
                
                añoActual = value;
            }
        }

        public int CualquierEdad
        {
            get => edad;
            set => edad = value;
        }
    }
}
