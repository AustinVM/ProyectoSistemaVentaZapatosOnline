using System;
using System.Collections.Generic;

namespace Presentacion.Models.ModeloBaseDatos;

public partial class Pedido
{
    public int Id { get; set; }

    public string IdCliente { get; set; } = null!;

    public int IdProductoTalla { get; set; }

    public short CantidadPedido { get; set; }

    public bool? Estado { get; set; }

    public virtual DetallesFactura? DetallesFactura { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual ProductoTalla IdProductoTallaNavigation { get; set; } = null!;
}
