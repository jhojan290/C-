using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces3
{
    class AvisosTrafico : IAvisos
    {

        public AvisosTrafico()
        {
            remitente = "DGT";

            mensaje = "Sanción cometida. Pague antes de 3 días y se beneficiará de una reducción en la sanción del 50%";

            fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el dia {2}",mensaje, remitente,fecha); // Manera de mostrar
            // un mensaje en consola, indicando la posición en la que se encuentra el argumento
        }

        private string remitente;

        private string mensaje;

        private string fecha;
    }
}
