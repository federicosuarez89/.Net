﻿namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comentario de una sola linea
            Console.WriteLine("Hola desde c#");

            /*
                Comentario
                de varias 
                lineas
            */
            int edad = 28;
            Console.WriteLine(edad);

            //Interpolacion de string
            Console.WriteLine($"Tenes {edad} años");

            //Lectura de datos ingresados por teclado
            Console.WriteLine("Ingrese su edad: ");
            int edadFede = int.Parse(Console.ReadLine());
            Console.WriteLine("Tengo "+edadFede+" años");

            //Constantes
            const int EDADYURY = 28;
            Console.WriteLine($"La edad de Yury es: {EDADYURY} años");
        }
    }
}