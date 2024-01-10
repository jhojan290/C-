
namespace EjercicioPractico
{
    class Coche: Vehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerando");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando");
        }

        public override void Conducir()
        {
            Console.WriteLine("Tomando las curvas con desición y destreza");
        }
    }
}
