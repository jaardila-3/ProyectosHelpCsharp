using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            var th = new Thread(RecogerDato); //Se instancia un hilo par ejecutar
            var ts = new TimeSpan(0, 0, 0, 3); // días,horas,minutos y segundos
            th.Start();

            if (th.Join(ts))//if (th.Join(3000))
            {
                //OK. th se terminó de ejecutar en menos de 3 segundos
                Console.WriteLine("termino");
                Console.ReadLine();
            }
            else
            {
                //No
                th.Abort(); //Se aborta la ejecucion del hilo
                //throw new Exception("Se supero el tiempo de espera para ejecutar recogerDato");
                Console.WriteLine("se aborto");
                Console.ReadLine();

            }
        }

        public static void RecogerDato()
        {
            Thread.Sleep(4000); 
        }
    }
}
