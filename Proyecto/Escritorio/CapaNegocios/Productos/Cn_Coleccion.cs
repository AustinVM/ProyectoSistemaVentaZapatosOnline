using CapaDatos.Productos;
using System.Data;

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
