namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] datos = new int[4];
            //datos[0] = 1;
            //datos[1] = 2;
            //datos[2] = 3;
            //datos[3] = 4;
            //ArrayP(datos);

            //foreach(int i in datos)
            //{
            //    Console.WriteLine(i);
            //}

            int[] arrayElementos = LeerDatos();

            foreach(int i in arrayElementos)
            {
                Console.WriteLine(i);
            }


        }

        //static void ArrayP (int [] datos) // Uso de arrays por parámetros
        //{
        //    //foreach (int variable in datos)
        //    //{
        //    //    Console.WriteLine(variable);
        //    //}
        //    for (int i = 0; i < 4; i++)
        //    {
        //        datos[i] += 10;
        //    }
        //}

        static int[] LeerDatos()
        {
            Console.WriteLine("¿Cuantos elementos quieres que tenga el array?");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for (int i = 0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posición {i}");

                respuesta = Console.ReadLine();

                int datosElemento = int.Parse(respuesta);

                datos[i] = datosElemento;

            }

            return datos;
        }

    }

}














