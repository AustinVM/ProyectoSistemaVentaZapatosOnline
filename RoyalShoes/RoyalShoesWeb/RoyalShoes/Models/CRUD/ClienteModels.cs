namespace RoyalShoes.Models.CRUD
{
    public class ClienteModels
    {
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public ClienteModels()
        {
            Documento = 0;
            Nombre = "";
            Direccion = "";
            Telefono = "";
            Correo = "";
        }
    }
}
