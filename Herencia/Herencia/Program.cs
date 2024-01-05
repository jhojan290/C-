using System.Linq.Expressions;
using System.Security;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Babieca");

            Humano Juan = new Humano("Juan");

            Gorila Copito = new Gorila("Copito");

            /*Copito.trepar();

            Babieca.getNombre();

            Juan.getNombre();

            Copito.getNombre();*/

            Mamiferos Hum = new Humano("Pedro"); // Principio de sustitución 

            Mamiferos[] arrayObjetos = new Caballo[3];
            //Mamiferos[] arrayObjetos = new Mamiferos[3]; 

            arrayObjetos[0] = Babieca;

            arrayObjetos[1] = Juan;
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
            Console.WriteLine("Soy capax de respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se valgan por si solas");
        }

        public void getNombre()
        {
            Console.WriteLine ("El nombre del ser vivo es: " + nombreSerVivo);
        }

        private String nombreSerVivo;
    }

    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo):base(nombreCaballo) // La instrucción es para llamar al constructor de la clase padre y por medio de este le envía un parámetro a la clase padre
        {

        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano):base(nombreHumano)
        {

        }
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }

    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila):base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }

    // LA SUPER CLASE CÓSMICA
    // La clase object siempre esta por encima de cualquier clase, por eso al usar el punto aparecen algunos métodos de esta, de esta clase
    // pueden heredar todas las demás, todas las clases implicitamente heredan de la clase object, hay algunos métodos que no son accesibles por
    // parte de las clases hijas, debido a que su modificador de acceso es protected.


    // Hay que tener claro el concepto del (es-un) para generar la herencia entre clases y tengan un sentido.

    //-----------------------------------------------------------------

    // El principio de sustitución tiene en cuenta el (siempre-es-un) para construir la jerarquia de clases para así definir que clases
    // deben heredar de otras
}















