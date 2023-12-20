namespace SeptimoEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("¿Deseas entrar en el bucle while?");

            //string respuesta = Console.ReadLine();

            //while (respuesta != "no")
            //{
            //    Console.WriteLine("Estas ejecutando el interior del bucle while");

            //    Console.WriteLine("Introduce tu nombre por favor");

            //    string nombre = Console.ReadLine();

            //    Console.WriteLine($"Saldrás del bucle {nombre} cuando respondas 'no' a la pregunta");

            //    Console.WriteLine("¿Deseas repetir otra vez?");

            //    respuesta = Console.ReadLine();
            //}

            //Console.WriteLine("has salido del bucle");


            //--------------------------------------------------------------------------------------------------------//

            //Ejercicio de práctica hecho por mi

            //Random numero = new Random();

            //int numeroAleatorio = numero.Next(1, 100);

            //int cont = 0;s

            //while (true)
            //{
            //    Console.WriteLine("Digite un número entre 1 y 100");

            //    int num = Int32.Parse(Console.ReadLine());

            //    if(num > numeroAleatorio)
            //    {
            //        Console.WriteLine("el numero que digito es mayor al número aleatorio");
            //    }

            //    else if(num < numeroAleatorio)
            //    {
            //        Console.WriteLine("el numero que digito es menor al número aleatorio");
            //    }

            //    else
            //    {
            //        Console.WriteLine("el número es igual al generado");

            //        Console.WriteLine($"El número generado era {numeroAleatorio}");

            //        cont++;

            //        Console.WriteLine($"Intento encontrar el número un total de {cont} veces");

            //        break;

            //    }

            //    Console.WriteLine("Intente de nuevo");

            //}

            //------------------------------------------------------------------------------------------//

            // Ejercicio hecho en el curso

            //Random numero = new Random();

            //int aleatorio = numero.Next(1,100);

            //int minumero = 101;

            //int intentos = 0;

            //Console.WriteLine("Introduce un número entre 0 y 100");

            //while(aleatorio != minumero)
            //{
            //    intentos++;

            //    minumero = int.Parse(Console.ReadLine());

            //    if (minumero > aleatorio) Console.WriteLine("El n° es más bajo");

            //    if (minumero < aleatorio) Console.WriteLine("El n° es más alto");
            //}

            //Console.WriteLine($"Correcto has necesitado {intentos} intentos");

            //------------------------------------------------------------------------------------------//

            // Bucle do while


            Random numero = new Random();

            int aleatorio = numero.Next(1, 100);

            int minumero = 101;

            int intentos = 0;

            Console.WriteLine("Introduce un número entre 0 y 100");

            
            do {
                intentos++;

                minumero = int.Parse(Console.ReadLine());

                if (minumero > aleatorio) Console.WriteLine("El n° es más bajo");

                if (minumero < aleatorio) Console.WriteLine("El n° es más alto");

            } while (aleatorio != minumero)

                Console.WriteLine($"Correcto has necesitado {intentos} intentos");

        }

        //El bucle do-while en C# es una estructura de control de flujo que ejecuta un bloque de código
        //repetidamente mientras una condición especificada sea verdadera. A diferencia del bucle while, el bucle do-while
        //garantiza que el bloque de código se ejecute al menos una vez antes de verificar la condición. Aquí tienes la estructura
        //básica del bucle do-while en C#:



    }
}







