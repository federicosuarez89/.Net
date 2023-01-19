namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos un objeto de tipo Circulo
            Circulo miCirculo = new Circulo();
            Console.WriteLine("El valor del area es: " + miCirculo.area(5));

            Circulo miCirculo2 = new Circulo();
            Console.WriteLine("El valor del area es: " + miCirculo2.area(10));
            
        }
    }

    //Creamos una nueva clase
    class Circulo
    {
        //Atributos de clase
        double pi = 3.1416;

        //Metodos de clase
        public double area(int radio)
        {
            return pi * radio * radio;
        }

    }
}