
namespace Interfaces1
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

            for (int i = 0; i < 3; i++)
            {
                almacenamientoArray[i].pensar();
            }

            //Mamiferos miMamifero = new Mamiferos("");

            Ballena miWally = new Ballena("Wally");

            miWally.nadar();

            Console.WriteLine("El número de patas de Babieca es: " + Babieca.numeroPatas());
        }
    }

interface IMamiferosTerrestres
    {
        int numeroPatas();
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


        public virtual void pensar()
        {
            Console.WriteLine("pensamiento básico instintivo");
        }

        private String nombreSerVivo;
    }

    class Ballena : Mamiferos
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }

    class Caballo : Mamiferos, IMamiferosTerrestres // Esta es la manera de crear una clase con herencia y su vez una herencia de interfaces
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo) 
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
            respirar();
        }

        public int numeroPatas()
        {
            return 4;
        }
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
  
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }

    }

    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }

        public int numeroPatas()
        {
            return 2;
        }

        /* Pasos a tener en cuenta a la hora de la creación de interfaces 
         
           1. El nombre del método debe coincidir con el que esta declarado en la interface
           
           2. El tipo de dato debe coincidir con el que esta escrito en el método de la interface
        
           3. Mismo # de parámetros y tipos
         
         */

        
    }

}

















