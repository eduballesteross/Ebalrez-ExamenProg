using Ebalrez.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebalrez.Servicios
{
    /// <summary>
    /// Listado de métodos relacionados con el ente Vajilla
    /// <author>ebp -041223</author>
    /// </summary>
    
    internal interface VajillaInterfaz
    {
        /// <summary>
        /// Método que sirve para dar de alta una nueva vajilla
        /// <author>041223</author>
        /// </summary>
        /// <param name="listaVajilla"></param>
        public void darAltaVajilla(List<VajillaDto> listaVajilla);

        /// <summary>
        /// Método que permite restar la cantidad de vajilla actual
        /// </summary>
        /// <param name="listaVajilla"></param>
        public void modificarCantidadVajilla(List<VajillaDto> listaVajilla);

        /// <summary>
        /// Método que recoge un long para posteriormente compararlo
        /// </summary>
        /// <returns>long</returns>
        public long buscarID();
    }
}
