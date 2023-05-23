using CapaDatos.Productos;
using System.Data;

namespace CapaNegocios.Productos
{
    public class Cn_Color
    {
        Cd_Color oCd_Color = new Cd_Color();

        public DataTable ConsultarColor()
        {
            return oCd_Color.ConsultarColor();
        }
    }
}
