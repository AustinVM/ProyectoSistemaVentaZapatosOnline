using CapaDatos.Conexion;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Cd_Municipio
    {
        public void AgregarMunicipio(Ce_Municipio AgregarMunicipio)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_AgregarMunicipio", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", AgregarMunicipio.Nombre);
                    cmd.Parameters.AddWithValue("@IdDepartamento", AgregarMunicipio.IdDepartamento);
                    cmd.Parameters.AddWithValue("@Estado", AgregarMunicipio.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ConsultarMunicipio(Ce_Municipio ConsultarMunicipio)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ConsultarMunicipio", conex))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    cmd.Parameters.AddWithValue("@IdDepartamento", ConsultarMunicipio.IdDepartamento);
                    dt.Load(dr);
                }
            }
            return dt;
        }

        public void ActualizarMunicipio(Ce_Municipio ActualizarMunicipio)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ActualizarMunicipio", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", ActualizarMunicipio.Id);
                    cmd.Parameters.AddWithValue("@Nombre", ActualizarMunicipio.Nombre);
                    cmd.Parameters.AddWithValue("@Estado", ActualizarMunicipio.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarMunicipio(Ce_Municipio EliminarMunicipio)
        {
            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_EliminarMunicipio", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", EliminarMunicipio.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
