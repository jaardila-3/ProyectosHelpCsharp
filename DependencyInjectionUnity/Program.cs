using System;
using Unity;

namespace DependencyInjectionUnity
{
    class Program
    {
        //declaramos y configuramos la variable
        private static readonly UnityContainer _unityContainer = UnityConfig.RegisterDependencies(_unityContainer);
        static void Main(string[] args)
        {            
            var carrito = _unityContainer.Resolve<Icarrito>();
            var total = carrito.CalcularTotal(5);
            Console.WriteLine("El total es: {0}", total);
            Console.ReadLine();
        }        
    }

    

}
