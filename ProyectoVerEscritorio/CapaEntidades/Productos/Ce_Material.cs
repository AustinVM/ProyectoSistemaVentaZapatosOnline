namespace CapaEntidades.Productos
{
    public class Ce_Material
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public Ce_Material()
        {
            Id = 0;
            Nombre = "";
            Estado = true;
        }
    }
}
