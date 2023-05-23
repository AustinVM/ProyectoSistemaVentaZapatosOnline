namespace CapaEntidades.Productos
{
    public class Ce_Producto
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public int IdColor { get; set; }
        public int IdColeccion { get; set; }
        public int IdMaterial { get; set; }
        public int IdTipoCalzado { get; set; }
        public bool Estado { get; set; }

        public Ce_Producto()
        {
            Id = 0;
            NombreProducto = "";
            IdColor = 0;
            IdColeccion = 0;
            IdMaterial = 0;
            IdTipoCalzado = 0;
            Estado = true;
        }
    }
}
