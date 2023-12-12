
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

            var edad = 20; // Declaración implicita de variables.

                           // el compilador deduce según el valor de la variable, el tipo de dato con el que se inicializó
                           // todo esto usando la palabra var

            Console.WriteLine(edad);


        }
    }
}


