
using EjercicioPractico;

namespace Vehiculo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probando el avión");

            Avion miAvion = new Avion();

            miAvion.ArrancaMotor("xd");

            miAvion.Despegar();

            miAvion.Conducir();

            miAvion.Aterrizar();

            miAvion.PararMotor("ploof");

            Console.WriteLine("--------------------------");

            Console.WriteLine("Probando el coche");

            Coche miCoche = new Coche();

            miCoche.ArrancaMotor("ggg");

            miCoche.Acelerar();

            miCoche.Conducir();

            miCoche.Frenar();

            miCoche.PararMotor("ssssss");

            Console.WriteLine("----------------------------");

            Console.WriteLine("Polimorfismo en acción");

            Vehiculo miVehiculo = miCoche;

            miVehiculo.Conducir();

            miVehiculo = miAvion;

            miVehiculo.Conducir();
        }
    }
}

















