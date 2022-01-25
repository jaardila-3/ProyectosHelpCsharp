using Ninject;
using System;
using System.Reflection;

namespace DependencyInjectionNinject
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var carrito = kernel.Get<Icarrito>();
            //var carrito = kernel.GetAll<Icarrito>();
            var total = carrito.CalcularTotal(5);
            Console.WriteLine("El total es: {0}", total);
            Console.ReadLine();
        }
    }
}
