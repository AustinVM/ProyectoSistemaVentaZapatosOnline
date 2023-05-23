using CapaDatos.Productos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
