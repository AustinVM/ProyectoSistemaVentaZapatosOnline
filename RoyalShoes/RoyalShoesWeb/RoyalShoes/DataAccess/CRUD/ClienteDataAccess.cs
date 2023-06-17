using RoyalShoes.Models.CRUD;
using System.Data;
using System.Data.SqlClient;

namespace RoyalShoes.DataAccess.CRUD
{
    public class ClienteDataAccess
    {
        private readonly IConfiguration _configuration;

        public ClienteDataAccess(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<ClienteModels>> Mostrar()
        {
            string connectionString = _configuration.GetConnectionString("NaturVida");

            List<ClienteModels> _listaClientes = new List<ClienteModels>();

            using (var conex = new SqlConnection(connectionString))
            {
                conex.Open();
                using (var cmd = new SqlCommand("SP_MOSTRARCLIENTE", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();

                    while (await dr.ReadAsync())
                    {
                        ClienteModels Cliente = new()
                        {
                            Documento = dr.GetInt32(0),
                            Nombre = dr.GetString(1),
                            Direccion = dr.GetString(2),
                            Telefono = dr.GetString(3),
                            Correo = dr.GetString(4)
                        };

                        _listaClientes.Add(Cliente);
                    }
                }
            }
            return _listaClientes;
        }

        public async Task<bool> Guardar(ClienteModels Guardar)
        {
            string connectionString = _configuration.GetConnectionString("NaturVida");

            using (var conex = new SqlConnection(connectionString))
            {
                conex.Open();
                using (var cmd = new SqlCommand("SP_INSERTARCLIENT", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Docu", Guardar.Documento);
                    cmd.Parameters.AddWithValue("@Nombre", Guardar.Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", Guardar.Direccion);
                    cmd.Parameters.AddWithValue("@Tel", Guardar.Telefono);
                    cmd.Parameters.AddWithValue("@Corr", Guardar.Correo);

                    int filasAfectadas = await cmd.ExecuteNonQueryAsync();

                    return (filasAfectadas > 0) ? true : false;
                }
            }
        }

        public async Task<bool> Editar(ClienteModels Guardar)
        {
            string connectionString = _configuration.GetConnectionString("NaturVida");

            using (var conex = new SqlConnection(connectionString))
            {
                conex.Open();
                using (var cmd = new SqlCommand("SP_EDITARCLIENT", conex))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Docu", Guardar.Documento);
                    cmd.Parameters.AddWithValue("@Nombre", Guardar.Nombre);
                    cmd.Parameters.AddWithValue("@Direccion", Guardar.Direccion);
                    cmd.Parameters.AddWithValue("@Tel", Guardar.Telefono);
                    cmd.Parameters.AddWithValue("@Corr", Guardar.Correo);

                    int filasAfectadas = await cmd.ExecuteNonQueryAsync();

                    return filasAfectadas > 0;
                }
            }
        }
    }
}
