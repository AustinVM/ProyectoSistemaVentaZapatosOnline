using CapaDatos.Conexion;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Cd_Departamento
    {
        public void AgregarDepartamento(Ce_Departamento AgregarDepartamento)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AgregarDepartamento", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", AgregarDepartamento.Nombre);
                    cmd.Parameters.AddWithValue("@Estado", AgregarDepartamento.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ConsultarDepartamento()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ConsultarDepartamento", conex))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public void ActualizarDepartamento(Ce_Departamento ActualizarDepartamento)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AggDepartamento", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", ActualizarDepartamento.Id);
                    cmd.Parameters.AddWithValue("@Nombre", ActualizarDepartamento.Nombre);
                    cmd.Parameters.AddWithValue("@Estado", ActualizarDepartamento.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarDepartamento(Ce_Departamento EliminarDepartamento)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AggDepartamento", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", EliminarDepartamento.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
