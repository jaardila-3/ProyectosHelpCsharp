namespace DependencyInjectionUnity
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
