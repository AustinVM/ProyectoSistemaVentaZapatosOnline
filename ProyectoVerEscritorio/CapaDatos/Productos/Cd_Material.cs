using CapaDatos.Conexion;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Productos
{
    public class Cd_Material
    {
        public DataTable ConsultarMaterial()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {
                conex.Open();
                using (SqlCommand cmd = new SqlCommand("SP_ConsultarMaterial", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader leer = cmd.ExecuteReader();
                    tabla.Load(leer);

                }
            }
            return tabla;
        }
    }
}
