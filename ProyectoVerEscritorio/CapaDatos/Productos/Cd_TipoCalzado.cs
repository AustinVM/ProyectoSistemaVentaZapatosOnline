using CapaDatos.Conexion;
using CapaEntidades.Productos;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Productos
{
    public class Cd_TipoCalzado
    {
        public void AgregarTipoCalzado(Ce_TipoCalzado AgregarTipoCalzado)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("AgregarTipoCalzado", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", AgregarTipoCalzado.Nombre);
                    cmd.Parameters.AddWithValue("@estado", AgregarTipoCalzado.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ConsultarTipoCalzado()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ConsultarTipoCalzado", conex))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public void ActualizarTipoCalzado(Ce_TipoCalzado ActualizarTipoCalzado)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AggTipoCalzado", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ActualizarTipoCalzado.Id);
                    cmd.Parameters.AddWithValue("@nombre", ActualizarTipoCalzado.Nombre);
                    cmd.Parameters.AddWithValue("@estado", ActualizarTipoCalzado.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarTipoCalzado(Ce_TipoCalzado EliminarTipoCalzado)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AggTipoCalzado", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", EliminarTipoCalzado.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable ConsultarTipoCalzado(int id)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {

                using (SqlCommand cmd = new SqlCommand("SP_ConsultarTipoCalzado", conex))
                {
                    conex.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader leer = cmd.ExecuteReader();
                    tabla.Load(leer);

                }
            }
            return tabla;
        }
    }
}
