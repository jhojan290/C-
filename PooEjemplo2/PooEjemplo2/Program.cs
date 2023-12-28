namespace PooEjemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorEuroDolar obj = new ConversorEuroDolar();
            //obj.euro = 3489;
            obj.CambiarValorEuro(-72.6);
            Console.WriteLine(obj.Conversor(50));
            
        }

    }

    class ConversorEuroDolar
    {
        private double euro = 1.400;

        public double Conversor(double cantidad)
        {
            return cantidad * euro;
        }

        public void CambiarValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.400;

            else
            {
                euro = nuevoValor;
            }  
        }
    }

    

}











