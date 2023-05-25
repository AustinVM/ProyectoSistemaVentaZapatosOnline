namespace CapaEntidades.UsuarioSistema
{
    public class Ce_Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string CorreoElectronico { get; set; }
        public string ContraseniaUsuario { get; set; }
        public int IdRol { get; set; }
        public bool EstadoUsuario { get; set; }

        public Ce_Usuario()
        {
            Id = 0;
            NombreUsuario = "";
            CorreoElectronico = "";
            ContraseniaUsuario = "";
            IdRol = 0;
            EstadoUsuario = true;
        }

        public Ce_Usuario(string NombreUsuario, string ContraseniaUsuario, int IdRol)
        {
            Id = 0;
            this.NombreUsuario = NombreUsuario;
            this.ContraseniaUsuario = ContraseniaUsuario;
            this.IdRol = IdRol;
            EstadoUsuario = true;
        }

        public Ce_Usuario(string NombreUsuario, string CorreoElectronico, string ContraseniaUsuario, int IdRol)
        {
            Id = 0;
            this.NombreUsuario = NombreUsuario;
            this.CorreoElectronico = CorreoElectronico;
            this.ContraseniaUsuario = ContraseniaUsuario;
            this.IdRol = IdRol;
            EstadoUsuario = true;
        }

        public Ce_Usuario(string NombreUsuario, string CorreoElectronico, string ContraseniaUsuario, int IdRol, bool EstadoUsuario)
        {
            Id = 0;
            this.NombreUsuario = NombreUsuario;
            this.CorreoElectronico = CorreoElectronico;
            this.ContraseniaUsuario = ContraseniaUsuario;
            this.IdRol = IdRol;
            this.EstadoUsuario = EstadoUsuario;
        }
    }
}