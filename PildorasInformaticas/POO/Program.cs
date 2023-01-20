namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos un objeto de tipo Circulo
            Circulo miCirculo = new Circulo();
            Console.WriteLine("El valor del area es: " + miCirculo.CalculoArea(5));

            Circulo miCirculo2 = new Circulo();
            Console.WriteLine("El valor del area es: " + miCirculo2.CalculoArea(10));

            //Instanciamos un objeto de tipo ConversorPesoDolar
            ConversorPesoDolar objeto = new ConversorPesoDolar();
            Console.WriteLine(objeto.ConversorDivisa(100));

            //Cambiamos el valor del dolar
            objeto.cambiarDolar(-360);
            Console.WriteLine(objeto.ConversorDivisa(100));
        }
    }

    //Creamos una nueva clase
    class Circulo
    {
        //Atributos de clase
        private const double pi = 3.1416;

        //Metodos de clase
        public double CalculoArea(int radio)
        {
            return pi * radio * radio;
        }

    }

    //Creamos otra clase 
    class ConversorPesoDolar
    {
        private double dolar = 370;

        //Metodo para convertir Dolar a Peso
        public double ConversorDivisa(double cantidadDolares)
        {
            return cantidadDolares * dolar;
        }

        //Metodo para modificar el valor del dolar en Argentina
        public void cambiarDolar(double valorDolar)
        {
            if (valorDolar < 0)
            {
                dolar = dolar;
            }
            else
            {
                dolar = valorDolar;
            }
            
        }
    }
}