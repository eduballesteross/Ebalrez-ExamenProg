using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebalrez.Servicios
{
    /// <summary>
    /// Implementacion a los metodos de menu Interfaz
    /// <author>ebp - 041223</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int MostrarYRecogerMenu()
        {
            int opcion;

            Console.WriteLine("###################################");
            Console.WriteLine("-0 Salir de la aplicación          ");
            Console.WriteLine("-1 Dar de alta nueva vajilla       ");
            Console.WriteLine("-2 Modificar cantidad de vajilla   ");
            Console.WriteLine("-Seleccione una opcion válida      ");
            Console.WriteLine("####################################");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;  
        }
    }
}
