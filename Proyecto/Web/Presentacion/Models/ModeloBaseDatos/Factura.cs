using System;
using System.Collections.Generic;

namespace Presentacion.Models.ModeloBaseDatos;

public partial class Factura
{
    public int Id { get; set; }

    public DateTime FchExpedicion { get; set; }

    public string IdCliente { get; set; } = null!;

    public int IdDetallesFactura { get; set; }

    public int IdMunicipio { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual DetallesFactura IdDetallesFacturaNavigation { get; set; } = null!;

    public virtual Municipio IdMunicipioNavigation { get; set; } = null!;
}
