
namespace PooEjemplo3
{
    class Program
    {
        static void Main(string[] args)
        {

            Coche coche1 = new Coche();
            Coche coche2 = new Coche();

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());

            Coche coche3 = new Coche(456.9, 3456.2);

            Console.WriteLine(coche3.getInfoCoche());
            coche3.setExtras(true, "cuero");
            Console.WriteLine(coche3.getExtras());

        }

    }
    partial class Coche

    {
        public Coche()
        {
            ruedas = 4;
            largo = 20.3;
            ancho = 19.5;
            tapiceria = "cuero";
        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "cuero";
        }
    }

    // ----------------------------------------------------------------------------------
    // el partial sirve para generar una partición en las clases
    partial class Coche { 

        public String getInfoCoche()
        {
            return "El coche tiene " + ruedas + " ruedas, un largo de " + largo + " y un ancho de " + ancho;
        }

        public void setExtras(bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador; // el this es utilizado para hacer referencia a un campo de clase o variable que está en la clase
            this.tapiceria = tapiceria;
        }

        public String getExtras()
        {
            return $"Los extras del coche son: \n tapiceria: {tapiceria} y climatizador: {climatizador}";
        }

        private int ruedas; 

        private double largo;

        private double ancho;

        private bool climatizador;

        private String tapiceria;
    }

}












