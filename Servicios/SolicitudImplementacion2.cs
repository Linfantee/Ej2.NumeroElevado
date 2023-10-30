using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.NumeroElevado.Servicios
{
    internal class SolicitudImplementacion2 : SolicitudInterfaz2
    {
        public void operacion(double y, int x)
        {

            double operacion = 0;

            for (int i = 0; i <= x; i++)
            {

                operacion = y * i;

            }
            Console.WriteLine("El resultado de " + y + " elevado a " + x + " es " + operacion );
        }


    }
}
