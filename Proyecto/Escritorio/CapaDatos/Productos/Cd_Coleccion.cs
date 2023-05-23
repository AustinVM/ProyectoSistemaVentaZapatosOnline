using CapaDatos.Conexion;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Productos
{
    public class Cd_Coleccion
    {

        public DataTable ConsultarColeccion()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {

                using (SqlCommand cmd = new SqlCommand("SP_ConsultarColeccion", conex))
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
