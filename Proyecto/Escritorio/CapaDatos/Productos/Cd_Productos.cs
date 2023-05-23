using CapaDatos.Conexion;
using CapaEntidades.Productos;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Productos
{
    public class Cd_Productos
    {
        public static void AgregarProducto(Ce_Producto AgregarProducto)
        {
            using SqlConnection conex = new(Cd_Conexion._rutaBaseDatos);

            conex.Open();
            using SqlCommand cmd = new("SP_AgregarUsuario", conex);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NombreProducto", AgregarProducto.NombreProducto);
            cmd.Parameters.AddWithValue("@IdColor", AgregarProducto.IdColor);
            cmd.Parameters.AddWithValue("@IdColeccion", AgregarProducto.IdColeccion);
            cmd.Parameters.AddWithValue("@IdMaterial", AgregarProducto.IdMaterial);
            cmd.Parameters.AddWithValue("@IdTIpoCalzado", AgregarProducto.IdTipoCalzado);
            cmd.ExecuteNonQuery();


        }




    }
}
