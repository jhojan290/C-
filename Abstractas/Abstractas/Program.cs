
namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Caballo Babieca = new Caballo("Babieca");

            //IMamiferosTerrestres ImiBabieca = Babieca;

            //ISaltoConPatas Babi = Babieca;

            //Humano Juan = new Humano("Juan");

            //Gorila Copito = new Gorila("Copito");


            //Mamiferos[] almacenamientoArray = new Mamiferos[3];

            //almacenamientoArray[0] = Babieca;

            //almacenamientoArray[1] = Juan;

            //almacenamientoArray[2] = Copito;

            //for (int i = 0; i < 3; i++)
            //{
            //    almacenamientoArray[i].pensar();
            //}

            //Ballena miWally = new Ballena("Wally");

            //miWally.nadar();

            //Console.WriteLine("El número de patas de Babieca es: " + ImiBabieca.numeroPatas());

            //Console.WriteLine("Cantidad de patas que usa babieca para saltar: " + Babi.numeroPatas());

            Lagartija Juancho = new Lagartija("Juancho");

            //Juancho.respirar();

            Juancho.getNombre();

            Humano Juan = new Humano("Juan");

            //Juan.respirar();

            Juan.getNombre();
        }
    }



    interface IMamiferosTerrestres
    {
        int numeroPatas();
    }

    interface IAnimalesYDeportes
    {
        string tipoDeporte();
        Boolean esOlimpico();
    }

    interface ISaltoConPatas
    {
        int numeroPatas();
    }

    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre();


    }

    class Lagartija : Animales
    {

        public Lagartija(String nombre)
        {
            nombreReptil = nombre;
        }
        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil es: " + nombreReptil);
        }

        private string nombreReptil;
    }

    class Mamiferos:Animales
    {
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se valgan por si solas");
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del mamifero es: " + nombreSerVivo);
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

    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
            //respirar();
        }

        int IMamiferosTerrestres.numeroPatas() // Cuando existe algún tipo de ambigüedad se pone despues del tipo de dato, la interface a la cual se encuentra asociada el método
                                               // para así evitar conflictos entre métodos que se llamen igual 
        {
            return 4;
        }

        int ISaltoConPatas.numeroPatas()
        {
            return 2;
        }

        public string tipoDeporte()
        {
            return "Hípica";
        }

        public Boolean esOlimpico()
        {
            return true;
        }
    }

    class Humano : Mamiferos // No se admite la herencia múltiple en c#
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


    }

}



















