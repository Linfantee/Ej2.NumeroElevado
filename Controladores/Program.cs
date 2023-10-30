using Ej2.NumeroElevado.Servicios;

namespace Ej2.NumeroElevado
{
    class Program
    {
        static void Main(string[] args) 
        { 
             
 
            double numero1;
            int numero2;
            double resultado;
            SolicitudInterfaz aka = new SolicitudImplementacion();
            SolicitudInterfaz2 ao = new SolicitudImplementacion2();

            numero1 = aka.pedirNumero(0);
            numero2 = Convert.ToInt32(aka.pedirNumero(1));
            ao.operacion(numero1, numero2);



        }

    }

}