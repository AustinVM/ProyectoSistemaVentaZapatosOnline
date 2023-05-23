using CapaDatos.Productos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Productos
{
    public class Cn_Coleccion
    {
        Cd_Coleccion oCd_Coleccion = new Cd_Coleccion();


        public DataTable ConsultarColeccion()
        {
            DataTable tabla = oCd_Coleccion.ConsultarColeccion();
            return tabla;
        }
    }
}
