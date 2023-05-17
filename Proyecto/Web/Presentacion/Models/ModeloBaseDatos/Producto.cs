using System;
using System.Collections.Generic;

namespace Presentacion.Models.ModeloBaseDatos;

public partial class Producto
{
    public int Id { get; set; }

    public string NombreProducto { get; set; } = null!;

    public int IdColor { get; set; }

    public int IdColeccion { get; set; }

    public int IdMaterial { get; set; }

    public int IdTipoCalzado { get; set; }

    public bool? Estado { get; set; }

    public virtual Coleccion IdColeccionNavigation { get; set; } = null!;

    public virtual Color IdColorNavigation { get; set; } = null!;

    public virtual Material IdMaterialNavigation { get; set; } = null!;

    public virtual TipoCalzado IdTipoCalzadoNavigation { get; set; } = null!;

    public virtual ICollection<ProductoTalla> ProductoTallas { get; set; } = new List<ProductoTalla>();
}
