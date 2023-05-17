using System;
using System.Collections.Generic;

namespace Presentacion.Models.ModeloBaseDatos;

public partial class DetallesFactura
{
    public int Id { get; set; }

    public int IdPedido { get; set; }

    public string? Descripcion { get; set; }

    public int IdTipoPago { get; set; }

    public int IdIva { get; set; }

    public int Subtotal { get; set; }

    public int Total { get; set; }

    public virtual Factura? Factura { get; set; }

    public virtual Iva IdIvaNavigation { get; set; } = null!;

    public virtual Pedido IdPedidoNavigation { get; set; } = null!;

    public virtual TipoPago IdTipoPagoNavigation { get; set; } = null!;
}
