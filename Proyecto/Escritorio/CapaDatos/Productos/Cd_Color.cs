using CapaDatos.Conexion;
using CapaEntidades.Productos;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Productos
{
    public class Cd_Color
    {
        public void AgregarColor(Ce_Color AgregarColor)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("AgregarDepartamento", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", AgregarColor.Nombre);
                    cmd.Parameters.AddWithValue("@estado", AgregarColor.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ConsultarColor()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {

                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ConsultarColor", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader leer = cmd.ExecuteReader();
                    tabla.Load(leer);
                }
            }
            return tabla;
        }

        public void ActualizarColor(Ce_Color ActualizarColor)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ActualizarColor", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", ActualizarColor.Id);
                    cmd.Parameters.AddWithValue("@Nombre", ActualizarColor.Nombre);
                    cmd.Parameters.AddWithValue("@Estado", ActualizarColor.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarColor(Ce_Color EliminarColor)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_EliminarColor", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", EliminarColor.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
