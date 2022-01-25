using Ninject.Modules;

namespace DependencyInjectionNinject
{
    public class NinjectConfig : NinjectModule
    {
        public override void Load()
        {
            Bind<Icarrito>().To<Carrito>();
            Bind<Icarrito>().To<Carrote>();
            Bind<ICalculadoraPrecios>().To<CalculadoraPrecios>();
        }
    }
}
