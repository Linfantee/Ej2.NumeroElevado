using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.NumeroElevado.Servicios
{
    internal class SolicitudImplementacion : SolicitudInterfaz
    {

        public double pedirNumero(int k) 
        {
            double numero;
            
            if (k == 0) 
            {
                Console.WriteLine("Dame un número double");
            }
            else
            {
                Console.WriteLine("Dame un número int");
            }
           numero = Convert.ToDouble(Console.ReadLine());   
            return numero;
        }
    }
}
