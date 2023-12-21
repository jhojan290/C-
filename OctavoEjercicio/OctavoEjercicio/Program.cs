namespace SeptimoEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Random numero = new Random();

            int aleatorio = numero.Next(1, 100);

            int minumero;

            int intentos = 0;

            Console.WriteLine("Introduce un número entre 0 y 100");


            do
            {
                intentos++;

                try
                {
                    minumero = int.Parse(Console.ReadLine());
                }

                //catch(FormatException ex)
                //{
                //    Console.WriteLine("No has introducido un valor númerico válido. Se toma como n° introducido el 0");
                //    minumero = 0; // La razón para asignar 0 a minumero dentro del catch es proporcionar un valor predeterminado
                //                  // cuando el usuario introduce algo que no es un número. Esto evita que el programa arroje otra
                //                  // excepción si intenta comparar o realizar operaciones con minumero más adelante en el código. 
                //}

                //catch(OverflowException ex)
                //{
                //    Console.WriteLine("No has introducido un valor númerico válido. Se toma como n° introducido el 0");
                //    minumero = 0;
                //}

                catch (Exception ex) // Con esta excepción se engloban todas las excepciones posibles, ya que esta
                // clase es como la clase padre de todas las excepciones, si se van a generar muchas excepciones solo con poner esta clase basta    
                {
                    Console.WriteLine("No has introducido un valor númerico válido. Se toma como n° introducido el 0");
                    //Console.WriteLine(ex.Message); para conocer que tipo de excepción se está generando, ex actúa como un objeto que tiene
                    // asociados varios métodos
                    minumero = 0;
                }


                if (minumero > aleatorio) Console.WriteLine("El n° es más bajo");

                if (minumero < aleatorio) Console.WriteLine("El n° es más alto"); 

            } while (aleatorio != minumero);

            Console.WriteLine($"Correcto has necesitado {intentos} intentos");


            // Jerarquia de Excepciones en el siguiente orden:

            // Exception
            // SystemException - las últimas dos se derivan de esta
            // FormatException - OverflowException

        }

    }
}








