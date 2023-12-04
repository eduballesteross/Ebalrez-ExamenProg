using Ebalrez.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebalrez.Servicios
{
    /// <summary>
    /// Implementacion a los métodos de VajillaInterfaz
    /// <author>041223</author>
    /// </summary>
    internal class VajillaImplementacion : VajillaInterfaz
    {
        public long buscarID()
        {
            long longABuscar;

            Console.WriteLine("Introduzca el ID para buscarlo en la base de datos y realizar la acción deseada");
            longABuscar = Convert.ToInt64(Console.ReadLine());  

            return longABuscar; 
        }


        public void darAltaVajilla(List<VajillaDto> listaVajilla)
        {
            VajillaDto vajilla = NuevaBajilla();
            listaVajilla.Add(vajilla);  
        }

        

        public void modificarCantidadVajilla(List<VajillaDto> listaVajilla)
        {
            long idABuscar;

            idABuscar = buscarID();

            foreach (VajillaDto vajilla in listaVajilla)
            {
                if (vajilla.IdVajilla.Equals(idABuscar))
                {
                    int vajillARestar;
                    Console.WriteLine("Introduzca el número de vajilla que deseas restar.");
                    vajillARestar=Convert.ToInt32(Console.ReadLine());

                    vajilla.CantidadVajilla = (vajilla.CantidadVajilla - vajillARestar);
                    break;
                }
                else
                {
                    Console.WriteLine("Has introducido un ID incorrecto.");
                    break;
                }
            }
        }

        private VajillaDto NuevaBajilla()
        {
            VajillaDto nuevavajilla = new VajillaDto();

            Console.WriteLine("Introduzca un ID para la nueva vajilla.");
            nuevavajilla.IdVajilla=Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el nombre de la vajilla.");
            nuevavajilla.NombreVajilla = Console.ReadLine();

            Console.WriteLine("Introduce una descripcion de la vajilla.");
            nuevavajilla.DescrVajilla = Console.ReadLine();

            Console.WriteLine("Introduzca la cantidad de vajilla correspondiente.");
            nuevavajilla.CantidadVajilla = Convert.ToInt32(Console.ReadLine());   

            return nuevavajilla;    
        }
    }
}
