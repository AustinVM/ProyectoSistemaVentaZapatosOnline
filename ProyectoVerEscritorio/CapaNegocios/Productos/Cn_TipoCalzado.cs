using CapaDatos.Productos;
using System.Data;

namespace CapaNegocios.Productos
{
    public class Cn_TipoCalzado
    {
        Cd_TipoCalzado oCd_TipoCalzado = new Cd_TipoCalzado();
        public DataTable ConsultarTipoCalzado()
        {
            DataTable tabla = oCd_TipoCalzado.ConsultarTipoCalzado();
            return tabla;
        }
    }
}
