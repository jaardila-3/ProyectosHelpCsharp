using System;

namespace Parámetros_y_Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            #region parámetros y sus palabras reservadas
            //params
            var username = "jorge.ardilar";
            var pass = "abc123";
            var age = 33;
            var recordarme = true;
            Login(username, pass, age, recordarme);
            Console.WriteLine("-----");
            //parámetro modo normal
            string original = "ditah"; //debe inicializarse siempre
            Palabras_reservada(original);
            Console.WriteLine("normal original {0}", original);
            Console.WriteLine("-----");
            //in es solo contenedor no deja modificar en el método invocado
            string in_original = "jorge";
            Palabras_reservada_in(in_original);
            Console.WriteLine("-----");
            //ref hace referencia al espacio en memoria, por lo cual si modifica en el método invocado también modifica la original
            string ref_original = "alex"; //debe inicializarse siempre
            Palabras_reservada_ref(ref ref_original);
            Console.WriteLine("ref original era \"alex\" y ahora es: {0}", ref_original);
            Console.WriteLine("-----");
            //out igual a ref pero no es necesario inicializar la variable original
            string out_original;
            Palabras_reservada_out(out out_original);
            Console.WriteLine("out original no estaba instanciada y ahora es: {0}", out_original);
            Console.WriteLine("-----");
            #endregion

            #region Funciones dentro de métodos
            Console.WriteLine("Funciones");
            Metodo_con_funciones(40);
            #endregion
            Console.ReadLine();
        }

        #region parámetros y sus palabras reservadas
        public static void Login(params object[] parametros)
        {

            Console.WriteLine("usuario: {0}, pass: {1} age: {2} bool: {3}", parametros[0], parametros[1], parametros[2], parametros[3]);

        }

        public static void Palabras_reservada(string valor)
        {
            valor = "telem";
            Console.WriteLine("normal en método {0}", valor);
        }

        public static void Palabras_reservada_in(in string contenedor)
        {
            //valor = "jaiver"; //error
            Console.WriteLine("in {0}", contenedor);
        }

        public static void Palabras_reservada_ref(ref string referencia)
        {
            referencia = "ardila";
            Console.WriteLine("ref en método {0}", referencia);
        }

        public static void Palabras_reservada_out(out string referencia)
        {
            referencia = "restrepo";
            Console.WriteLine("out en método {0}", referencia);
        }
        #endregion

        #region Funciones dentro de métodos
        public static void Metodo_con_funciones(int articulos)
        {
            if(articulos < 10)
            {
                double valor = 3000 * articulos;
                funcion_aviso(funcion_10_porciento(valor));
            }
            if (articulos >= 10 && articulos <= 20)
            {
                double valor = 2000 * articulos;
                funcion_aviso(funcion_10_porciento(valor));
            }
            if (articulos > 20)
            {
                double valor = 1000 * articulos;
                funcion_aviso(funcion_10_porciento(valor));
            }
            //funciones
            void funcion_aviso(double descuento) => Console.WriteLine("El descuento para esta venta es de: {0}", descuento);
            double funcion_10_porciento(double valor) => _ = valor * 0.1;            
        }
        #endregion

    }
}
