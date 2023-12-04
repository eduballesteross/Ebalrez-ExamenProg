
using Ebalrez.Dtos;
using Ebalrez.Servicios;

namespace Ebalrez
{
        
    /// <summary>
    /// Clase principal de la aplicación 
    ///<author>ebp - 041223</author>
    /// </summary>

    internal class Program
    {
        /// <summary>
        /// Método principal de entrada para la aplicación
        /// <author>ebp - 041223</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) 
        {

            List<VajillaDto>listaVajilla =new List<VajillaDto>();
            
            MenuInterfaz menuI =new MenuImplementacion();   
            VajillaInterfaz vajillaI = new VajillaImplementacion();

            int opcion;
            bool cerrarMenu = false;   
            
            while (!cerrarMenu) 
            {
                opcion = menuI.MostrarYRecogerMenu();
                Console.WriteLine(opcion);
                switch (opcion) 
                {
                    case 0:
                        Console.WriteLine("Has seleccionado la opcion salir del menu.");
                        cerrarMenu=true;    
                        break;

                    case 1:
                        Console.WriteLine("* Has seleccionado la opcion de dar de alta una nueva vajilla");
                        vajillaI.darAltaVajilla(listaVajilla);

                        foreach(VajillaDto vajilla in listaVajilla)
                        {
                            Console.WriteLine(vajilla.ToString());
                        }
                        break;

                    case 2:
                        Console.WriteLine("* Has seleccionado la opcion de modificar la cantidad de la vajilla.");
                        vajillaI.modificarCantidadVajilla(listaVajilla);
                        foreach (VajillaDto vajilla in listaVajilla)
                        {
                            Console.WriteLine(vajilla.ToString());
                        }
                       
                        break;

                    default: Console.WriteLine("Has introducido una opcion incorrecta.");
                        break;  
                }
            }
        }
    }
}
