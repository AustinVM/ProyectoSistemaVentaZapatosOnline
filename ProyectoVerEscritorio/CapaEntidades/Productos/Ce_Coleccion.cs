namespace CapaEntidades.Productos
{
    public class Ce_Coleccion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Epoca { get; set; }
        public bool Estado { get; set; }

        public Ce_Coleccion()
        {
            Id = 0;
            Nombre = "";
            Epoca = "";
            Estado = true;
        }
    }
}
