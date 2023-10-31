using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Bucles.Servicios
{
    internal interface PedirInformacionInterfaz
    {
        /// <summary>
        /// Metodo que pide al usuario el mes deseado
        /// 31102023 -> irm
        /// </summary>
        /// <returns></returns>
        public int mes();
        /// <summary>
        /// Metodo que pide al usuario el año deseado
        /// 31102023 -> irm
        /// </summary>
        /// <returns></returns>
        public int anyo();
        /// <summary>
        /// Metodo que pide al usuario si quiere volver a utilizar el programa
        /// 31102023 -> irm
        /// </summary>
        /// <returns></returns>
        public string pedirConfirmacion();

    }
}
