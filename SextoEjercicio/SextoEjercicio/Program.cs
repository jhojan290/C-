namespace SextoEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //string carnet = "";
            //Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            //Console.WriteLine("Digita tu edad:");
            //int edad = Int32.Parse(Console.ReadLine());

            //if(edad >= 18)               // Primera manera de resolver el ejercicio
            //{
            //    Console.WriteLine("¿Tienes carnet de conducir?");
            //    carnet = Console.ReadLine();
            //}

            //if(edad >= 18 && carnet == "si")
            //{
            //    Console.WriteLine("Eres apto para conducir un vehiculo");

            //}

            //else
            //{
            //    Console.WriteLine("No eres apto para conducir un vehiculo");
            //}

            //------------------------------------------------------------------------------------------------

            //Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            //Console.WriteLine("Digita tu edad:");
            //int edad = Int32.Parse(Console.ReadLine());  // Segunda forma de resolver el ejercicio

            //if (edad < 18)
            //{
            //    Console.WriteLine("No puedes conducir un vehiculo");
            //}

            //else
            //{
            //    Console.WriteLine("¿Tienes carnet?");
            //    string carnet = Console.ReadLine();
            //    int compara = String.Compare(carnet, "si", true);

            //    if(compara == 0)
            //    {
            //        Console.WriteLine("Puedes conducir vehiculos");
            //    }

            //    else
            //    {
            //        Console.WriteLine("No puedes conducir");
            //    }
            //}

            //----------------------------------------------------------------------------------------------

            //Console.WriteLine("Introduce el primer parcial");

            //float parcial1 = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Introduce el primer parcial");

            //float parcial2 = Int32.Parse(Console.ReadLine()); // otro ejercicio de prueba de condicionales

            //Console.WriteLine("Introduce el primer parcial");

            //float parcial3 = Int32.Parse(Console.ReadLine());

            //if(parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5)
            //{
            //    Console.WriteLine("la nota media es: " + (parcial1 + parcial2 + parcial3) / 3);
            //}

            //else
            //{
            //    Console.WriteLine("Tienes que repetir el semestre");
            //}

            //--------------------------------------------------------------------------------------------

            // Estrcutura Switch

            Console.WriteLine("Elige medio de transporte (carro, tren, avion");

            string medioTransporte = Console.ReadLine();

            switch (medioTransporte)
            {
                case "carro":
                    Console.WriteLine("velocidad media: 100 km/h");
                    break;

                case "tren":
                    Console.WriteLine("velocidad media: 250 km/h");
                     break;

                case "avion":
                    Console.WriteLine("velocidad media: 800 km/h");
                    break;

                default:
                    Console.WriteLine("transporte no completado");
                    break;
            }
        }

    }
}






