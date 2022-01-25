using Unity;

namespace DependencyInjectionUnity
{
    public static class UnityConfig
    {
        public static UnityContainer RegisterDependencies(UnityContainer container)
        {
            container = new UnityContainer();
            container.RegisterType(typeof(Icarrito), typeof(Carrito));
            container.RegisterType<ICalculadoraPrecios, CalculadoraPrecios>();
            return container;
        }
    }
}
