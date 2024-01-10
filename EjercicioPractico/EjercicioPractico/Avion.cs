
namespace EjercicioPractico
{
    class Avion:Vehiculo
    {
        public void Aterrizar()
        {
            Console.WriteLine("Aterrizando");
        }

        public void Despegar()
        {
            Console.WriteLine("Despegando");
        }

        public override void Conducir()
        {

            //base.Conducir(); con esto se llama al método de la clase padre
            Console.WriteLine("Surcando los cielos del globo");
        }
    }
}
