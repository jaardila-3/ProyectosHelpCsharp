using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionNinject
{
    public interface ICalculadoraPrecios
    {
        double CalcularPrecio(int x);
    }

    public class CalculadoraPrecios : ICalculadoraPrecios
    {
        public double CalcularPrecio(int x)
        {
            return x * x;
        }
    }
}
