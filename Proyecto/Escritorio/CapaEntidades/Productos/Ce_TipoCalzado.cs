namespace CapaEntidades.Productos
{
    public class Ce_TipoCalzado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public Ce_TipoCalzado()
        {
            Id = 0;
            Nombre = "";
            Estado = true;
        }
    }
}
