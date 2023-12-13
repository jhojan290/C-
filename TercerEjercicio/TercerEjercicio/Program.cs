namespace TercerEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversión de texto a número

            //Console.WriteLine("Introduce el primer número");

            //int num = int.Parse(Console.ReadLine()); // el dato que se solicita en consola, al pasar al entorno de ejecución va como un string
            //// con el .Parse se puede convertir este dato en tipo texto a un tipo entero, con la línea anterior

            //Console.WriteLine("Introduce el segundo número");

            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("el resultado es: " + (num + num1));



            //----------------------------------------------------------------------------------------------------------------------------


            //const int VALOR = 5;
            //const int VALOR2 = 10; // Declaración de las variables constantes en mayúsculas por recomendación

            //Console.WriteLine("el valor del número es: {0}", VALOR, VALOR2); 
            // se le pueden pasar parámetros al Console.Writeline, dentro de las comillas se establece con llaves la posición del objeto a mostrar

            const double PI = 3.1416;

            Console.WriteLine("Introduzca la medida del radio");

            double radio = double.Parse(Console.ReadLine());

            double area = radio * radio * PI;

            Console.WriteLine($"El área del circulo es: {area}");
        }
    }
}



