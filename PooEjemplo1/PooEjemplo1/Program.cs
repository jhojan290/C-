namespace PooEjemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; // creación de objeto de tipo Círculo. Variable/objeto de tipo círculo

            miCirculo = new Circulo(); // Iniciación de variable/objeto de tipo Círculo. Instanciar una clase
                                       // Instanciación. Ejemplarización. Creación de ejemplar de clase

            Console.WriteLine(miCirculo.calculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.calculoArea(9));
        }

    }

    class Circulo
    {
        const double pi = 3.1416; // propiedad de la clase circulo. Campo de clase

        public double calculoArea(int radio) // método de clase. ¿Qué pueden hacer los objetos de tipo círculo?
        {
            return pi * radio * radio;
        }
    }
}










