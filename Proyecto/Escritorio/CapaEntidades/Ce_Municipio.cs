namespace CapaEntidades
{
    public class Ce_Municipio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdDepartamento { get; set; }
        public bool Estado { get; set; }

        public Ce_Municipio()
        {
            Id = 0;
            Nombre = "";
            IdDepartamento = 0;
            Estado = true;
        }
    }
}
