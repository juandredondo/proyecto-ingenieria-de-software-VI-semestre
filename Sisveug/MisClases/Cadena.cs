using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;


namespace Sisveug.MisClases
{
    class Cadena
    {

        public string CadenaApp;
        public string Obtenercadena()
        {
            // este metodo se usa para obener la cadena de conexio que esta en el archivo appconfig en donde se encuentra la cadena de conexion 
            CadenaApp = ConfigurationManager.ConnectionStrings["APPcadena"].ConnectionString;

            return CadenaApp;
        }


    }
}
