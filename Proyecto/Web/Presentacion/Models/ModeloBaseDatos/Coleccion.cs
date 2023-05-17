using System;
using System.Collections.Generic;

namespace Presentacion.Models.ModeloBaseDatos;

public partial class Coleccion
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Epoca { get; set; } = null!;

    public bool? Estado { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
