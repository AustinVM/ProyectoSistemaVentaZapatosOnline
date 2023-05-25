using CapaDatos.Conexion;
using CapaEntidades.Productos;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Productos
{
    public class Cd_Productos
    {
        public void AgregarProducto(Ce_Producto AgregarProducto)
        {
            using (SqlConnection conex = new(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new("SP_AgregarProducto", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreProducto", AgregarProducto.NombreProducto);
                    cmd.Parameters.AddWithValue("@IdColor", AgregarProducto.IdColor);
                    cmd.Parameters.AddWithValue("@IdColeccion", AgregarProducto.IdColeccion);
                    cmd.Parameters.AddWithValue("@IdMaterial", AgregarProducto.IdMaterial);
                    cmd.Parameters.AddWithValue("@IdTIpoCalzado", AgregarProducto.IdTipoCalzado);
                    cmd.Parameters.AddWithValue("@ImagenProducto", AgregarProducto.ImagenProducto);
                    cmd.Parameters.AddWithValue("@Estado", AgregarProducto.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ConsultarProductos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("ConsultarProducto", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader leer = cmd.ExecuteReader();
                    tabla.Load(leer);
                }
            }
            return tabla;
        }

        public void Editarproducto(Ce_Producto EditarProducto)
        {
            using (SqlConnection conex = new(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new("SP_ActualizarProducto", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", EditarProducto.Id);
                    cmd.Parameters.AddWithValue("@NombreProducto", EditarProducto.NombreProducto);
                    cmd.Parameters.AddWithValue("@IdColor", EditarProducto.IdColor);
                    cmd.Parameters.AddWithValue("@IdColeccion", EditarProducto.IdColeccion);
                    cmd.Parameters.AddWithValue("@IdMaterial", EditarProducto.IdMaterial);
                    cmd.Parameters.AddWithValue("@IdTIpoCalzado", EditarProducto.IdTipoCalzado);
                    cmd.Parameters.AddWithValue("@ImagenProducto", EditarProducto.ImagenProducto);
                    cmd.Parameters.AddWithValue("@Estado", EditarProducto.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
