namespace CapaEntidades.Productos
{
    public class Ce_Talla
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public Ce_Talla()
        {
            Id = 0;
            Nombre = "";
            Estado = true;
        }
    }
}
