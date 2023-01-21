namespace UsoAutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos un objeto de tipo Auto
            Auto auto1 = new Auto();

            //Instanciamos otro objeto de tipo Auto
            Auto auto2 = new Auto();
            //Imprimimos la informacion del auto a traves del getter
            Console.WriteLine("Datos del auto2");
            Console.WriteLine(auto2.getInfoAuto(true,"cuero"));

            //Instanciamos otro objeto de tipo Auto
            Auto auto3 = new Auto(4500.25,1200.35);
            //Imprimimos la informacion del auto a traves del getter
            Console.WriteLine("\nDatos del auto3");
            Console.WriteLine(auto2.getInfoAuto(false, "pana"));

        }
    }
    class Auto
    {
        private int ruedas;
        private double largo;
        private double ancho;
        private bool aireAcondicionado;
        private string tapizados;

        //Constructor de la clase
        public Auto()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
        }
        //Sobrecarga de constructores
        public Auto(double largo,double ancho) 
        {
            this.largo = largo;
            this.ancho = ancho;
        }

        //Getter y Setter
        public string getInfoAuto(bool aireAcondicionado, string tapizados)
        {
            this.aireAcondicionado = aireAcondicionado;
            this.tapizados = tapizados;
            string imprimirDatos = "Mi auto tiene " + this.ruedas + " ruedas\n" + this.largo + " cm de largo\n" + this.ancho + " cm de ancho\nAire acondicionado: "
                + this.aireAcondicionado + "\nTapizados de " + this.tapizados;
            return imprimirDatos;
        }
    }
}