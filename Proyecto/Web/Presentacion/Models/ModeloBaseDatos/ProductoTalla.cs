using System;
using System.Collections.Generic;

namespace Presentacion.Models.ModeloBaseDatos;

public partial class ProductoTalla
{
    public int Id { get; set; }

    public int IdProducto { get; set; }

    public int IdTalla { get; set; }

    public int ValUnitario { get; set; }

    public short Stock { get; set; }

    public bool? Estado { get; set; }

    public virtual Producto IdProductoNavigation { get; set; } = null!;

    public virtual Talla IdTallaNavigation { get; set; } = null!;

    public virtual Pedido? Pedido { get; set; }
}
