
namespace PrimerEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(5/2); si el resultado de la división es un resultado decimal, solo se mostrará la parte entera
            // para que se muestre el resultado decimal se hace de la siguiente manera:

            //Console.WriteLine(5.0/2.0);

            //Console.WriteLine(5 / 2.0); Si la división es entre un número entero y un número decimal, el resultado será decimal

            int edad = 20;

            edad += 3; // aumentar el valor de la variable en 3

            // edad++; Incrementa en uno la edad 

            // Console.WriteLine($"Tienes la edad de {edad} años");

            Console.WriteLine("Tiene la edad de " + ++edad + " años"); // para aumentar en uno desde el console.writeline y concatenar los resultados
            // se usa el simbolo ++ como sufijo para que aumente el valor de edad, ya que c# se lee de derecha a izquierda


        }
    }
}

