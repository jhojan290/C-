
namespace Herencia2
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

            //almacenamientoArray[1].getNombre();

            Mamiferos miMamifero = new Mamiferos("");

            /*miMamifero.pensar();*/ /* Como el método pensar de la clase esta declarado como protected, el método main de la clase Program no podrá acceder a este
                                  ya que el protected solo permite dar acceso a la clase que contiene el método y a las clases que hereden de esta*/
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

        // Si el método es protected solo podrá ser accedido dentro de la misma clase o por clases que hereden
        //protected virtual void pensar() 
        //{
        //    Console.WriteLine("pensamiento básico instintivo");
        //}

        public virtual void pensar() // Si existe otro método con el mismo nombre en otra clase y esa clase esta heredando, automáticamente esa clase ocultará al método de la clase base 
        {
            Console.WriteLine("pensamiento básico instintivo");
        }

        // Con la palabra virtual estamos indicando que todas las subclases de mamíferos deben tener un método que modifique el método pensar de la clase mamíferos. Bien sea agregandole algo, modificando su comportamiento o quitando algo.

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
            respirar();
        }
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        //new public void pensar() /* Cuando usas public new void Metodo() en la clase derivada (ClaseDerivada en tu ejemplo),
        //estás diciendo al compilador que estás proporcionando una nueva implementación para el método Metodo. La palabra clave
        //new aquí no significa que el método de la clase base se elimine o deje de existir; más bien, está indicando que estás
        //creando una nueva versión del método en la clase derivada.*/

        //{
        //    Console.WriteLine("Soy capaz de pensar");
        //}

        public override void pensar() 
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

        public override void pensar() // Si este método recibiera algún parámetro ya no sería igual al que está heredando
        /* La palabra reservada override sirve para indicar que el método va a sobreescribir el método que está heredando, para que esto suceda el método de la clase
           que se está heredando debe tener la palabra reservada virtual para asi indicar que podrá ser modificado por las subclases que contengan métodos con la palabra override*/
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
    }

}
















