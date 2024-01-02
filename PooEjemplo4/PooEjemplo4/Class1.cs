

namespace PooEjemplo4
{
    class Punto
    {
        public Punto(int x, int y)
        {
            //Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");
            this.x = x;
            this.y = y;
            contadorDeObjetos++;
        }

        public Punto()
        {
            //Console.WriteLine("Este es el constructor por defecto");
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;
        }

        public double DistanciaHasta(Punto otroPunto) // a los métodos se les pueden enviar objetos
        {
            int xDif = this.x - otroPunto.x;

            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return distanciaPuntos;
        }

        public static int ContadorDeObjetos() => contadorDeObjetos;

        private int x, y;

        private static int contadorDeObjetos = 0;

        public const int Prueba = 0; // las constantes en c# se entienden como si ya tuvieran la palabra static, asi que puede ser accedida por la clase y no por una instancia
    }
}







