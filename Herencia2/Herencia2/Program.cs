
namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Babieca");

            Humano Juan = new Humano("Juan");

            Gorila Copito = new Gorila("Copito");


            Mamiferos[] almacenamientoArray = new Mamiferos[3];

            almacenamientoArray[0] = Babieca;

            almacenamientoArray[1] = Juan;

            almacenamientoArray[2] = Copito;

            almacenamientoArray[1].getNombre();
        }

    }

    class Mamiferos
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se valgan por si solas");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }

        public void pensar()
        {
            Console.WriteLine("pensamiento básico instintivo");
        }

        private String nombreSerVivo;
    }

    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo) // La instrucción es para llamar al constructor de la clase padre y por medio de este le envía un parámetro a la clase padre
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");

        }
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        new public void pensar() // Se usa la palabra reservada new para quitar la advertencia generada en el método
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
    }

}
















