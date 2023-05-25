using CapaDatos.Productos;
using CapaEntidades.Productos;
using System.Data;

namespace CapaNegocios.Productos
{
    public class Cn_Productos
    {
        Cd_Productos oCd_Productos = new Cd_Productos();
        public void AgregarProducto(Ce_Producto AgregarProducto)
        {
            oCd_Productos.AgregarProducto(AgregarProducto);
        }

        public void EditarProducto(Ce_Producto EditarProducto)
        {
            oCd_Productos.Editarproducto(EditarProducto);
        }

        public DataTable ConsultarProducto()
        {
            DataTable dt = oCd_Productos.ConsultarProductos();

            return dt;
        }

        public void EliminarProducto(Ce_Producto EliminarProducto) 
        { 
            oCd_Productos.EliminarProducto(EliminarProducto);
        
        }
    }

}
