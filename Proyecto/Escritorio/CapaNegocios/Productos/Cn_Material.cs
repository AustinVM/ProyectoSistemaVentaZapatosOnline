using CapaDatos.Productos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
