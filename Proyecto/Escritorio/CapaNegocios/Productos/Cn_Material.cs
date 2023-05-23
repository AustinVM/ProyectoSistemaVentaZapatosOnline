using CapaDatos.Productos;
using System.Data;

namespace CapaNegocios.Productos
{
    public class Cn_Material
    {
        Cd_Material oCd_Material = new Cd_Material();
        public DataTable ConsultarMaterial()
        {
            DataTable tabla = oCd_Material.ConsultarMaterial();
            return tabla;
        }
    }
}
