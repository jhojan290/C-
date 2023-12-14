namespace CuartoEjercicio
{
    class Program
    {
        int num = 2; // variables de ámbito de clase, variables globales que funcionan en cualquiera de los métodos
        int num1 = 4;// Se pueden poner al inicio o al final, estas variables son llamadas campos de clase

        //static void Main(string[] args) // Una manera de trabajar con métodos void que no retornan nada
        //{
        //    Console.WriteLine("Ingrese el primer número: ");
        //    int num1 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Ingrese un segundo número: ");
        //    int num2 = int.Parse(Console.ReadLine());

        //    sumaNumeros(num1, num2);
        //}

        //static void sumaNumeros(int num1, int num2)
        //{
        //    int resultado = num1 + num2;
        //    Console.WriteLine($"la suma de los números {num1} y {num2} es: {resultado}");
        //}

        //---------------------------------------------------------------------------------------------------------------------

        //static void Main(string[] args) // segunda manera de trabajar con métodos void que no retornan ningún valor
        //{
        //    sumaNumeros(2, 3); // enviarle valores fijos al método
        //}

        //static void sumaNumeros(int num1, int num2)
        //{
        //    Console.WriteLine($"la suma de los números {num1} y {num2} es: " + (num1+num2));
        //    Console.WriteLine($"la suma de los números {num1} y {num2} es: {num1+num2}");
        //}

        //---------------------------------------------------------------------------------------------------------------------

        //Métodos que retornan un valor

        // static void Main(string[] args) 
        //{
        //    Console.WriteLine(sumaNumeros(2,3)); 
        //}
        //static int sumaNumeros(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        //static void Main(string[] args)
        //{
        //   /* Console.WriteLine(divideNumeros(2, 3));*/
        //}
        //static double divideNumeros(double num1, int num2) // cualquier operación entre un double y un int siempre dará double, por lo tanto el 
        //    // tipo de dato que se retorna debe coincidir con el tipo definido en el método para lograr enviarlo finalmente al main
        //{
        //    /*return num1 / num2;*/
        //}

        //---------------------------------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //Console.WriteLine(divideNumeros(2, 3));
        //}
        //static double divideNumeros(double num1, int num2) => num1 / num2; // Se puede usar una sola línea de código haciendo uso de una 
        //flecha, esto en caso tal de que el cuerpo del método solo tenga una sentencia



        //---------------------------------------------------------------------------------------------------------------------

        // Sobrecarga de métodos


        static void Main(string[] args) 
        {
            Console.WriteLine(Suma(7,5)); // Según los parámetros que se ingresen, se llamará a uno de los métodos
        }

        static int Suma(int operador1, int operador2) => operador1 + operador2;
        // para que se haga efectiva la sobrecarga de métodos (que los métodos tengan el mismo nombre) los métodos deben tener 
        // diferente cantidad de parámetros o tener la misma cantidad pero que los tipos de datos de las variables sean diferentes
        static double Suma(int numero1, double numero2) => numero1 + numero2;

        static int Suma(int numero1) => numero1;



    }
}




