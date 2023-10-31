using Ejercicio5Bucles.Servicios;

namespace Ejercicio5Bucles 
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 30102023 -> irm
    /// </summary>
    class Program 
    { 
        /// <summary>
        /// Metodo principal de la aplicacion
        /// 30102023 -> irm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {
            //Atributos
            string respuestaIntroducida="";
            string respuestaCalculo = "";
            int anyo, mes;
            //Creamos los objetos
            PedirInformacionInterfaz pI = new PedirInformacionImplementacion();
            CalcularAñoBisiestoInterfaz cAB=new CalcularAñoBisiestoImplementacion();
            //Creamos el bucle do..while
            do 
            {
                //Guardamos los valores pedidos
                mes = pI.mes();
                anyo = pI.anyo();
                //Calculamos si el año es bisiesto o no
                respuestaCalculo=cAB.calcularAnyoBisiesto(anyo);

                switch (mes) 
                {
                    case 1: case 3: case 5: case 7:case 8: case 10:case 12:
                        Console.WriteLine("Este mes tiene 31 dias");
                        break;
                    case 2:
                        if (respuestaCalculo == "s")
                        {
                            Console.WriteLine("Este mes tiene 29 dias");
                        }
                        else 
                        { 
                            Console.WriteLine("Este mes tiene 28 dias");
                        }
                        break;
                    case 4: case 6: case 9: case 11:
                        Console.WriteLine("Este mes tiene 30 dias");
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no existe");
                        break;
                }
                //Le pedimos al usuario si quiere volver a utilizar la aplicacion
                respuestaIntroducida = pI.pedirConfirmacion();
            } while (respuestaIntroducida == "s");
        }
    }
}
