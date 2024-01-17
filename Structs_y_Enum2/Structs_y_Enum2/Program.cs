
namespace Structs_y_Enum2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Estaciones alergia = Estaciones.Primavera;*/

            //Estaciones? alergia = null; // Se coloca un signo de interrogación al lado del Enum para poder almacenar dentro de este un valor null

            //String La_alergia = alergia.ToString(); // Se sobreescribe una de las constantes dentro del enum con el método ToString() para poder almacenarlo dentro de una variable de tipo string

            //Console.WriteLine(La_alergia);

            Bonus Jhojan = Bonus.bueno;

            Console.WriteLine(Jhojan);
        }
    } 

    //enum Estaciones{ Primavera, Verano, Otoño, Invierno};

    enum Bonus { bajo=500, normal=1000, bueno=1500, extra=3000};
}





















