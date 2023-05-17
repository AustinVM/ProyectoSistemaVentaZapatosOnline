using System;
using System.Collections.Generic;

namespace Presentacion.Models.ModeloBaseDatos;

public partial class Talla
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public bool? Estado { get; set; }

    public virtual ICollection<ProductoTalla> ProductoTallas { get; set; } = new List<ProductoTalla>();
}
