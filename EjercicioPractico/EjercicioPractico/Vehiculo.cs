

namespace EjercicioPractico
{
    class Vehiculo 
    {
        public void ArrancaMotor(string sonidoAlarrancar)
        {
            Console.WriteLine($"Arranca el motor: {sonidoAlarrancar}");
        }

        public void PararMotor(string sonidoAlparar)
        {
            Console.WriteLine($"Parando el motor: {sonidoAlparar}");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Este es el código genérico");
        }
    }
}
