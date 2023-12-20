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

            Random numero = new Random();

            int numeroAleatorio = numero.Next(1, 100);

            Console.WriteLine(numeroAleatorio);

            int cont = 0;

            while (true)
            {
                Console.WriteLine("Digite un número entre 1 y 100");

                int num = Int32.Parse(Console.ReadLine());

                if(num > numeroAleatorio)
                {
                    Console.WriteLine("el numero que digito es mayor al número aleatorio");
                }

                else if(num < numeroAleatorio)
                {
                    Console.WriteLine("el numero que digito es menor al número aleatorio");
                }

                else
                {
                    Console.WriteLine("el número es igual al generado");

                    Console.WriteLine($"El número generado era {numeroAleatorio}");

                    cont++;

                    Console.WriteLine($"Intento encontrar el número un total de {cont} veces");

                    break;
                    
                }

                Console.WriteLine("Intente de nuevo");

            }
        }

    }
}







