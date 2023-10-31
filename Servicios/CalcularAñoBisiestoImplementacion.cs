using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Bucles.Servicios
{
    internal class CalcularAñoBisiestoImplementacion : CalcularAñoBisiestoInterfaz
    {
        public string calcularAnyoBisiesto(int anyo)
        {
            string respuesta = "";
            //Comprobamos si el numero es bisiesto lo dividimos entre 4
            //si el resultado es 0 hacemos mas comprobaciones y si no es 0 no es bisiesto
            if (anyo % 4 == 0) 
            {
                //Si lo es, volvemos a comprobar para asegurarnos dividiende entre 100
                //si el resultado es 0 hacemos mas comprobaciones y si no es 0 es bisiesto
                if (anyo % 100 == 0)
                {
                    //Si lo es, volvemos a comprobar para asegurarnos dividiende entre 400 y ya lo sabremos con exactitud
                    //si el resultado es 0 es bisiesto y si no lo es no es bisiesto
                    if (anyo % 400 == 0) 
                    {
                        respuesta = "s";
                    }
                    else 
                    {
                        respuesta = "n";
                    }

                } 
                else 
                {
                    respuesta = "s";
                }
            } 
            else 
            {
                respuesta = "n";
            }
         
            return respuesta;
        }
    }
}
