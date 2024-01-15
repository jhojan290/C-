
namespace Abstractas
{
    class Program
    {
        static void Main(string[] args)
        {
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

        public sealed override void pensar() // Con esta sentencia sealed se hace que el método no se pueda sobreescribir en otra clase
        {
            Console.WriteLine("Soy capaz de pensar");
        }

    }

    sealed class Gorila : Mamiferos, IMamiferosTerrestres // Usando sealed se impide que de esta clase se pueda heredar
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

    class Adolescente : Humano
    {
        Adolescente(string nombreAdolescente) : base(nombreAdolescente)
        {
            
        }

        public override void pensar()
        {
            Console.WriteLine("Las xd");
        }
    }

    //class Chimpance : Gorila // sale un error porque la clase de la que se hereda es sealed
    //{
    //    public Chimpance(string nombreChimpance): base(nombreChimpance)
    //    {   

    //    }
    //}

}



















