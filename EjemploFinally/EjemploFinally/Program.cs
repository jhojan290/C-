namespace EjemploFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null; // Declaración de un objeto StreamReader, inicializado como nulo.

            try
            {
                string linea;

                int contador = 0;

                string path = @"C:\Users\BB7211\Desktop\hola.txt";

                archivo = new System.IO.StreamReader(path); // Intenta abrir el archivo para lectura.

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }catch(Exception e)

            {
                Console.WriteLine("Error con la lectura del archivo");
            }

            finally // Con el bloque finally me aseguro de que una parte del código se ejecute siempre, sin importar alguna excepción
            {
                if (archivo != null) archivo.Close(); // cerrando la conexión que se hace con el fichero para evitar el consumo de recursos innecesarios

                Console.WriteLine("Conexión con el fichero cerrada");
            }
        }

    }
}










