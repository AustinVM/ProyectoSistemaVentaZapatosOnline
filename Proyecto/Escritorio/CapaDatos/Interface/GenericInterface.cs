using System.Data;

namespace CapaDatos.Interface
{
    public interface GenericInterface
    {
        void Guardar();
        DataTable Mostrar();
        void Actualizar();
        void Eliminar();
    }
}
