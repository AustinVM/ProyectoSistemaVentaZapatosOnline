using CapaDatos.Productos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Productos
{
    public class Cn_Color
    {
        Cd_Color oCd_Color = new Cd_Color();    
        

        public DataTable ConsultarColor()
        {
            DataTable tabla = oCd_Color.ConsultarColor();
            return tabla;
        }
    }
}
