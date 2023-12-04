using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebalrez.Servicios
{
    /// <summary>
    /// Listado de los métodos realizados en relación con el menu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el menu y recoge la opcion seleccionada.
        /// </summary>
        /// <returns></returns>
        public int MostrarYRecogerMenu();
    }
}
