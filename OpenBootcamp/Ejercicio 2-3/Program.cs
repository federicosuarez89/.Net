namespace Ejercicio_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");
            //Coche
            int puertas, ruedas;
            string marca;
            bool ITV;
            //Mesa
            double peso, largo;
            string material, color;

            Console.WriteLine("Ejercicio 3");
            
            //Comprobamos si un numero es igual o mayor que 18
            int numero2 = int.Parse(Console.ReadLine());
            if (numero2 >=18) {
                Console.WriteLine("El numero es mayor o igual que 18");
            }
            else
            {
                Console.WriteLine("El numero es menor de 18");
            }

            //Comprobamos si un char es igual a 'a' 
            Console.WriteLine("Ingrese un caracter");
            char caracter = char.Parse(Console.ReadLine());
            if(caracter== 'a')
            {
                Console.WriteLine("Es igual");
            }
            else
            {
                Console.WriteLine("Es distinto");
            }

            //Comprobamos 2 condiciones a la vez
            Console.WriteLine("Ingrese el primer valor");
            int condicion1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor");
            int condicion2 = int.Parse(Console.ReadLine());
            if(condicion1>=18 && condicion2>=18)
            {
                Console.WriteLine("Ambas personas son mayores de edad");
            }else if(condicion1>=18 && condicion2 <= 18)
            {
                Console.WriteLine("La primera persona es mayor de edad y la segunda es menor");
            }else if(condicion1<=18 && condicion2 >= 18)
            {
                Console.WriteLine("La segunda persona es mayor de edad y la primera es menor");
            }
            else
            {
                Console.WriteLine("Ambas personas son menores de edad");
            }




}
    }
}