using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebalrez.Dtos
{
    internal class VajillaDto
    {
        //ATRIBUTOS
        long idVajilla = 0;
        string nombreVajilla = "aaaaa";
        string descrVajilla = "aaaaa";
        string codigoVajilla = "aaaaa";
        int cantidadVajilla = (0);

        //CONSTRUCTOES
        public VajillaDto(long idVajilla, string codigoVajilla, string nombreVajilla, string descrVajilla, int cantidadVajilla)
        {
            this.idVajilla = idVajilla;
            this.nombreVajilla = nombreVajilla;
            this.descrVajilla = descrVajilla;
            this.cantidadVajilla = cantidadVajilla;
            this.codigoVajilla = codigoVajilla;
        }

        public VajillaDto() { }

       

        //GETTERS & SETTERS
        public long IdVajilla { get => idVajilla; set => idVajilla = value; }
        public string NombreVajilla { get => nombreVajilla; set => nombreVajilla = value; }
        public string DescrVajilla { get => descrVajilla; set => descrVajilla = value; }
        public int CantidadVajilla { get => cantidadVajilla; set => cantidadVajilla = value; }
        public string CodigoVajilla { get => codigoVajilla; set => codigoVajilla = value; }

        //TO STRING 

        public string ToString()
        {
            string nuevajilla = //"ID:" + this.IdVajilla +
            "|Nombre:" + this.NombreVajilla +
            //"|Descripcion de la Vajilla:" + this.DescrVajilla +
            "|Cantidad:" + this.CantidadVajilla;
            
            return nuevajilla;  

        }
    }
}
