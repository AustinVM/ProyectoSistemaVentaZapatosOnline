using CapaDatos.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Productos
{
    public class Cd_Material
    {
        public DataTable ConsultarMaterial()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conex = new SqlConnection(Cd_Conexion._rutaBaseDatos))
            {

                using (SqlCommand cmd = new SqlCommand("SP_ConsultarMaterial", conex))
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
