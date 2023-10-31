using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Bucles.Servicios
{
    internal class PedirInformacionImplementacion : PedirInformacionInterfaz
    {
        public int anyo()
        {
            int anyo;
            Console.WriteLine("Introduzca el año deseado:");
            anyo = Convert.ToInt32(Console.ReadLine());
            return anyo;
        }

        public int mes()
        {
            int mes;
            Console.WriteLine("Introduzca el mes deseado:");
            mes = Convert.ToInt32(Console.ReadLine());
            return mes;
        }

        public string pedirConfirmacion()
        {
            string respuesta = "";
            Console.WriteLine("¿Quiere volver a utilizar la aplicacion[s=si || n=no]?");
            respuesta = Console.ReadLine();
            return respuesta;
        }
    }
}
