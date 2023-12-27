namespace NovenaEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 2; i++)
            //{

            //    for (int j = 0; j <= 2; j++)   ciclos for anidados
            //    {                                 

            //        for (int k = 0; k <= 2; k++)
            //        {
            //            Console.WriteLine($"({i},{j},{k})");
            //        }
            //    }
            //}

            //----------------------------------------------------------------------------------------------

            //int i = 0;
            //while (i < 10)
            //{
            //    if (i == 4)  Ejemplo de ciclo while
            //    {
            //        i++;
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}

            //checked /* Con esta sentencia lo que se busca es chequear la expresión que está dentro de las llaves, en este caso el ejercicio
            //         tiene como objetivo mostrar el valor máximo que puede almacenar un entero, como este es el número máximo por lógica
            //         no podría sumársele un nuevo valor, ya que esto generaría un desbordamiento de la información. El programa de manera
            //         predeterminada no se cierra, solo da un valor erróneo y sigue con la ejecución del programa, para que esto no pase se utiliza el checked,
            //         en caso tal de haber desbordamiento de información, el programa se cerrará.*/
            //{
            //    int numero = int.MaxValue;

            //    int resultado = numero + 20;

            //    Console.WriteLine(resultado);
            //}

            //int numero = int.MaxValue;

            //int resultado = checked(numero + 20); // también se puede utilizar el checked antes de realizar la operación aritmética

            //Console.WriteLine(resultado);

            int numero = int.MaxValue;

            int resultado = unchecked(numero + 20); // unchecked es lo contrario al checked, con el evito que se realize un chequeo a una operación, dejando que el programa no se cierre y continue con la ejecución

            Console.WriteLine(resultado);


            //IMPORTANTE: unchecked y checked solo funcionan con tipos de datos long y int


        }

    }
}








