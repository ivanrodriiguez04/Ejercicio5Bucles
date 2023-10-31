using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Bucles.Servicios
{
    internal interface CalcularAñoBisiestoInterfaz
    {
        /// <summary>
        /// Metodo que calcula si el año introducido es bisiesto o no
        /// 31102023 -> irm
        /// </summary>
        /// <returns></returns>
        public string calcularAnyoBisiesto(int anyo);
    }
}
