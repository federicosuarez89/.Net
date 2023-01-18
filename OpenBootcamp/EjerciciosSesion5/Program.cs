namespace EjerciciosSesion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio 1 - IF
                Escribe un programa que:
                Pida datos a un cliente: Nombre, email, cupón
                Determine si un cliente tiene un cupon descuento
                Muestre un precio rebajado en función del descuento
                Muestre el precio de un producto sin descuento si no hay cupón
             */
            Console.WriteLine("Programa que calcula descuentos");
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su email:");
            string email = Console.ReadLine();
            Console.WriteLine("Ingrese su numero de cupon:");
            int cupon = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total de la compra");
            double totalCompra = double.Parse(Console.ReadLine());
            double compraDescuento1 = totalCompra * 0.95;
            double compraDescuento2 = totalCompra * 0.9;
            if (cupon <= 5)
            {
                Console.WriteLine($"El total de la compra con descuento de 10% fue: {compraDescuento1}");
            }
            else if (cupon > 5)
            {
                Console.WriteLine($"El total de la compra con descuento de 10% fue: {compraDescuento2}");
            }
            else
            {
                Console.WriteLine($"El total de la compra sin descuenta fue: {totalCompra}");
            }


            /*
                Ejercicio 2 - Switch
                Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++.     
                Presenta la lista en consola y pide que el usuario seleccione el lenguaje 
                mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.
             */
            Console.WriteLine("Elija un lenguaje de programacion para imprimir Hola Mundo");
            Console.WriteLine("1.C#\n2.Java\n3.C++\n4.Javascript\n5.Python");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Console.WriteLine('Hola Mundo')");
                    break;
                case 2:
                    Console.WriteLine("System.out.println('Hola Mundo')");
                    break;
                case 3:
                    Console.WriteLine("cout<<'Hola Mundo'>>");
                    break;
                case 4:
                    Console.WriteLine("Console.log('Hola Mundo')");
                    break;
                case 5:
                    Console.WriteLine("print('Hola Mundo')");
                    break;
                default: 
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
        }
    }
}