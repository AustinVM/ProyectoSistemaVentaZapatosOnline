namespace RoyalShoes.DataAccess.CRUD
{
    public class ConexionDataAccess  /* Clase en la que obtengo la cadena de conexion para poder usarla en otros lugare */
    {
        private readonly IConfiguration _configuration;

        public ConexionDataAccess(IConfiguration configuration) /* Ni idea */
        {
            _configuration = configuration;
        }

        private string GetConnectionString()  /* Metodo en el cual obtengo la cadena de conexion desde "appsttings.json" */
        {
            string connectionString = _configuration.GetConnectionString("NaturVida");
            return connectionString;
        }

        public string SetConnectionString() /* Metodo que retorna la cadena de conexion obtenida */
        {
            return GetConnectionString();
        }
    }
}
