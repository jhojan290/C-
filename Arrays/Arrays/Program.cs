namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] edades;

            //edades = new int[4];

            //edades[0] = 15;

            //edades[1] = 27;

            //edades[2] = 19;

            //edades[3] = 80;

            //Console.WriteLine(edades[2]);

            //int[] edades = { 15, 27, 19, 80 };

            //int[] edades = new int [4] { 15, 27, 19, 80 };

            //Console.WriteLine(edades[2]);

            //-----------------------------------------------------------------------------

            // Array Implicito

            /*var datos = new[] { "Juan", "Díaz", 15 }; no son del mismo tipo de dato por lo tanto no acepta los datos en el array*/

            var valores = new[] { 15, 28, 35, 75.5, 30.30 }; /*Todo lo convierte a double*/

            //-----------------------------------------------------------------------------

            // Arrays de Objetos

            Empleados Ana = new Empleados("Ana", 23); // Primera manera de crear un array de objetos creando una instancia de la clase

            Empleados[] arrayEmpleados = new Empleados[2]; // Creación de array de la clase Empleados

            arrayEmpleados[0] = new Empleados("Pedro", 37); // Segunda manera de crear un array de objetos, creando y almacenando un objeto por posicion

            arrayEmpleados[1] = Ana; // Primera manera de crear un array de objetos, poniendo en la posicion 1 el objeto creado en la parte superior

            //-----------------------------------------------------------------------------

            // array de tipos o clases anónimas

            var personas = new[]
            {
                new{Nombre="Juan", Edad=19},

                new{Nombre="Maria", Edad= 49},

                new{Nombre="Diana", Edad = 35}

            };

            //Console.WriteLine(personas[1]);

            //for(int i = 0; i <= 4; i++)
            //{
            //    Console.WriteLine(valores[i]);
            //}

            //for (int i = 0; i <= valores.Length; i++) // metodos de la clase array, con .lenght recorro todo el array
            //{
            //    Console.WriteLine(valores[i]);
            //}

            for (int i = 0; i <= arrayEmpleados.Length; i++) // metodos de la clase array, con .lenght recorro todo el array
            {
                Console.WriteLine(arrayEmpleados[i]);
            }
        }

    }

    class Empleados
    {
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;

        }

        String nombre;
        int edad;
    }

}













