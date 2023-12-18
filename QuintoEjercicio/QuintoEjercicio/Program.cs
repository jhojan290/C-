namespace QuintoEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;

            Console.WriteLine(Suma(valor1, valor2));
        }

        private static double Suma(int num1, double num2, int num3 = 0) // a los métodos se les pueden pasar parámetros opcionales y no afectará el código, se pueden utilizar en el momento que sea necesario
            //el parámetro opcional debe ir al final siempre
        {
            return num1 + num2 + num3;
        }
    }
}





