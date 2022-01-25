using System.Diagnostics;

namespace DependencyInjectionNinject
{
    public class Carrote : Icarrito
    {
        private readonly ICalculadoraPrecios _calculadora;

        public Carrote(ICalculadoraPrecios calc) => _calculadora = calc;


        public double CalcularTotal(int x)
        {
            Trace.WriteLine("A punto de calcular total...");
            var total = _calculadora.CalcularPrecio(x);
            Trace.WriteLine("Ya se calculo el total");
            return total;
        }
    }
}
