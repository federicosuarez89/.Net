namespace EjerciciosSesion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio 1 - While.Escribe una tabla de multiplicar del 1 al 10 
                para un número entero que recibe por consola.
            */
            Console.WriteLine("Ingrese un numero para calcular la tabla de multiplicar");
            int numUsuario = int.Parse(Console.ReadLine());
            int contador = 0;
            
            while(contador < 1)
            {
                Console.WriteLine($"Tabla del {numUsuario}");
                tablaMultiplicar(numUsuario);
                contador++;
            }

            /*
                Ejercicio 2 - Do while

                Escribe un programa que realice estos pasos:

                Reciba al menos un número por consola

                Determine si el número es positivo o negativo

                Presente un contador para cada tipo (positivo y negativo).
             */
            Console.WriteLine("¿Cuantos numeros se van a evaluar");
            int cantNumeros = int.Parse(Console.ReadLine());
            int numeroIngresado;
            int contador2 = 0;
            int contadorNegativos = 0;
            int contadorPositivos = 0;
            int contadorCeros = 0;
            int otroContador = 1;
            int ottroContador2 = 0;
            do
            {
                Console.WriteLine($"{ otroContador}.Ingrese un numero");
                numeroIngresado = int.Parse(Console.ReadLine());
                if (numeroIngresado < 0)
                {
                    contadorNegativos++;
                }
                else if (numeroIngresado > 0)
                {
                    contadorPositivos++;
                }
                else if (numeroIngresado == 0)
                {
                    contadorCeros++;
                }
                otroContador++;
                ottroContador2++;
            } while (ottroContador2<cantNumeros);
            Console.WriteLine($"Cantidad de numeros negativos: {contadorNegativos}");
            Console.WriteLine($"Cantidad de numeros positivos: {contadorPositivos}");
            Console.WriteLine($"Cantidad de numeros cero: {contadorCeros}");   
        }

        //Metodo para las tablas de multiplicar
        static int tablaMultiplicar(int multiplicador)
        {
            int resultado = 0;
            for (int i = 0; i < 11; i++)
            {
                resultado = multiplicador * i;
                Console.WriteLine(multiplicador+"*"+i+"="+resultado);
            }
            return resultado;
        }
    }
}