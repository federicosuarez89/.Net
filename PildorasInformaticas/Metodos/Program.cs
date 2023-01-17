namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mensajeEnPantalla();
            Console.WriteLine("Mensaje desde el metodo Main");
            sumar(4, 8);
            Console.WriteLine("La resta de los dos numeros es: "+restar(20, 10));
            Console.WriteLine("Estamos usando sobrecarga de metodos,ahora la resta es: " + restar(1.5, 3.8));
            Console.WriteLine("Multiplicando sin usar el parametro opcional: " + multiplicar(2, 3));
            Console.WriteLine("Multiplicando usando el parametro opcional: " + multiplicar(2, 3, 4));
        }

        //Metodo para mostrar un mensaje por consola
        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el metodo mensajeEnPantalla");
        }

        //Metodo para sumar dos numeros
        static void sumar(int a,int b) {
            int resultado = a + b;
            Console.WriteLine($"La suma de los numeros es {resultado} ");
        }

        //Metodo para restar dos numeros
        static int restar(int a,int b)
        {
            int resultado = a - b;
            return resultado;
        }

        //Sobrecarga de metodos
        static double restar(double a,double b)
        {
            double resultado = a - b;
            return resultado;
        }

        //Parametros opcionales
        static int multiplicar(int a,int b,int c = 1)
        {
            int resultado = a * b * c;
            return resultado;
        }
    }
}