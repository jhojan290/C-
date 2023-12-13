
using System.Timers;

namespace SegundoEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //int edad;
            //int edad1; //Declaración explicita de variables
            //int edad2;
            //int edad3;

            /*edad = edad1 = edad2 = edad3 = 26;*/ // manera de asignarle el mismo valor a varias variables a la vez

            // Console.WriteLine(edad);

            /*var edad = 20;*/ // Declaración implicita de variables.

            // el compilador deduce según el valor de la variable, el tipo de dato con el que se inicializó
            // todo esto usando la palabra var

            // A estas variables implicitas no se les puede cambiar su tipo de dato en el código después de ser declaradas

            //Console.WriteLine(edad);

            //--------------------------------------------------------------------------------------------------------------------------------//

            /*Conversión explícita o Casting*/

            //double temperatura = 34.5;

            //int temperaturaM;

            //temperaturaM = (int)temperatura; // almacena en una variable de tipo entero, el valor de la variable tipo double, pero indicando al lado de esta
            ////el tipo de dato al que quiere ser pasado

            //Console.WriteLine(temperaturaM);


            //-------------------------------------------------------------------------------------------------------------------------------//

            /*Conversión Implicita*/

            int habitantes = 1000000;

            long habitanteNuevaCiudad = habitantes; // hace la conversión sin necesidad de casting gracias a que los tipos de valores son compatibles
            // esto según la tabla de conversiones de valores implícitos

            Console.WriteLine(habitanteNuevaCiudad);


        }
    }
}


