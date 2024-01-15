
namespace PropiedadesAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado("Juan");

            Juan.SALARIO = 1200;

            Juan.SALARIO += 500;

            Console.WriteLine("El salario del empleado es: " + Juan.SALARIO);

            //Juan.setSalario(1200);

            //double nuevoSalario = Juan.getSalario() + 700;

            //Console.WriteLine("El salario del empleado es: " + Juan.getSalario());
        }
    }

    class Empleado
    {
        public Empleado(string nombre)
        {
            this._nombre = nombre;
        }
        /*public void setSalario(double salario)
        {
            if(salario < 0)
            {
                Console.WriteLine("El salaro no puede ser negativo. Se asignará 0 como salario");

                this.salario = 0;
            }
            else
            {
                this.salario = salario;
            }
        }

        public double getSalario()
        {
            return salario;
        }*/

            private double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;

            else return salario;
        }

        //CREACIÓN DE PROPIEDAD

        /*public double SALARIO
        {
            get { return this.salario; }

            set { this.salario = evaluaSalario(value); } // cuando el método almacenado en el set recibe un parámetro este se pondrá como value 
        }*/

        public double SALARIO // Nombre de propiedad
        {
            //get => this._salario;

            get => this._salario; // Propiedad de solo lectura incluye solo el get

            set => this._salario = evaluaSalario(value); // Propiedad de solo escritura incluye solo el set
        }

        private double _salario; // Nombre de campo, se usa guión bajo para diferenciar

        public string _nombre;
    }
}




















