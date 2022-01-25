using System.Diagnostics;

namespace DependencyInjectionNinject
{
    public interface Icarrito
    {
        double CalcularTotal(int x);
    }

    public class Carrito : Icarrito
    {
        private readonly ICalculadoraPrecios _calculadora;

        public Carrito(ICalculadoraPrecios calc) => _calculadora = calc;


        public double CalcularTotal(int x)
        {
            Trace.WriteLine("A punto de calcular total...");
            var total = _calculadora.CalcularPrecio(x);
            Trace.WriteLine("Ya se calculo el total");
            return total;
        }
    }
}
