
namespace Structs_y_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1200, 250);

            empleado1.cambiaSalario(empleado1, 100);

            Console.WriteLine(empleado1);
        }
    }

    //public class Empleado
    public struct Empleado
    {
        public double salarioBase, comision;

        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;

            this.comision = comision;
        }

        public override string ToString() /*el método ToString te permite convertir un objeto en una cadena de texto. 
                                           * La idea es que cuando necesitas representar tu objeto como texto 
                                           * (por ejemplo, para imprimirlo en la consola o concatenarlo con otras cadenas), puedes personalizar cómo se verá esa representación.
                                            En lugar de obtener la representación predeterminada que simplemente muestra el tipo del objeto, puedes hacer que ToString devuelva una 
                                            cadena más útil y fácil de entender para ti y otros programadores que lean tu código.*/
        {
            return string.Format("Salario y comisión del empleado ({0},{1})", this.salarioBase, this.comision);
            /*La función string.Format se utiliza típicamente cuando se desea construir una cadena compuesta por varias partes, y se pueden incluir marcadores de posición en la cadena 
             * que se reemplazarán por valores específicos. */
        }

        public void cambiaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;

            emp.comision += incremento;
        }
    }
}




















