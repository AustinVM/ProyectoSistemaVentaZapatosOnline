namespace CapaEntidades.Productos
{
    public class Ce_Color
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public Ce_Color()
        {
            Id = 0;
            Nombre = "";
            Estado = true;
        }
    }
}
