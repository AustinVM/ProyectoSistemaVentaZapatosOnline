using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
