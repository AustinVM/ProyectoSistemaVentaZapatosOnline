namespace CapaEntidades.UsuarioSistema
{
    public class Ce_Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public Ce_Rol()
        {
            Id = 0;
            Nombre = "";
            Estado = true;
        }
    }
}