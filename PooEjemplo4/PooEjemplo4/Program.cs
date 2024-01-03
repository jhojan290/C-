using static System.Math; // para importar todos los métodos estaticos de la clase Math 
using static System.Console; // para importar todos los métodos estaticos de la clase Console


namespace PooEjemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();

            //double raiz = Sqrt(9);

            //double potencia = Pow(3, 4);

            //WriteLine(raiz);

            //WriteLine(potencia);

            //-----------------------------------------------------------------------------------

            var MiVariable = new { Nombre = "Juan", edad = 19 }; // Clases anonimas donde no se especifica un nombre de clase, el tipo de dato lo define el compilador, le da un tipo tanto a las caracteristicas
            // del objeto como a la variable donde se inicializa el objeto

            WriteLine(MiVariable.Nombre + " " + MiVariable.edad);

            var miOtraVariable = new { Nombre = "Ana", edad = 25 };

            MiVariable = miOtraVariable; // Puede asignarse una clase a la otra ya que son las mismas en cuanto a la cantidad de parametros y tipo de datos,
            // si existieran mas parametros o los tipos de datos sean diferentes pasarian a ser clases distintas.

            // CLASES ANÓNIMAS REQUISITOS

            // - Solo pueden contener campos públicos
            // - Todos los campos deben estar iniciados
            // - Los campos no pueden ser static
            // - No se pueden definir métodos
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();

            Punto destino = new Punto(128,80);

            Punto otropunto = new Punto();

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los dos puntos es de: {distancia}");

            Console.WriteLine($"Número de objetos creados: {Punto.ContadorDeObjetos()}");

            
        }

        // static se usa cuando quieres algo que sea compartido por todas las "cajas" (instancias)
        // de una clase, en lugar de ser algo específico de cada caja.

        //----------------------------------------------------------------------------------------------

        //Variables estáticas:

        //Una variable estática pertenece a la clase en lugar de a una instancia específica de la clase.
        //Todas las instancias de la clase comparten la misma variable estática.
        //Se inicializa una sola vez, cuando se carga la clase.
        //Se accede a través del nombre de la clase, no a través de una instancia.

        //----------------------------------------------------------------------------------------------

        //Métodos estáticos:

        //Un método estático pertenece a la clase y no a una instancia específica.
        //Se invoca a través del nombre de la clase, no a través de una instancia.
        //No puede acceder a miembros no estáticos de la clase, ya que no tiene acceso a una instancia específica.

        //----------------------------------------------------------------------------------------------

        //Propiedades estáticas:

        //Similar a las variables estáticas, una propiedad estática pertenece a la clase en lugar de a una instancia específica.
        //Se accede a través del nombre de la clase, no a través de una instancia.
        //Puede tener un cuerpo de acceso que define la lógica para obtener o establecer el valor.

        //-----------------------------------------------------------------------------------------------

        //Constructores estáticos:

        //Un constructor estático se ejecuta una sola vez cuando se carga la clase.
        //Se utiliza para realizar inicializaciones estáticas o configuraciones antes de crear instancias de la clase.

        //-----------------------------------------------------------------------------------------------

        //El uso de static es útil cuando quieres compartir datos o funcionalidades entre todas las instancias de una clase 
        //y no deseas asociarlos con instancias específicas

        //-----------------------------------------------------------------------------------------------

        

    }
}












